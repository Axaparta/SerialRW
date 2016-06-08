using SerialRW.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using SerialRW.Common;
using System.Diagnostics;

namespace SerialRW.Forms
{
	public partial class MainForm: Form
	{
		#region LogRoutes
		private enum LogType { Info, Error, Receive, Send, Time };

		[DllImport("user32.dll")]
		private static extern int HideCaret(IntPtr hwnd);
		#endregion

		private AutoResetEvent FReadDataEvent = new AutoResetEvent(false);
		private object FReadDataLocker = new object();
		private List<byte> FReadData = new List<byte>();

		public MainForm()
		{
			InitializeComponent();
			Text += string.Format(" v{0}", Assembly.GetExecutingAssembly().GetName().Version.ToString(3));
			Icon = Properties.Resources.App;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.SuspendLayout();

			Program.Settings.MainForm.ToForm(this);

			PortRefreshMenuItem_Click(null, null);

			foreach (var br in SerialPortSettings.BaudrateEnum)
			{
				ToolStripMenuItem mi = new ToolStripMenuItem(br.ToString());
				mi.Click += PortBaudrateMenuItem_Click;
				mi.Tag = br;
				PortBaudrateMenuItem.DropDownItems.Add(mi);
			}
			PortBaudrateComboBox.Items.AddRange(SerialPortSettings.BaudrateEnum.Cast<object>().ToArray());
			PortBaudrateMenuItem_Click(null, null);

			ViewMenuItemUpdate();
			MsCleanButton_Click(null, null);

			EncodingMenuUpdate(true);

			for (int i = 0; i < SerialRWSettings.DataCoders.Length; i++)
			{
				ToolStripMenuItem mi = new ToolStripMenuItem(SerialRWSettings.DataCoders[i].Name);
				mi.Click += SendDataCoderMenuItem_Click;
				mi.Tag = i;
				SendDataCoderMenuItem.DropDownItems.Add(mi);
			}
			SendDataCoderMenuItem_Click(null, null);

			for (int i = 0; i < SerialRWSettings.DataCoders.Length; i++)
			{
				ToolStripMenuItem mi = new ToolStripMenuItem(SerialRWSettings.DataCoders[i].Name);
				mi.Click += ReceiveDataCoderMenuItem_Click;
				mi.Tag = i;
				ReceiveDataCoderMenuItem.DropDownItems.Add(mi);
			}
			ReceiveDataCoderMenuItem_Click(null, null);

			Thread t = new Thread(new ThreadStart(SerialPortReadDataLoop));
			t.IsBackground = true;
			t.Start();

			this.ResumeLayout();
		}

		private void ReceiveDataCoderMenuItem_Click(object sender, EventArgs e)
		{
			if (sender != null)
				Program.Settings.ReceiveCoderIndex = (int)((ToolStripMenuItem)sender).Tag;

			if (Program.Settings.ReceiveCoderIndex >= SerialRWSettings.DataCoders.Length)
				Program.Settings.ReceiveCoderIndex = 0;

			foreach (ToolStripMenuItem i in ReceiveDataCoderMenuItem.DropDownItems)
			{
				i.Checked = (int)i.Tag == Program.Settings.ReceiveCoderIndex;
				if (i.Checked)
					ReceiveStatusLabel.Text = string.Format("Получение: '{0}'", i.Text);
			}
		}

		private void SendDataCoderMenuItem_Click(object sender, EventArgs e)
		{
			if (sender != null)
				Program.Settings.SendCoderIndex = (int)((ToolStripMenuItem)sender).Tag;

			if (Program.Settings.SendCoderIndex >= SerialRWSettings.DataCoders.Length)
				Program.Settings.SendCoderIndex = 0;

			foreach (ToolStripMenuItem i in SendDataCoderMenuItem.DropDownItems)
			{
				i.Checked = (int)i.Tag == Program.Settings.SendCoderIndex;
				if (i.Checked)
					SendStatusLabel.Text = string.Format("Отправка: '{0}'", i.Text);
			}
		}

		private void EncodingMenuUpdate(bool ARebuild)
		{
			if (ARebuild)
			{
				TopMenuStrip.SuspendLayout();

				while (EncodingFormatMenuItem.DropDownItems.Count > 2)
					EncodingFormatMenuItem.DropDownItems.RemoveAt(0);

				foreach (var enc in Program.Settings.UserEncodings.Reverse<string>())
				{
					ToolStripMenuItem mi = new ToolStripMenuItem(enc);
					mi.Click += EncodingMenuItem_Click;
					EncodingFormatMenuItem.DropDownItems.Insert(0, mi);
				}
				TopMenuStrip.ResumeLayout();
			}

			foreach (ToolStripItem item in EncodingFormatMenuItem.DropDownItems)
				if (item is ToolStripMenuItem)
					(item as ToolStripMenuItem).Checked = item.Text == Program.Settings.UserEncoding.HeaderName;

			EncodingStatusLabel.Text = Program.Settings.UserEncoding.HeaderName;
		}

