using System;
using System.Drawing;
using System.Windows.Forms;

namespace SerialRW.Settings
{
	public class FormPositionSettings: ICloneable
	{
		public Size? FormSize { get; set; }
		public Point? FormLocation { get; set; }
		public bool IsMaximized { get; set; }
		public int ScreenCount { get; set; }

		public FormPositionSettings()
		{
			FormSize = null;
			FormLocation = null;
			IsMaximized = false;
			ScreenCount = 0;
		}

		/// <summary>Создание настройки с формы</summary>
		public FormPositionSettings(Form AForm):
			this()
		{
			this.FromForm(AForm);
		}

		public void FromForm(Form AForm)
		{
			IsMaximized = AForm.WindowState == FormWindowState.Maximized;
			// Сохранять размеры только если нормальное окно
			if (AForm.WindowState == FormWindowState.Normal)
			{
				FormSize = AForm.Size;
				FormLocation = AForm.Location;
			}
			ScreenCount = Screen.AllScreens.Length;
		}

		/// <summary>Применение настройки к форме</summary>
		public void ToForm(Form AForm)
		{
			// Загружать размеры только если количество экранов не менялось
			if (ScreenCount == Screen.AllScreens.Length)
			{
				if (FormSize.HasValue)
					AForm.Size = FormSize.Value;
				if (FormLocation.HasValue)
					AForm.Location = FormLocation.Value;
			}
			if (IsMaximized)
				AForm.WindowState = FormWindowState.Maximized;
			else
				AForm.WindowState = FormWindowState.Normal;
		}

		public object Clone()
		{
			return MemberwiseClone();
		}
	}
}
