using SerialRW.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialRW.Forms
{
	public partial class PortSettingsForm: Form
	{
		private const string SelectedValuePropertyName = "SelectedValue";
		private const string SelectedItemPropertyName = "SelectedItem";
		private const string DisplayMemberName = "Key";
		private const string ValueMemberName = "Value";

		public SerialRWSettings Settings { get; set; }

		public PortSettingsForm()
		{
			InitializeComponent();
		}

		private void PortSettingsForm_Load(object sender, EventArgs e)
		{
			Debug.Assert(Settings != null, "Settings == null");

			UnionIntervalTextBox.Text = Settings.UnionInterval.ToString();

			var pns = SerialPortSettings.PortNameEnum;
			NameComboBox.Items.AddRange(pns.Select(p => p.Name).ToArray());
			NameComboBox.SelectedIndex = NameComboBox.Items.IndexOf(Settings.SerialPort.PortNameValue);
			//NameComboBox.Items.AddRange(pns.ToArray());
			//for (int i = 0; i < pns.Length; i++)
			//	if (pns[i].Name == Settings.SerialPort.PortNameValue)
			//	{
			//		NameComboBox.SelectedIndex = i;
			//		break;
			//	}

			BaudrateComboBox.DataSource = SerialPortSettings.BaudrateEnum;
			BaudrateComboBox.DataBindings.Add(SelectedItemPropertyName, Settings.SerialPort, "BaudrateValue");

			DataBitsComboBox.DataSource = SerialPortSettings.DataBitsEnum;
			DataBitsComboBox.DataBindings.Add(SelectedItemPropertyName, Settings.SerialPort, "DataBitsValue");

			ParityComboBox.DataSource = SerialPortSettings.ParityEnum;
			ParityComboBox.DisplayMember = DisplayMemberName;
			ParityComboBox.ValueMember = ValueMemberName;
			ParityComboBox.DataBindings.Add(SelectedValuePropertyName, Settings.SerialPort, "ParityValue");

			StopBitsComboBox.DataSource = SerialPortSettings.StopBitsEnum;
			StopBitsComboBox.DisplayMember = DisplayMemberName;
			StopBitsComboBox.ValueMember = ValueMemberName;
			StopBitsComboBox.DataBindings.Add(SelectedValuePropertyName, Settings.SerialPort, "StopBitsValue");

			HandshakeComboBox.DataSource = SerialPortSettings.HandshakeEnum;
			HandshakeComboBox.DisplayMember = DisplayMemberName;
			HandshakeComboBox.ValueMember = ValueMemberName;
			HandshakeComboBox.DataBindings.Add(SelectedValuePropertyName, Settings.SerialPort, "HandshakeValue");

			DtrRtsComboBox.DataSource = SerialPortSettings.DtrRtsEnum;
			DtrRtsComboBox.DisplayMember = ValueMemberName;
			DtrRtsComboBox.ValueMember = DisplayMemberName;
			DtrRtsComboBox.DataBindings.Add(SelectedValuePropertyName, Settings.SerialPort, "DtrRtsValue");
		}

		private void UnionIntervalTextBox_Validated(object sender, EventArgs e)
		{
			int v = Settings.UnionInterval;
			if (int.TryParse(UnionIntervalTextBox.Text, out v))
			{
				if (v < 1)
					throw new Exception("Чило должно быть больше нуля!");
				Settings.UnionInterval = v;
				FormErrorProvider.SetError(UnionIntervalTextBox, null);
			}
			else
				FormErrorProvider.SetError(UnionIntervalTextBox, string.Format("'{0}' не является целым числом!", UnionIntervalTextBox.Text));
		}

		private void OkDialogButton_Click(object sender, EventArgs e)
		{
			try
			{
				string err = FormErrorProvider.GetError(UnionIntervalTextBox);
				if (!string.IsNullOrEmpty(err))
					throw new Exception(err);

				if (NameComboBox.SelectedIndex == -1)
					Settings.SerialPort.PortNameValue = string.Empty;
				else
					Settings.SerialPort.PortNameValue = (string)NameComboBox.Items[NameComboBox.SelectedIndex];

				DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				Program.ShowError(ex.Message);
			}
		}
	}
}
