using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialRW.Forms
{
	public partial class EncodingsForm: Form
	{
		private struct ListBoxItem
		{
			public EncodingInfo Info;
			public Encoding Enc;

			public ListBoxItem(EncodingInfo AInfo)
			{
				this.Info = AInfo;
				Enc = AInfo.GetEncoding();
			}

			public override string ToString()
			{
				return string.Format("{0} [{1}]", Info.DisplayName, Enc.WebName);
			}
		}

		public string[] UserEncodings { get; set; }

		public EncodingsForm()
		{
			InitializeComponent();

			EncodingsListBox.SuspendLayout();
			var r = from ei in Encoding.GetEncodings() where ei.GetEncoding().IsSingleByte orderby ei.DisplayName select new ListBoxItem(ei);
			foreach (var v in r)
				EncodingsListBox.Items.Add(v);

			EncodingsListBox.ResumeLayout();
		}

		private void EncodingsForm_Load(object sender, EventArgs e)
		{
			Debug.Assert(UserEncodings != null);
			for (int i = 0; i < EncodingsListBox.Items.Count; i++)
			{
				ListBoxItem ci = (ListBoxItem)EncodingsListBox.Items[i];
				EncodingsListBox.SetItemChecked(i, UserEncodings.Contains(ci.Enc.WebName));
			}
		}

		private void OkDialogButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (EncodingsListBox.CheckedItems.Count == 0)
					throw new Exception("Необходимо выделить хотя бы одну кодировку!");

				UserEncodings = EncodingsListBox.CheckedItems.Cast<ListBoxItem>().Select(i => i.Enc.WebName).ToArray();
				DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				Program.ShowError(ex.Message);
			}
		}
	}
}