		void EncodingMenuItem_Click(object sender, EventArgs e)
		{
			Program.Settings.UserEncodingName = ((ToolStripMenuItem)sender).Text;
			EncodingMenuUpdate(false);
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (SerialPort.IsOpen)
				PortOpenMenuItem_Click(null, null);
			Program.Settings.PortPanel.FromToolStrip(PortToolStrip);
			Program.Settings.MainForm.FromForm(this);
		}

		private void PortRefreshMenuItem_Click(object sender, EventArgs e)
		{
			this.SuspendLayout();

			var pns = SerialPortSettings.PortNameEnum;

			PortNameMenuItem.DropDownItems.Clear();
			foreach (var s in pns)
			{
				ToolStripMenuItem mi = new ToolStripMenuItem(s.ToString());
				mi.Tag = s;
				mi.Click += PortNameMenuItem_Click;
				PortNameMenuItem.DropDownItems.Add(mi);
			}

			PortNameComboBox.Items.Clear();
			PortNameComboBox.Items.AddRange(pns.Select(p => p.Name).ToArray());

			PortNameMenuItem_Click(null, null);

			this.ResumeLayout();
		}

		private void PortNameMenuItem_Click(object sender, EventArgs e)
		{
			if (sender is ToolStripComboBox)
				//	Program.Settings.SerialPort.PortNameValue = ((SerialPortName)((ToolStripComboBox)sender).SelectedItem).Name;
				Program.Settings.SerialPort.PortNameValue = (string)((ToolStripComboBox)sender).SelectedItem;
			if (sender is ToolStripMenuItem)
				Program.Settings.SerialPort.PortNameValue = ((SerialPortName)((ToolStripMenuItem)sender).Tag).Name;

			foreach (ToolStripMenuItem mi in PortNameMenuItem.DropDownItems)
				mi.Checked = ((SerialPortName)mi.Tag).Name == Program.Settings.SerialPort.PortNameValue;

			PortNameComboBox.SelectedIndexChanged -= PortNameMenuItem_Click;
			PortNameComboBox.SelectedIndex = -1;

			PortNameComboBox.SelectedIndex = PortNameComboBox.Items.IndexOf(Program.Settings.SerialPort.PortNameValue);
			//for (int i = 0; i < PortNameComboBox.Items.Count; i++)
			//	if (((SerialPortName)PortNameComboBox.Items[i]).Name == Program.Settings.SerialPort.PortNameValue)
			//	{
			//		PortNameComboBox.SelectedIndex = i;
			//		break;
			//	}

			PortNameComboBox.SelectedIndexChanged += PortNameMenuItem_Click;

			if (sender != null)
				PortReopen();
		}

		private void PortBaudrateMenuItem_Click(object sender, EventArgs e)
		{
			if (sender is ToolStripComboBox)
				Program.Settings.SerialPort.BaudrateValue = (int)((ToolStripComboBox)sender).SelectedItem;
			if (sender is ToolStripMenuItem)
				Program.Settings.SerialPort.BaudrateValue = (int)((ToolStripMenuItem)sender).Tag;

			foreach (ToolStripMenuItem mi in PortBaudrateMenuItem.DropDownItems)
				mi.Checked = (int)mi.Tag == Program.Settings.SerialPort.BaudrateValue;

			PortBaudrateComboBox.SelectedIndexChanged -= PortBaudrateMenuItem_Click;
			PortBaudrateComboBox.SelectedIndex = PortBaudrateComboBox.Items.IndexOf(Program.Settings.SerialPort.BaudrateValue);
			PortBaudrateComboBox.SelectedIndexChanged += PortBaudrateMenuItem_Click;

			if (sender != null)
				PortReopen();
		}

		private void PortSettingsMenuItem_Click(object sender, EventArgs e)
		{
			using (PortSettingsForm dlg = new PortSettingsForm())
			{
				dlg.Settings = (SerialRWSettings)Program.Settings.Clone();
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					Program.Settings = dlg.Settings;
					PortRefreshMenuItem_Click(null, null);
					PortBaudrateMenuItem_Click(null, null);
					PortReopen();
				}
			}
		}

