using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialRW.Forms;
using SerialRW.Settings;

namespace SerialRW
{
	static class Program
	{
		public static SerialRWSettings Settings = null;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Settings = SerialRWSettings.CreateFromFile();
			Application.Run(new MainForm());
			Settings.SaveToFile();
		}

		internal static void ShowError(string AMessage)
		{
			MessageBox.Show(AMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
