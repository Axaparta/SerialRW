namespace SerialRW.Forms
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.TopMenuStrip = new System.Windows.Forms.MenuStrip();
			this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FileExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PortMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PortOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.PortNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PortBaudrateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PortSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PortRefreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PortVisibleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.LogCleanMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FormatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SendDataCoderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ReceiveDataCoderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EncodingFormatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.EncodingConfigureMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TemplatesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MainToolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.StatusBarStrip = new System.Windows.Forms.StatusStrip();
			this.SendStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.ReceiveStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.EncodingStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.LogTextBox = new System.Windows.Forms.RichTextBox();
			this.LogContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.LogCopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SendLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.SendButton = new System.Windows.Forms.Button();
			this.MsSendComboBox = new System.Windows.Forms.ComboBox();
			this.PortToolStrip = new System.Windows.Forms.ToolStrip();
			this.PortNameComboBox = new System.Windows.Forms.ToolStripComboBox();
			this.PortRefreshButton = new System.Windows.Forms.ToolStripButton();
			this.PortBaudrateComboBox = new System.Windows.Forms.ToolStripComboBox();
			this.PortSettingsButton = new System.Windows.Forms.ToolStripButton();
			this.PortOpenButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.CleanButton = new System.Windows.Forms.ToolStripButton();
			this.SerialPort = new System.IO.Ports.SerialPort(this.components);
			this.TopMenuStrip.SuspendLayout();
			this.MainToolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.MainToolStripContainer.ContentPanel.SuspendLayout();
			this.MainToolStripContainer.TopToolStripPanel.SuspendLayout();
			this.MainToolStripContainer.SuspendLayout();
			this.StatusBarStrip.SuspendLayout();
			this.LogContextMenuStrip.SuspendLayout();
			this.SendLayoutPanel.SuspendLayout();
			this.PortToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// TopMenuStrip
			// 
			this.TopMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.PortMenuItem,
            this.ViewMenuItem,
            this.FormatMenuItem});
			this.TopMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.TopMenuStrip.Name = "TopMenuStrip";
			this.TopMenuStrip.Size = new System.Drawing.Size(604, 24);
			this.TopMenuStrip.TabIndex = 0;
			this.TopMenuStrip.Text = "menuStrip1";
			// 
			// FileMenuItem
			// 
			this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileExitMenuItem});
			this.FileMenuItem.Name = "FileMenuItem";
			this.FileMenuItem.Size = new System.Drawing.Size(48, 20);
			this.FileMenuItem.Text = "Файл";
			// 
			// FileExitMenuItem
			// 
			this.FileExitMenuItem.Image = global::SerialRW.Properties.Resources.door_in;
			this.FileExitMenuItem.Name = "FileExitMenuItem";
			this.FileExitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
			this.FileExitMenuItem.Size = new System.Drawing.Size(145, 22);
			this.FileExitMenuItem.Text = "Выход";
			this.FileExitMenuItem.Click += new System.EventHandler(this.FileExitMenuItem_Click);
			// 
			// PortMenuItem
			// 
			this.PortMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PortOpenMenuItem,
            this.toolStripSeparator1,
            this.PortNameMenuItem,
            this.PortBaudrateMenuItem,
            this.PortSettingsMenuItem,
            this.PortRefreshMenuItem});
			this.PortMenuItem.Name = "PortMenuItem";
			this.PortMenuItem.Size = new System.Drawing.Size(47, 20);
			this.PortMenuItem.Text = "Порт";
			// 
			// PortOpenMenuItem
			// 
			this.PortOpenMenuItem.Name = "PortOpenMenuItem";
			this.PortOpenMenuItem.Size = new System.Drawing.Size(171, 22);
			this.PortOpenMenuItem.Text = "Открыть";
			this.PortOpenMenuItem.Click += new System.EventHandler(this.PortOpenMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
			// 
			// PortNameMenuItem
			// 
			this.PortNameMenuItem.Name = "PortNameMenuItem";
			this.PortNameMenuItem.Size = new System.Drawing.Size(171, 22);
			this.PortNameMenuItem.Text = "Имя";
			// 
			// PortBaudrateMenuItem
			// 
			this.PortBaudrateMenuItem.Name = "PortBaudrateMenuItem";
			this.PortBaudrateMenuItem.Size = new System.Drawing.Size(171, 22);
			this.PortBaudrateMenuItem.Text = "Скорость";
			// 
			// PortSettingsMenuItem
			// 
			this.PortSettingsMenuItem.Image = global::SerialRW.Properties.Resources.PropertiesHS;
			this.PortSettingsMenuItem.Name = "PortSettingsMenuItem";
			this.PortSettingsMenuItem.Size = new System.Drawing.Size(171, 22);
			this.PortSettingsMenuItem.Text = "Дополнительно...";
			this.PortSettingsMenuItem.Click += new System.EventHandler(this.PortSettingsMenuItem_Click);
			// 
			// PortRefreshMenuItem
			// 
			this.PortRefreshMenuItem.Image = global::SerialRW.Properties.Resources.RepeatHS;
			this.PortRefreshMenuItem.Name = "PortRefreshMenuItem";
			this.PortRefreshMenuItem.Size = new System.Drawing.Size(171, 22);
			this.PortRefreshMenuItem.Text = "Обновить имена";
			this.PortRefreshMenuItem.Click += new System.EventHandler(this.PortRefreshMenuItem_Click);
			// 
			// ViewMenuItem
			// 
			this.ViewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PortVisibleMenuItem,
            this.toolStripSeparator3,
            this.LogCleanMenuItem});
			this.ViewMenuItem.Name = "ViewMenuItem";
			this.ViewMenuItem.Size = new System.Drawing.Size(39, 20);
			this.ViewMenuItem.Text = "Вид";
			// 
			// PortVisibleMenuItem
			// 
			this.PortVisibleMenuItem.Name = "PortVisibleMenuItem";
			this.PortVisibleMenuItem.Size = new System.Drawing.Size(227, 22);
			this.PortVisibleMenuItem.Text = "Панель \"Параметры порта\"";
			this.PortVisibleMenuItem.Click += new System.EventHandler(this.PortVisibleMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(224, 6);
			// 
			// LogCleanMenuItem
			// 
			this.LogCleanMenuItem.Image = global::SerialRW.Properties.Resources.Actions_edit_clear_icon;
			this.LogCleanMenuItem.Name = "LogCleanMenuItem";
			this.LogCleanMenuItem.Size = new System.Drawing.Size(227, 22);
			this.LogCleanMenuItem.Text = "Очистить логи";
			this.LogCleanMenuItem.Click += new System.EventHandler(this.LogCleanMenuItem_Click);
			// 
			// FormatMenuItem
			// 
			this.FormatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SendDataCoderMenuItem,
            this.ReceiveDataCoderMenuItem,
            this.EncodingFormatMenuItem,
            this.TemplatesMenuItem});
			this.FormatMenuItem.Name = "FormatMenuItem";
			this.FormatMenuItem.Size = new System.Drawing.Size(62, 20);
			this.FormatMenuItem.Text = "Формат";
			// 
			// SendDataCoderMenuItem
			// 
			this.SendDataCoderMenuItem.Name = "SendDataCoderMenuItem";
			this.SendDataCoderMenuItem.Size = new System.Drawing.Size(136, 22);
			this.SendDataCoderMenuItem.Text = "Отправка";
			// 
			// ReceiveDataCoderMenuItem
			// 
			this.ReceiveDataCoderMenuItem.Name = "ReceiveDataCoderMenuItem";
			this.ReceiveDataCoderMenuItem.Size = new System.Drawing.Size(136, 22);
			this.ReceiveDataCoderMenuItem.Text = "Получение";
			// 
			// EncodingFormatMenuItem
			// 
			this.EncodingFormatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.EncodingConfigureMenuItem});
			this.EncodingFormatMenuItem.Name = "EncodingFormatMenuItem";
			this.EncodingFormatMenuItem.Size = new System.Drawing.Size(136, 22);
			this.EncodingFormatMenuItem.Text = "Кодировка";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(203, 6);
			// 
			// EncodingConfigureMenuItem
			// 
			this.EncodingConfigureMenuItem.Name = "EncodingConfigureMenuItem";
			this.EncodingConfigureMenuItem.Size = new System.Drawing.Size(206, 22);
			this.EncodingConfigureMenuItem.Text = "Доступные кодировки...";
			this.EncodingConfigureMenuItem.Click += new System.EventHandler(this.EncodingConfigureMenuItem_Click);
			// 
			// TemplatesMenuItem
			// 
			this.TemplatesMenuItem.Name = "TemplatesMenuItem";
			this.TemplatesMenuItem.Size = new System.Drawing.Size(136, 22);
			this.TemplatesMenuItem.Text = "Шаблоны";
			this.TemplatesMenuItem.Click += new System.EventHandler(this.TemplatesMenuItem_Click);
			// 
			// MainToolStripContainer
			// 
			// 
			// MainToolStripContainer.BottomToolStripPanel
			// 
			this.MainToolStripContainer.BottomToolStripPanel.Controls.Add(this.StatusBarStrip);
			// 
			// MainToolStripContainer.ContentPanel
			// 
			this.MainToolStripContainer.ContentPanel.Controls.Add(this.LogTextBox);
			this.MainToolStripContainer.ContentPanel.Controls.Add(this.SendLayoutPanel);
			this.MainToolStripContainer.ContentPanel.Size = new System.Drawing.Size(604, 383);
			this.MainToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainToolStripContainer.Location = new System.Drawing.Point(0, 24);
			this.MainToolStripContainer.Name = "MainToolStripContainer";
			this.MainToolStripContainer.Size = new System.Drawing.Size(604, 432);
			this.MainToolStripContainer.TabIndex = 1;
			// 
			// MainToolStripContainer.TopToolStripPanel
			// 
			this.MainToolStripContainer.TopToolStripPanel.Controls.Add(this.PortToolStrip);
			// 
			// StatusBarStrip
			// 
			this.StatusBarStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.StatusBarStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SendStatusLabel,
            this.ReceiveStatusLabel,
            this.EncodingStatusLabel});
			this.StatusBarStrip.Location = new System.Drawing.Point(0, 0);
			this.StatusBarStrip.Name = "StatusBarStrip";
			this.StatusBarStrip.Size = new System.Drawing.Size(604, 24);
			this.StatusBarStrip.TabIndex = 0;
			// 
			// SendStatusLabel
			// 
			this.SendStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.SendStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.SendStatusLabel.Name = "SendStatusLabel";
			this.SendStatusLabel.Size = new System.Drawing.Size(43, 19);
			this.SendStatusLabel.Text = "Send: ";
			// 
			// ReceiveStatusLabel
			// 
			this.ReceiveStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.ReceiveStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.ReceiveStatusLabel.Name = "ReceiveStatusLabel";
			this.ReceiveStatusLabel.Size = new System.Drawing.Size(54, 19);
			this.ReceiveStatusLabel.Text = "Receive:";
			// 
			// EncodingStatusLabel
			// 
			this.EncodingStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.EncodingStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.EncodingStatusLabel.Name = "EncodingStatusLabel";
			this.EncodingStatusLabel.Size = new System.Drawing.Size(61, 19);
			this.EncodingStatusLabel.Text = "Encoding";
			// 
			// LogTextBox
			// 
			this.LogTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LogTextBox.ContextMenuStrip = this.LogContextMenuStrip;
			this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LogTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LogTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.LogTextBox.Location = new System.Drawing.Point(0, 29);
			this.LogTextBox.Name = "LogTextBox";
			this.LogTextBox.ReadOnly = true;
			this.LogTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.LogTextBox.Size = new System.Drawing.Size(604, 354);
			this.LogTextBox.TabIndex = 0;
			this.LogTextBox.TabStop = false;
			this.LogTextBox.Text = "";
			// 
			// LogContextMenuStrip
			// 
			this.LogContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogCopyMenuItem});
			this.LogContextMenuStrip.Name = "LogContextMenuStrip";
			this.LogContextMenuStrip.Size = new System.Drawing.Size(140, 26);
			this.LogContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.LogContextMenuStrip_Opening);
			// 
			// LogCopyMenuItem
			// 
			this.LogCopyMenuItem.Image = global::SerialRW.Properties.Resources.CopyHS;
			this.LogCopyMenuItem.Name = "LogCopyMenuItem";
			this.LogCopyMenuItem.Size = new System.Drawing.Size(139, 22);
			this.LogCopyMenuItem.Text = "Копировать";
			this.LogCopyMenuItem.Click += new System.EventHandler(this.LogCopyMenuItem_Click);
			// 
			// SendLayoutPanel
			// 
			this.SendLayoutPanel.AutoSize = true;
			this.SendLayoutPanel.ColumnCount = 2;
			this.SendLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.SendLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.SendLayoutPanel.Controls.Add(this.SendButton, 1, 0);
			this.SendLayoutPanel.Controls.Add(this.MsSendComboBox, 0, 0);
			this.SendLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.SendLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.SendLayoutPanel.Name = "SendLayoutPanel";
			this.SendLayoutPanel.RowCount = 1;
			this.SendLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.SendLayoutPanel.Size = new System.Drawing.Size(604, 29);
			this.SendLayoutPanel.TabIndex = 2;
			// 
			// SendButton
			// 
			this.SendButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SendButton.Image = global::SerialRW.Properties.Resources.GoToNextHS;
			this.SendButton.Location = new System.Drawing.Point(567, 3);
			this.SendButton.Name = "SendButton";
			this.SendButton.Size = new System.Drawing.Size(34, 23);
			this.SendButton.TabIndex = 1;
			this.SendButton.UseVisualStyleBackColor = true;
			this.SendButton.Click += new System.EventHandler(this.MsSendButton_Click);
			// 
			// MsSendComboBox
			// 
			this.MsSendComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.MsSendComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.MsSendComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MsSendComboBox.FormattingEnabled = true;
			this.MsSendComboBox.Location = new System.Drawing.Point(5, 5);
			this.MsSendComboBox.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
			this.MsSendComboBox.Name = "MsSendComboBox";
			this.MsSendComboBox.Size = new System.Drawing.Size(556, 21);
			this.MsSendComboBox.TabIndex = 0;
			this.MsSendComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MsSendTextBox_KeyDown);
			// 
			// PortToolStrip
			// 
			this.PortToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.PortToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PortNameComboBox,
            this.PortRefreshButton,
            this.PortBaudrateComboBox,
            this.PortSettingsButton,
            this.PortOpenButton,
            this.toolStripSeparator2,
            this.CleanButton});
			this.PortToolStrip.Location = new System.Drawing.Point(3, 0);
			this.PortToolStrip.Name = "PortToolStrip";
			this.PortToolStrip.Size = new System.Drawing.Size(299, 25);
			this.PortToolStrip.TabIndex = 0;
			// 
			// PortNameComboBox
			// 
			this.PortNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PortNameComboBox.Name = "PortNameComboBox";
			this.PortNameComboBox.Size = new System.Drawing.Size(75, 25);
			this.PortNameComboBox.ToolTipText = "Название порта";
			this.PortNameComboBox.SelectedIndexChanged += new System.EventHandler(this.PortNameMenuItem_Click);
			// 
			// PortRefreshButton
			// 
			this.PortRefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.PortRefreshButton.Image = global::SerialRW.Properties.Resources.RepeatHS;
			this.PortRefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.PortRefreshButton.Name = "PortRefreshButton";
			this.PortRefreshButton.Size = new System.Drawing.Size(23, 22);
			this.PortRefreshButton.Text = "Обновить имена портов";
			this.PortRefreshButton.Click += new System.EventHandler(this.PortRefreshMenuItem_Click);
			// 
			// PortBaudrateComboBox
			// 
			this.PortBaudrateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PortBaudrateComboBox.Name = "PortBaudrateComboBox";
			this.PortBaudrateComboBox.Size = new System.Drawing.Size(75, 25);
			this.PortBaudrateComboBox.SelectedIndexChanged += new System.EventHandler(this.PortBaudrateMenuItem_Click);
			// 
			// PortSettingsButton
			// 
			this.PortSettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.PortSettingsButton.Image = global::SerialRW.Properties.Resources.PropertiesHS;
			this.PortSettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.PortSettingsButton.Name = "PortSettingsButton";
			this.PortSettingsButton.Size = new System.Drawing.Size(23, 22);
			this.PortSettingsButton.Text = "Дополнительные настройки";
			this.PortSettingsButton.Click += new System.EventHandler(this.PortSettingsMenuItem_Click);
			// 
			// PortOpenButton
			// 
			this.PortOpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.PortOpenButton.Image = ((System.Drawing.Image)(resources.GetObject("PortOpenButton.Image")));
			this.PortOpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.PortOpenButton.Name = "PortOpenButton";
			this.PortOpenButton.Size = new System.Drawing.Size(58, 22);
			this.PortOpenButton.Text = "Отркыть";
			this.PortOpenButton.Click += new System.EventHandler(this.PortOpenMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// CleanButton
			// 
			this.CleanButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.CleanButton.Image = global::SerialRW.Properties.Resources.Actions_edit_clear_icon;
			this.CleanButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CleanButton.Name = "CleanButton";
			this.CleanButton.Size = new System.Drawing.Size(23, 22);
			this.CleanButton.Text = "Очистить логи";
			this.CleanButton.Click += new System.EventHandler(this.LogCleanMenuItem_Click);
			// 
			// SerialPort
			// 
			this.SerialPort.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.SerialPort_ErrorReceived);
			this.SerialPort.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.SerialPort_PinChanged);
			this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 456);
			this.Controls.Add(this.MainToolStripContainer);
			this.Controls.Add(this.TopMenuStrip);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SerialRW";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.TopMenuStrip.ResumeLayout(false);
			this.TopMenuStrip.PerformLayout();
			this.MainToolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.MainToolStripContainer.BottomToolStripPanel.PerformLayout();
			this.MainToolStripContainer.ContentPanel.ResumeLayout(false);
			this.MainToolStripContainer.ContentPanel.PerformLayout();
			this.MainToolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.MainToolStripContainer.TopToolStripPanel.PerformLayout();
			this.MainToolStripContainer.ResumeLayout(false);
			this.MainToolStripContainer.PerformLayout();
			this.StatusBarStrip.ResumeLayout(false);
			this.StatusBarStrip.PerformLayout();
			this.LogContextMenuStrip.ResumeLayout(false);
			this.SendLayoutPanel.ResumeLayout(false);
			this.PortToolStrip.ResumeLayout(false);
			this.PortToolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip TopMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
		private System.Windows.Forms.ToolStripContainer MainToolStripContainer;
		private System.Windows.Forms.RichTextBox LogTextBox;
		private System.Windows.Forms.ToolStripMenuItem PortMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ViewMenuItem;
		private System.Windows.Forms.ToolStrip PortToolStrip;
		private System.Windows.Forms.ToolStripComboBox PortNameComboBox;
		private System.Windows.Forms.ToolStripMenuItem PortOpenMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PortNameMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PortBaudrateMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PortSettingsMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem PortRefreshMenuItem;
		private System.Windows.Forms.ToolStripComboBox PortBaudrateComboBox;
		private System.Windows.Forms.ToolStripButton PortSettingsButton;
		private System.Windows.Forms.ToolStripButton PortRefreshButton;
		private System.Windows.Forms.ToolStripButton PortOpenButton;
		private System.Windows.Forms.ToolStripMenuItem FileExitMenuItem;
		private System.IO.Ports.SerialPort SerialPort;
		private System.Windows.Forms.ContextMenuStrip LogContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem PortVisibleMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem LogCleanMenuItem;
		private System.Windows.Forms.ToolStripMenuItem FormatMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SendDataCoderMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ReceiveDataCoderMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EncodingFormatMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem EncodingConfigureMenuItem;
		private System.Windows.Forms.ToolStripMenuItem LogCopyMenuItem;
		private System.Windows.Forms.StatusStrip StatusBarStrip;
		private System.Windows.Forms.ToolStripStatusLabel SendStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel ReceiveStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel EncodingStatusLabel;
		private System.Windows.Forms.TableLayoutPanel SendLayoutPanel;
		private System.Windows.Forms.Button SendButton;
		private System.Windows.Forms.ComboBox MsSendComboBox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton CleanButton;
		private System.Windows.Forms.ToolStripMenuItem TemplatesMenuItem;

	}
}

