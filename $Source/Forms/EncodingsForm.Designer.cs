namespace SerialRW.Forms
{
	partial class EncodingsForm
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
			this.EncodingsListBox = new System.Windows.Forms.CheckedListBox();
			this.OkDialogButton = new System.Windows.Forms.Button();
			this.CancelDialogButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// EncodingsListBox
			// 
			this.EncodingsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EncodingsListBox.FormattingEnabled = true;
			this.EncodingsListBox.Location = new System.Drawing.Point(12, 12);
			this.EncodingsListBox.Name = "EncodingsListBox";
			this.EncodingsListBox.Size = new System.Drawing.Size(293, 379);
			this.EncodingsListBox.TabIndex = 0;
			// 
			// OkDialogButton
			// 
			this.OkDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OkDialogButton.Location = new System.Drawing.Point(149, 402);
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
			this.CancelDialogButton.Location = new System.Drawing.Point(230, 402);
			this.CancelDialogButton.Name = "CancelDialogButton";
			this.CancelDialogButton.Size = new System.Drawing.Size(75, 23);
			this.CancelDialogButton.TabIndex = 2;
			this.CancelDialogButton.Text = "Отмена";
			this.CancelDialogButton.UseVisualStyleBackColor = true;
			// 
			// EncodingsForm
			// 
			this.AcceptButton = this.OkDialogButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelDialogButton;
			this.ClientSize = new System.Drawing.Size(317, 437);
			this.Controls.Add(this.CancelDialogButton);
			this.Controls.Add(this.OkDialogButton);
			this.Controls.Add(this.EncodingsListBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EncodingsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Доступные кодировки";
			this.Load += new System.EventHandler(this.EncodingsForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckedListBox EncodingsListBox;
		private System.Windows.Forms.Button OkDialogButton;
		private System.Windows.Forms.Button CancelDialogButton;
	}
}