namespace SerialRW.Forms
{
	partial class TemplatesForm
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
			this.OkDialogButton = new System.Windows.Forms.Button();
			this.CancelDialogButton = new System.Windows.Forms.Button();
			this.EditTabControl = new System.Windows.Forms.TabControl();
			this.SendTabPage = new System.Windows.Forms.TabPage();
			this.SendTextBox = new System.Windows.Forms.TextBox();
			this.ReceiveTabPage = new System.Windows.Forms.TabPage();
			this.ReceiveTextBox = new System.Windows.Forms.TextBox();
			this.AutoAnswertTabPage = new System.Windows.Forms.TabPage();
			this.AutoAnswertTextBox = new System.Windows.Forms.TextBox();
			this.AddButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.TestTabControl = new System.Windows.Forms.TabControl();
			this.TestTabPage = new System.Windows.Forms.TabPage();
			this.TestButton = new System.Windows.Forms.Button();
			this.TestOutputTextBox = new System.Windows.Forms.TextBox();
			this.ReceiveFormatLabel = new System.Windows.Forms.Label();
			this.TestInputTextBox = new System.Windows.Forms.TextBox();
			this.SendFormatLabel = new System.Windows.Forms.Label();
			this.TemplateComboBox = new System.Windows.Forms.ComboBox();
			this.SaveButton = new System.Windows.Forms.Button();
			this.EditTabControl.SuspendLayout();
			this.SendTabPage.SuspendLayout();
			this.ReceiveTabPage.SuspendLayout();
			this.AutoAnswertTabPage.SuspendLayout();
			this.TestTabControl.SuspendLayout();
			this.TestTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// OkDialogButton
			// 
			this.OkDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OkDialogButton.Location = new System.Drawing.Point(434, 458);
			this.OkDialogButton.Name = "OkDialogButton";
			this.OkDialogButton.Size = new System.Drawing.Size(75, 23);
			this.OkDialogButton.TabIndex = 6;
			this.OkDialogButton.Text = "OK";
			this.OkDialogButton.UseVisualStyleBackColor = true;
			this.OkDialogButton.Click += new System.EventHandler(this.OkDialogButton_Click);
			// 
			// CancelDialogButton
			// 
			this.CancelDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelDialogButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelDialogButton.Location = new System.Drawing.Point(515, 458);
			this.CancelDialogButton.Name = "CancelDialogButton";
			this.CancelDialogButton.Size = new System.Drawing.Size(75, 23);
			this.CancelDialogButton.TabIndex = 7;
			this.CancelDialogButton.Text = "Отмена";
			this.CancelDialogButton.UseVisualStyleBackColor = true;
			// 
			// EditTabControl
			// 
			this.EditTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EditTabControl.Controls.Add(this.SendTabPage);
			this.EditTabControl.Controls.Add(this.ReceiveTabPage);
			this.EditTabControl.Controls.Add(this.AutoAnswertTabPage);
			this.EditTabControl.Location = new System.Drawing.Point(12, 39);
			this.EditTabControl.Name = "EditTabControl";
			this.EditTabControl.SelectedIndex = 0;
			this.EditTabControl.Size = new System.Drawing.Size(585, 261);
			this.EditTabControl.TabIndex = 4;
			// 
			// SendTabPage
			// 
			this.SendTabPage.Controls.Add(this.SendTextBox);
			this.SendTabPage.Location = new System.Drawing.Point(4, 22);
			this.SendTabPage.Name = "SendTabPage";
			this.SendTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.SendTabPage.Size = new System.Drawing.Size(577, 235);
			this.SendTabPage.TabIndex = 0;
			this.SendTabPage.Text = "Отправка";
			this.SendTabPage.UseVisualStyleBackColor = true;
			// 
			// SendTextBox
			// 
			this.SendTextBox.AcceptsReturn = true;
			this.SendTextBox.AcceptsTab = true;
			this.SendTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SendTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SendTextBox.Location = new System.Drawing.Point(3, 3);
			this.SendTextBox.Multiline = true;
			this.SendTextBox.Name = "SendTextBox";
			this.SendTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.SendTextBox.Size = new System.Drawing.Size(571, 229);
			this.SendTextBox.TabIndex = 0;
			this.SendTextBox.TextChanged += new System.EventHandler(this.SendTextBox_TextChanged);
			// 
			// ReceiveTabPage
			// 
			this.ReceiveTabPage.Controls.Add(this.ReceiveTextBox);
			this.ReceiveTabPage.Location = new System.Drawing.Point(4, 22);
			this.ReceiveTabPage.Name = "ReceiveTabPage";
			this.ReceiveTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.ReceiveTabPage.Size = new System.Drawing.Size(577, 235);
			this.ReceiveTabPage.TabIndex = 1;
			this.ReceiveTabPage.Text = "Получение";
			this.ReceiveTabPage.UseVisualStyleBackColor = true;
			// 
			// ReceiveTextBox
			// 
			this.ReceiveTextBox.AcceptsReturn = true;
			this.ReceiveTextBox.AcceptsTab = true;
			this.ReceiveTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ReceiveTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ReceiveTextBox.Location = new System.Drawing.Point(3, 3);
			this.ReceiveTextBox.Multiline = true;
			this.ReceiveTextBox.Name = "ReceiveTextBox";
			this.ReceiveTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.ReceiveTextBox.Size = new System.Drawing.Size(571, 229);
			this.ReceiveTextBox.TabIndex = 1;
			this.ReceiveTextBox.TextChanged += new System.EventHandler(this.SendTextBox_TextChanged);
			// 
			// AutoAnswertTabPage
			// 
			this.AutoAnswertTabPage.Controls.Add(this.AutoAnswertTextBox);
			this.AutoAnswertTabPage.Location = new System.Drawing.Point(4, 22);
			this.AutoAnswertTabPage.Name = "AutoAnswertTabPage";
			this.AutoAnswertTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.AutoAnswertTabPage.Size = new System.Drawing.Size(577, 235);
			this.AutoAnswertTabPage.TabIndex = 2;
			this.AutoAnswertTabPage.Text = "Автоответчик";
			this.AutoAnswertTabPage.UseVisualStyleBackColor = true;
			// 
			// AutoAnswertTextBox
			// 
			this.AutoAnswertTextBox.AcceptsReturn = true;
			this.AutoAnswertTextBox.AcceptsTab = true;
			this.AutoAnswertTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AutoAnswertTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AutoAnswertTextBox.Location = new System.Drawing.Point(3, 3);
			this.AutoAnswertTextBox.Multiline = true;
			this.AutoAnswertTextBox.Name = "AutoAnswertTextBox";
			this.AutoAnswertTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.AutoAnswertTextBox.Size = new System.Drawing.Size(571, 229);
			this.AutoAnswertTextBox.TabIndex = 1;
			this.AutoAnswertTextBox.TextChanged += new System.EventHandler(this.SendTextBox_TextChanged);
			// 
			// AddButton
			// 
			this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddButton.Location = new System.Drawing.Point(431, 10);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(80, 23);
			this.AddButton.TabIndex = 2;
			this.AddButton.Text = "Добавить";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteButton.Location = new System.Drawing.Point(517, 10);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(80, 23);
			this.DeleteButton.TabIndex = 3;
			this.DeleteButton.Text = "Удалить";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// TestTabControl
			// 
			this.TestTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TestTabControl.Controls.Add(this.TestTabPage);
			this.TestTabControl.Location = new System.Drawing.Point(12, 306);
			this.TestTabControl.Name = "TestTabControl";
			this.TestTabControl.SelectedIndex = 0;
			this.TestTabControl.Size = new System.Drawing.Size(581, 146);
			this.TestTabControl.TabIndex = 5;
			// 
			// TestTabPage
			// 
			this.TestTabPage.Controls.Add(this.TestButton);
			this.TestTabPage.Controls.Add(this.TestOutputTextBox);
			this.TestTabPage.Controls.Add(this.ReceiveFormatLabel);
			this.TestTabPage.Controls.Add(this.TestInputTextBox);
			this.TestTabPage.Controls.Add(this.SendFormatLabel);
			this.TestTabPage.Location = new System.Drawing.Point(4, 22);
			this.TestTabPage.Name = "TestTabPage";
			this.TestTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.TestTabPage.Size = new System.Drawing.Size(573, 120);
			this.TestTabPage.TabIndex = 0;
			this.TestTabPage.Text = "Тестирование шаблона";
			this.TestTabPage.UseVisualStyleBackColor = true;
			// 
			// TestButton
			// 
			this.TestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TestButton.Location = new System.Drawing.Point(422, 91);
			this.TestButton.Name = "TestButton";
			this.TestButton.Size = new System.Drawing.Size(146, 23);
			this.TestButton.TabIndex = 4;
			this.TestButton.Text = "Тест (F9)";
			this.TestButton.UseVisualStyleBackColor = true;
			this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
			// 
			// TestOutputTextBox
			// 
			this.TestOutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TestOutputTextBox.Location = new System.Drawing.Point(6, 65);
			this.TestOutputTextBox.Name = "TestOutputTextBox";
			this.TestOutputTextBox.ReadOnly = true;
			this.TestOutputTextBox.Size = new System.Drawing.Size(561, 20);
			this.TestOutputTextBox.TabIndex = 3;
			// 
			// ReceiveFormatLabel
			// 
			this.ReceiveFormatLabel.AutoSize = true;
			this.ReceiveFormatLabel.Location = new System.Drawing.Point(6, 49);
			this.ReceiveFormatLabel.Name = "ReceiveFormatLabel";
			this.ReceiveFormatLabel.Size = new System.Drawing.Size(120, 13);
			this.ReceiveFormatLabel.TabIndex = 2;
			this.ReceiveFormatLabel.Text = "Выходное сообщение:";
			// 
			// TestInputTextBox
			// 
			this.TestInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TestInputTextBox.Location = new System.Drawing.Point(6, 24);
			this.TestInputTextBox.Name = "TestInputTextBox";
			this.TestInputTextBox.Size = new System.Drawing.Size(561, 20);
			this.TestInputTextBox.TabIndex = 1;
			this.TestInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TestInputTextBox_KeyDown);
			// 
			// SendFormatLabel
			// 
			this.SendFormatLabel.AutoSize = true;
			this.SendFormatLabel.Location = new System.Drawing.Point(6, 8);
			this.SendFormatLabel.Name = "SendFormatLabel";
			this.SendFormatLabel.Size = new System.Drawing.Size(287, 13);
			this.SendFormatLabel.TabIndex = 0;
			this.SendFormatLabel.Text = "Входное сообщение (в формате настроек программы):";
			// 
			// TemplateComboBox
			// 
			this.TemplateComboBox.FormattingEnabled = true;
			this.TemplateComboBox.Location = new System.Drawing.Point(12, 12);
			this.TemplateComboBox.Name = "TemplateComboBox";
			this.TemplateComboBox.Size = new System.Drawing.Size(326, 21);
			this.TemplateComboBox.TabIndex = 0;
			this.TemplateComboBox.SelectedIndexChanged += new System.EventHandler(this.TemplateComboBox_SelectedIndexChanged);
			this.TemplateComboBox.TextChanged += new System.EventHandler(this.TemplateComboBox_TextChanged);
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveButton.Location = new System.Drawing.Point(344, 10);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(81, 23);
			this.SaveButton.TabIndex = 1;
			this.SaveButton.Text = "Сохранить";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// TemplatesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelDialogButton;
			this.ClientSize = new System.Drawing.Size(602, 493);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.TemplateComboBox);
			this.Controls.Add(this.TestTabControl);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.EditTabControl);
			this.Controls.Add(this.CancelDialogButton);
			this.Controls.Add(this.OkDialogButton);
			this.KeyPreview = true;
			this.Name = "TemplatesForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Шаблоны";
			this.Load += new System.EventHandler(this.TemplatesForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TemplatesForm_KeyDown);
			this.EditTabControl.ResumeLayout(false);
			this.SendTabPage.ResumeLayout(false);
			this.SendTabPage.PerformLayout();
			this.ReceiveTabPage.ResumeLayout(false);
			this.ReceiveTabPage.PerformLayout();
			this.AutoAnswertTabPage.ResumeLayout(false);
			this.AutoAnswertTabPage.PerformLayout();
			this.TestTabControl.ResumeLayout(false);
			this.TestTabPage.ResumeLayout(false);
			this.TestTabPage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button OkDialogButton;
		private System.Windows.Forms.Button CancelDialogButton;
		private System.Windows.Forms.TabControl EditTabControl;
		private System.Windows.Forms.TabPage SendTabPage;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.TabControl TestTabControl;
		private System.Windows.Forms.TabPage TestTabPage;
		private System.Windows.Forms.Button TestButton;
		private System.Windows.Forms.TextBox TestOutputTextBox;
		private System.Windows.Forms.Label ReceiveFormatLabel;
		private System.Windows.Forms.TextBox TestInputTextBox;
		private System.Windows.Forms.Label SendFormatLabel;
		private System.Windows.Forms.TabPage ReceiveTabPage;
		private System.Windows.Forms.TabPage AutoAnswertTabPage;
		private System.Windows.Forms.ComboBox TemplateComboBox;
		private System.Windows.Forms.TextBox SendTextBox;
		private System.Windows.Forms.TextBox ReceiveTextBox;
		private System.Windows.Forms.TextBox AutoAnswertTextBox;
		private System.Windows.Forms.Button SaveButton;
	}
}