namespace SerialRW.Forms
{
	partial class PortSettingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.FormLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.UnionIntervalLabel = new System.Windows.Forms.Label();
			this.UnionIntervalTextBox = new System.Windows.Forms.TextBox();
			this.HandshakeComboBox = new System.Windows.Forms.ComboBox();
			this.HandshakeLabel = new System.Windows.Forms.Label();
			this.StopBitsComboBox = new System.Windows.Forms.ComboBox();
			this.StopBitsLabel = new System.Windows.Forms.Label();
			this.ParityComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.DataBitsComboBox = new System.Windows.Forms.ComboBox();
			this.DataBitsLabel = new System.Windows.Forms.Label();
			this.BaudrateComboBox = new System.Windows.Forms.ComboBox();
			this.BaudrateLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.NameComboBox = new System.Windows.Forms.ComboBox();
			this.DtrRtsLabel = new System.Windows.Forms.Label();
			this.DtrRtsComboBox = new System.Windows.Forms.ComboBox();
			this.OkDialogButton = new System.Windows.Forms.Button();
			this.CancelDialogButton = new System.Windows.Forms.Button();
			this.FormErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.FormLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FormErrorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// FormLayoutPanel
			// 
			this.FormLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FormLayoutPanel.ColumnCount = 2;
			this.FormLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.08333F));
			this.FormLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.91667F));
			this.FormLayoutPanel.Controls.Add(this.UnionIntervalLabel, 0, 7);
			this.FormLayoutPanel.Controls.Add(this.UnionIntervalTextBox, 1, 7);
			this.FormLayoutPanel.Controls.Add(this.HandshakeComboBox, 1, 5);
			this.FormLayoutPanel.Controls.Add(this.HandshakeLabel, 0, 5);
			this.FormLayoutPanel.Controls.Add(this.StopBitsComboBox, 1, 4);
			this.FormLayoutPanel.Controls.Add(this.StopBitsLabel, 0, 4);
			this.FormLayoutPanel.Controls.Add(this.ParityComboBox, 1, 3);
			this.FormLayoutPanel.Controls.Add(this.label1, 0, 3);
			this.FormLayoutPanel.Controls.Add(this.DataBitsComboBox, 1, 2);
			this.FormLayoutPanel.Controls.Add(this.DataBitsLabel, 0, 2);
			this.FormLayoutPanel.Controls.Add(this.BaudrateComboBox, 1, 1);
			this.FormLayoutPanel.Controls.Add(this.BaudrateLabel, 0, 1);
			this.FormLayoutPanel.Controls.Add(this.NameLabel, 0, 0);
			this.FormLayoutPanel.Controls.Add(this.NameComboBox, 1, 0);
			this.FormLayoutPanel.Controls.Add(this.DtrRtsLabel, 0, 6);
			this.FormLayoutPanel.Controls.Add(this.DtrRtsComboBox, 1, 6);
			this.FormLayoutPanel.Location = new System.Drawing.Point(12, 12);
			this.FormLayoutPanel.Name = "FormLayoutPanel";
			this.FormLayoutPanel.RowCount = 8;
			this.FormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.FormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.FormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.FormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.FormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.FormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.FormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.FormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.FormLayoutPanel.Size = new System.Drawing.Size(288, 222);
			this.FormLayoutPanel.TabIndex = 0;
			// 
			// UnionIntervalLabel
			// 
			this.UnionIntervalLabel.AutoSize = true;
			this.UnionIntervalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UnionIntervalLabel.Location = new System.Drawing.Point(3, 189);
			this.UnionIntervalLabel.Name = "UnionIntervalLabel";
			this.UnionIntervalLabel.Size = new System.Drawing.Size(143, 33);
			this.UnionIntervalLabel.TabIndex = 14;
			this.UnionIntervalLabel.Text = "Интервал объединения входных данных, мсек";
			this.UnionIntervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// UnionIntervalTextBox
			// 
			this.UnionIntervalTextBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.FormErrorProvider.SetIconPadding(this.UnionIntervalTextBox, -18);
			this.UnionIntervalTextBox.Location = new System.Drawing.Point(152, 192);
			this.UnionIntervalTextBox.Name = "UnionIntervalTextBox";
			this.UnionIntervalTextBox.Size = new System.Drawing.Size(133, 20);
			this.UnionIntervalTextBox.TabIndex = 15;
			this.UnionIntervalTextBox.Validated += new System.EventHandler(this.UnionIntervalTextBox_Validated);
			// 
			// HandshakeComboBox
			// 
			this.HandshakeComboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.HandshakeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.HandshakeComboBox.FormattingEnabled = true;
			this.HandshakeComboBox.Location = new System.Drawing.Point(152, 138);
			this.HandshakeComboBox.Name = "HandshakeComboBox";
			this.HandshakeComboBox.Size = new System.Drawing.Size(133, 21);
			this.HandshakeComboBox.TabIndex = 11;
			// 
			// HandshakeLabel
			// 
			this.HandshakeLabel.AutoSize = true;
			this.HandshakeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HandshakeLabel.Location = new System.Drawing.Point(3, 135);
			this.HandshakeLabel.Name = "HandshakeLabel";
			this.HandshakeLabel.Size = new System.Drawing.Size(143, 27);
			this.HandshakeLabel.TabIndex = 10;
			this.HandshakeLabel.Text = "Управление потоком";
			this.HandshakeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// StopBitsComboBox
			// 
			this.StopBitsComboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.StopBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.StopBitsComboBox.FormattingEnabled = true;
			this.StopBitsComboBox.Location = new System.Drawing.Point(152, 111);
			this.StopBitsComboBox.Name = "StopBitsComboBox";
			this.StopBitsComboBox.Size = new System.Drawing.Size(133, 21);
			this.StopBitsComboBox.TabIndex = 9;
			// 
			// StopBitsLabel
			// 
			this.StopBitsLabel.AutoSize = true;
			this.StopBitsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StopBitsLabel.Location = new System.Drawing.Point(3, 108);
			this.StopBitsLabel.Name = "StopBitsLabel";
			this.StopBitsLabel.Size = new System.Drawing.Size(143, 27);
			this.StopBitsLabel.TabIndex = 8;
			this.StopBitsLabel.Text = "Стоповые биты";
			this.StopBitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ParityComboBox
			// 
			this.ParityComboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.ParityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ParityComboBox.FormattingEnabled = true;
			this.ParityComboBox.Location = new System.Drawing.Point(152, 84);
			this.ParityComboBox.Name = "ParityComboBox";
			this.ParityComboBox.Size = new System.Drawing.Size(133, 21);
			this.ParityComboBox.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 27);
			this.label1.TabIndex = 6;
			this.label1.Text = "Чётность";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// DataBitsComboBox
			// 
			this.DataBitsComboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.DataBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DataBitsComboBox.FormattingEnabled = true;
			this.DataBitsComboBox.Location = new System.Drawing.Point(152, 57);
			this.DataBitsComboBox.Name = "DataBitsComboBox";
			this.DataBitsComboBox.Size = new System.Drawing.Size(133, 21);
			this.DataBitsComboBox.TabIndex = 5;
			// 
			// DataBitsLabel
			// 
			this.DataBitsLabel.AutoSize = true;
			this.DataBitsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataBitsLabel.Location = new System.Drawing.Point(3, 54);
			this.DataBitsLabel.Name = "DataBitsLabel";
			this.DataBitsLabel.Size = new System.Drawing.Size(143, 27);
			this.DataBitsLabel.TabIndex = 4;
			this.DataBitsLabel.Text = "Биты данных";
			this.DataBitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// BaudrateComboBox
			// 
			this.BaudrateComboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.BaudrateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BaudrateComboBox.FormattingEnabled = true;
			this.BaudrateComboBox.Location = new System.Drawing.Point(152, 30);
			this.BaudrateComboBox.Name = "BaudrateComboBox";
			this.BaudrateComboBox.Size = new System.Drawing.Size(133, 21);
			this.BaudrateComboBox.TabIndex = 3;
			// 
			// BaudrateLabel
			// 
			this.BaudrateLabel.AutoSize = true;
			this.BaudrateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BaudrateLabel.Location = new System.Drawing.Point(3, 27);
			this.BaudrateLabel.Name = "BaudrateLabel";
			this.BaudrateLabel.Size = new System.Drawing.Size(143, 27);
			this.BaudrateLabel.TabIndex = 2;
			this.BaudrateLabel.Text = "Скорость";
			this.BaudrateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NameLabel.Location = new System.Drawing.Point(3, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(143, 27);
			this.NameLabel.TabIndex = 0;
			this.NameLabel.Text = "Имя";
			this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NameComboBox
			// 
			this.NameComboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.NameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.NameComboBox.FormattingEnabled = true;
			this.NameComboBox.Location = new System.Drawing.Point(152, 3);
			this.NameComboBox.Name = "NameComboBox";
			this.NameComboBox.Size = new System.Drawing.Size(133, 21);
			this.NameComboBox.TabIndex = 1;
			// 
			// DtrRtsLabel
			// 
			this.DtrRtsLabel.AutoSize = true;
			this.DtrRtsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DtrRtsLabel.Location = new System.Drawing.Point(3, 162);
			this.DtrRtsLabel.Name = "DtrRtsLabel";
			this.DtrRtsLabel.Size = new System.Drawing.Size(143, 27);
			this.DtrRtsLabel.TabIndex = 12;
			this.DtrRtsLabel.Text = "Ручная установка\r\nDTR и RTS";
			this.DtrRtsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// DtrRtsComboBox
			// 
			this.DtrRtsComboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.DtrRtsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DtrRtsComboBox.FormattingEnabled = true;
			this.DtrRtsComboBox.Location = new System.Drawing.Point(152, 165);
			this.DtrRtsComboBox.Name = "DtrRtsComboBox";
			this.DtrRtsComboBox.Size = new System.Drawing.Size(133, 21);
			this.DtrRtsComboBox.TabIndex = 13;
			// 
			// OkDialogButton
			// 
			this.OkDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OkDialogButton.Location = new System.Drawing.Point(144, 240);
			this.OkDialogButton.Name = "OkDialogButton";
			this.OkDialogButton.Size = new System.Drawing.Size(75, 23);
			this.OkDialogButton.TabIndex = 1;
			this.OkDialogButton.Text = "OK";
			this.OkDialogButton.UseVisualStyleBackColor = true;
			this.OkDialogButton.Click += new System.EventHandler(this.OkDialogButton_Click);
			// 
			// CancelDialogButton
			// 
			this.CancelDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelDialogButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelDialogButton.Location = new System.Drawing.Point(225, 240);
			this.CancelDialogButton.Name = "CancelDialogButton";
			this.CancelDialogButton.Size = new System.Drawing.Size(75, 23);
			this.CancelDialogButton.TabIndex = 2;
			this.CancelDialogButton.Text = "Отмена";
			this.CancelDialogButton.UseVisualStyleBackColor = true;
			// 
			// FormErrorProvider
			// 
			this.FormErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.FormErrorProvider.ContainerControl = this;
			// 
			// PortSettingsForm
			// 
			this.AcceptButton = this.OkDialogButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelDialogButton;
			this.ClientSize = new System.Drawing.Size(312, 275);
			this.Controls.Add(this.CancelDialogButton);
			this.Controls.Add(this.OkDialogButton);
			this.Controls.Add(this.FormLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PortSettingsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Параметры порта";
			this.Load += new System.EventHandler(this.PortSettingsForm_Load);
			this.FormLayoutPanel.ResumeLayout(false);
			this.FormLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.FormErrorProvider)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel FormLayoutPanel;
		private System.Windows.Forms.ComboBox BaudrateComboBox;
		private System.Windows.Forms.Label BaudrateLabel;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.ComboBox NameComboBox;
		private System.Windows.Forms.Button OkDialogButton;
		private System.Windows.Forms.Button CancelDialogButton;
		private System.Windows.Forms.ComboBox DataBitsComboBox;
		private System.Windows.Forms.Label DataBitsLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox ParityComboBox;
		private System.Windows.Forms.Label HandshakeLabel;
		private System.Windows.Forms.ComboBox StopBitsComboBox;
		private System.Windows.Forms.Label StopBitsLabel;
		private System.Windows.Forms.ComboBox HandshakeComboBox;
		private System.Windows.Forms.ErrorProvider FormErrorProvider;
		private System.Windows.Forms.Label UnionIntervalLabel;
		private System.Windows.Forms.TextBox UnionIntervalTextBox;
		private System.Windows.Forms.Label DtrRtsLabel;
		private System.Windows.Forms.ComboBox DtrRtsComboBox;
	}
}