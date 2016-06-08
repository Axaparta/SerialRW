using SerialRW.Templates;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SerialRW.Common;
using System.Linq;

namespace SerialRW.Forms
{
	public partial class TemplatesForm: Form
	{
		private bool FIsModify = false;

		public TemplatesForm()
		{
			InitializeComponent();
		}

		public BaseTemplate[] Templates
		{
			get
			{
				return TemplateComboBox.Items.OfType<BaseTemplate>().ToArray();
			}
			set
			{
				TemplateComboBox.Items.Clear();
				TemplateComboBox.Items.AddRange(value.Select(t => t.Clone()).ToArray());
			}
		}

		private void TemplatesForm_Load(object sender, EventArgs e)
		{
			WinAPI.SetTabWidth(SendTextBox, 1);
			WinAPI.SetTabWidth(ReceiveTextBox, 1);
			WinAPI.SetTabWidth(AutoAnswertTextBox, 1);

			SendFormatLabel.Text = string.Format("Входные данные ({0}):", Program.Settings.SendCoder.Name);
			ReceiveFormatLabel.Text = string.Format("Выходные данные ({0}):", Program.Settings.ReceiveCoder.Name);

			TemplateComboBox.SelectedIndex = Program.Settings.TemplateIndex;
			TemplateComboBox_SelectedIndexChanged(null, null);
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			if (TemplateComboBox.Items.Cast<BaseTemplate>().FirstOrDefault(t => t.Name == TemplateComboBox.Text) != null)
			{
				Program.ShowError("Шаблон с таким именем ужа существует!");
				return;
			}
			TemplateComboBox.Items.Add(new CSScriptTemplate() { Name = TemplateComboBox.Text });
			TemplateComboBox.SelectedIndex = TemplateComboBox.Items.Count - 1;
		}

		private void TemplateComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (TemplateComboBox.SelectedItem != null)
			{
				var t = (BaseTemplate)TemplateComboBox.SelectedItem;
				SendTextBox.Text = t.SendProcessScript;
				ReceiveTextBox.Text = t.ReceiveProcessScript;
				AutoAnswertTextBox.Text = t.AutoAnswertScript;
				FIsModify = false;
			}
			ButtonsEnabledUpdate();
		}

		private void TemplateComboBox_TextChanged(object sender, EventArgs e)
		{
			TemplateComboBox_SelectedIndexChanged(null, null);
		}

		private void OkDialogButton_Click(object sender, EventArgs e)
		{
			Program.Settings.TemplateIndex = TemplateComboBox.SelectedIndex;
			DialogResult = DialogResult.OK;
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (TemplateComboBox.SelectedIndex == -1)
				return;
			var si = TemplateComboBox.SelectedIndex;
			TemplateComboBox.Items.RemoveAt(si);
			if (si >= TemplateComboBox.Items.Count)
				si--;
			TemplateComboBox.Text = string.Empty;
			TemplateComboBox.SelectedIndex = si;
		}

		private void TestInputTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
				TestButton_Click(null, null);
		}

		private void TestButton_Click(object sender, EventArgs e)
		{
			SaveButton_Click(null, null);
			try
			{
				var rb = Program.Settings.SendCoder.StringToData(TestInputTextBox.Text, Program.Settings.UserEncoding);
				var t = (BaseTemplate)TemplateComboBox.SelectedItem;
				byte[] ba;
				switch (EditTabControl.SelectedIndex)
				{
					case 0:
						ba = t.SendProcess(rb);
						if (ba == null)
							TestOutputTextBox.Text = "Null";
						else
							TestOutputTextBox.Text = Program.Settings.ReceiveCoder.DataToString(ba, Program.Settings.UserEncoding);
						break;
					case 1:
						var rs = t.ReceiveProcess(rb);
						if (rs == null)
							TestOutputTextBox.Text = "Null";
						else
							TestOutputTextBox.Text = string.Join(", ", rs);
						break;
					case 2:
						ba = t.AutoAnswert(rb);
						if (ba == null)
							TestOutputTextBox.Text = "Null";
						else
							TestOutputTextBox.Text = Program.Settings.ReceiveCoder.DataToString(ba, Program.Settings.UserEncoding);
						break;
				}
				TestOutputTextBox.ForeColor = SystemColors.ControlText;
			}
			catch (Exception ex)
			{
				TestOutputTextBox.ForeColor = Color.Red;
				TestOutputTextBox.Text = ex.Message;
			}
		}

		private void TemplatesForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F9)
				TestButton_Click(null, null);
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (!SaveButton.Enabled)
				return;
			var t = (BaseTemplate)TemplateComboBox.SelectedItem;
			t.SendProcessScript = SendTextBox.Text;
			t.ReceiveProcessScript = ReceiveTextBox.Text;
			t.AutoAnswertScript = AutoAnswertTextBox.Text;
			FIsModify = false;
			ButtonsEnabledUpdate();
		}

		private void SendTextBox_TextChanged(object sender, EventArgs e)
		{
			FIsModify = true;
			ButtonsEnabledUpdate();
		}

		private void ButtonsEnabledUpdate()
		{
			var ori = (TemplateComboBox.SelectedItem != null) && (((BaseTemplate)TemplateComboBox.SelectedItem).Name == TemplateComboBox.Text);
			SaveButton.Enabled = FIsModify && ori;
			AddButton.Enabled = (TemplateComboBox.Text.Length > 0) && (TemplateComboBox.SelectedItem == null);
			DeleteButton.Enabled = ori;
			TestButton.Enabled = !AddButton.Enabled;
		}
	}
}
