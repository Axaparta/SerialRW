using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SerialRW.Common
{
	public static class WinAPI
	{
		private const int EM_SETTABSTOPS = 0x00CB;

		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

		[DllImport("user32.dll", EntryPoint = "SendMessage")]
		private static extern int SendMessage2(IntPtr hwnd, int wMsg, int wParam, int[] lParam);

		public static void ScrollToEnd(RichTextBox ATextBox)
		{
			SendMessage(ATextBox.Handle, 0x0115, new IntPtr(7), IntPtr.Zero);
		}

		public static void SetTabWidth(TextBox ATextbox, int ATabWidth)
		{
			Graphics graphics = ATextbox.CreateGraphics();
			var characterWidth = (int)graphics.MeasureString("M", ATextbox.Font).Width;
			SendMessage2(ATextbox.Handle, EM_SETTABSTOPS, 1, new int[] { ATabWidth*characterWidth });
		}
	}
}