		private void PortOpenMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (SerialPort.IsOpen)
				{
					WriteInfo("Закрытие порта {0}...", SerialPort.PortName);
					SerialPort.Close();
				}
				else
				{
					LogCleanMenuItem_Click(null, null);
					Program.Settings.SerialPort.ToPort(SerialPort);
					WriteInfo("Открытие порта {0}...", Program.Settings.SerialPort);
					SerialPort.Open();
				}
			}
			catch (Exception ex)
			{
				WriteError(ex.Message);
			}

			PortOpenMenuItem.Checked = SerialPort.IsOpen;
			PortOpenButton.Checked = SerialPort.IsOpen;
			PortNameComboBox.Enabled = !SerialPort.IsOpen;
			PortBaudrateComboBox.Enabled = !SerialPort.IsOpen;
		}

		private void WriteReceive(string AMessage, bool AWriteTime)
		{
			if (AWriteTime)
				WriteTime();
			if (AMessage == null)
				WriteLogLine(LogType.Receive, string.Empty);
			else
			{
				WriteLog(LogType.Info, "<< ");
				WriteLogLine(LogType.Receive, AMessage);
			}
		}

		private void WriteSend(string AMessage)
		{
			WriteTime();
			WriteLog(LogType.Info, ">> ");
			WriteLogLine(LogType.Send, AMessage);
		}

		private void WriteTime()
		{
			WriteLog(LogType.Time, "{0:HH:mm:ss.fff} ", DateTime.Now);
		}

		private void WriteInfo(string AFormat, params object[] AArgs)
		{
			WriteLogLine(LogType.Info, AFormat, AArgs);
		}

		private void WriteError(string AFormat, params object[] AArgs)
		{
			WriteLogLine(LogType.Error, AFormat, AArgs);
		}

		private void WriteLogLine(LogType ALogType, string AFormat, params object[] AArgs)
		{
			WriteLog(ALogType, AFormat + Environment.NewLine, AArgs);
		}

		private void PortReopen()
		{
			if (SerialPort.IsOpen)
			{
				PortOpenMenuItem_Click(null, null);
				if (!SerialPort.IsOpen)
					PortOpenMenuItem_Click(null, null);
			}
		}

		private void WriteLog(LogType ALogType, string AFormat, params object[] AArgs)
		{
			Action a = new Action(() =>
				{
					string str = string.Format(AFormat, AArgs);
					int from = LogTextBox.Text.Length;
					LogTextBox.AppendText(str);
					LogTextBox.SelectionStart = from;
					LogTextBox.SelectionLength = str.Length;

					LogTextBox.SelectionFont = LogTextBox.Font;
					LogTextBox.SelectionColor = LogTextBox.ForeColor;
					LogTextBox.SelectionBackColor = LogTextBox.BackColor;
					switch (ALogType)
					{
						case LogType.Info:
							LogTextBox.SelectionColor = Color.Gray;
							break;
						case LogType.Error:
							LogTextBox.SelectionFont = new Font(LogTextBox.Font, FontStyle.Bold);
							LogTextBox.SelectionColor = Color.Red;
							break;
						case LogType.Send:
							LogTextBox.SelectionFont = new Font(LogTextBox.Font, FontStyle.Bold);
							LogTextBox.SelectionColor = Color.DarkGreen;
							break;
						case LogType.Receive:
							LogTextBox.SelectionFont = new Font(LogTextBox.Font, FontStyle.Bold);
							LogTextBox.SelectionColor = Color.DarkSlateBlue;
							break;
						case LogType.Time:
							LogTextBox.SelectionColor = Color.Brown;
							break;
					}

					WinAPI.ScrollToEnd(LogTextBox);
				});

			if (InvokeRequired)
				Invoke(a);
			else
				a();
		}

		private void LogCleanMenuItem_Click(object sender, EventArgs e)
		{
			LogTextBox.Clear();
		}

		private void ViewMenuItemUpdate()
		{
			MainToolStripContainer.SuspendLayout();

			Program.Settings.PortPanel.ToToolStrip(PortToolStrip);
			MainToolStripContainer.ResumeLayout();

			PortVisibleMenuItem.Checked = Program.Settings.PortPanel.Visible;
		}

		private void PortVisibleMenuItem_Click(object sender, EventArgs e)
		{
			Program.Settings.PortPanel.Visible = !Program.Settings.PortPanel.Visible;
			ViewMenuItemUpdate();
		}

		private void MessageVisibleMenuItem_Click(object sender, EventArgs e)
		{
			Program.Settings.MessageVisible = !Program.Settings.MessageVisible;
			ViewMenuItemUpdate();
		}

		private void MsCleanButton_Click(object sender, EventArgs e)
		{
			if (sender != null)
				Program.Settings.MessageCleanAfterSend = !Program.Settings.MessageCleanAfterSend;
		}

		private void MsSendButton_Click(object sender, EventArgs e)
		{
			try
			{
				string text = MsSendComboBox.Text;
				if (text.Length == 0)
					throw new Exception("Пустой запрос!");

				if (!SerialPort.IsOpen)
					switch (MessageBox.Show("Порт не открыт! Открыть его сейчас?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
					{ 
						case DialogResult.Yes:
							PortOpenMenuItem_Click(null, null);
							if (!SerialPort.IsOpen)
								return;
							break;
						default:
							return;
					}

				int ind = MsSendComboBox.Items.IndexOf(text);
				if (ind != -1)
					MsSendComboBox.Items.RemoveAt(ind);
				MsSendComboBox.Items.Insert(0, text);

				byte[] sd = Program.Settings.SendCoder.StringToData(text, Program.Settings.UserEncoding);

				if (Program.Settings.SelectedTemplate != null)
				{
					var psd = Program.Settings.SelectedTemplate.SendProcess(sd);
					if (psd != null)
					{
						WriteInfo("Шаблон '{0}'", Program.Settings.SelectedTemplate.Name);
						sd = psd;
					}
				}
				WriteSend(Program.Settings.SendCoder.DataToString(sd, Program.Settings.UserEncoding));

				SerialPort.Write(sd, 0, sd.Length);

				MsSendComboBox.Text = string.Empty;
			}
			catch (Exception ex)
			{
				WriteError(ex.Message);
			}
		}

		private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			lock (FReadDataLocker)
			{
				byte[] rb = new byte[SerialPort.BytesToRead];
				SerialPort.Read(rb, 0, rb.Length);
				FReadData.AddRange(rb);
			}
			FReadDataEvent.Set();
		}

		private void SerialPortReadDataLoop()
		{
			while (true)
			{
				if (FReadDataEvent.WaitOne(Program.Settings.UnionInterval))
					FReadDataEvent.Reset();
				else
					lock (FReadDataLocker)
					{
						if (FReadData.Count > 0)
						{
							try
							{
								string str = Program.Settings.ReceiveCoder.DataToString(FReadData.ToArray(), Program.Settings.UserEncoding);
								var lines = str.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
								if (lines.Length == 1)
									WriteReceive(str, true);
								else
								{
									WriteReceive(null, true);
									foreach (var l in lines)
										WriteReceive(l, false);
								}

								if (Program.Settings.SelectedTemplate != null)
								{
									var rc = Program.Settings.SelectedTemplate.ReceiveProcess(FReadData.ToArray());
									if (rc != null)
										foreach (var l in rc)
											WriteInfo(l);
									var outData = Program.Settings.SelectedTemplate.AutoAnswert(FReadData.ToArray());
									if (outData != null)
									{
										WriteInfo("Автоответ");
										SerialPort.Write(outData, 0, outData.Length);
										WriteSend(Program.Settings.ReceiveCoder.DataToString(outData, Program.Settings.UserEncoding));
									}
								}
							}
							catch (Exception ex)
							{
								WriteError("Ошибка декодировании: {0}", ex.Message);
							}
							FReadData.Clear();
						}
					}
			}
		}

		private void MsSendTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				MsSendButton_Click(null, null);
			if (e.KeyData == Keys.Down)
				MsSendComboBox.DroppedDown = true;
		}

		private void EncodingConfigureMenuItem_Click(object sender, EventArgs e)
		{
			using (EncodingsForm dlg = new EncodingsForm())
			{
				dlg.UserEncodings = Program.Settings.UserEncodings;
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					Program.Settings.UserEncodings = dlg.UserEncodings;
					EncodingMenuUpdate(true);
				}
			}
		}

		private void SerialPort_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
		{
			WriteInfo("Ошибка при чтении: " + e.EventType);
		}

		private void SerialPort_PinChanged(object sender, System.IO.Ports.SerialPinChangedEventArgs e)
		{
			WriteInfo("PinChanged: " + e.EventType);
		}

		private void LogContextMenuStrip_Opening(object sender, CancelEventArgs e)
		{
			LogCopyMenuItem.Enabled = LogTextBox.SelectionLength > 0;
		}

		private void LogCopyMenuItem_Click(object sender, EventArgs e)
		{
			LogTextBox.Copy();
		}

		private void FileExitMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void TemplatesMenuItem_Click(object sender, EventArgs e)
		{
			using (TemplatesForm dlg = new TemplatesForm())
			{
				dlg.Templates = Program.Settings.Templates;
				if (dlg.ShowDialog() == DialogResult.OK)
					Program.Settings.Templates = dlg.Templates;
			}
		}
	}
}
