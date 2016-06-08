using SerialRW.Common;
using SerialRW.Templates;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Xml.Serialization;
using SerialRW.DataCoders;
using System.Reflection;

namespace SerialRW.Settings
{
	public class SerialRWSettings: ICloneable
	{
		#region Static
		public static readonly string SettingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SerialRW");
		public static readonly string SettingsFileName = Path.Combine(SettingsPath, "Settings.xml");
		public static readonly DataCoder[] DataCoders = new DataCoder[]
		{
			new PlainTextCoder(),
			new CNotationCoder(),
			new HexCoder()
		};
		#endregion

		private Encoding FUserEncoding = null;
		private string FUserEncodingName = null;

		public SerialPortSettings SerialPort { get; set; }
		public FormPositionSettings MainForm { get; set; }
		public bool MessageVisible { get; set; }
		public bool MessageCleanAfterSend { get; set; }
		public ToolStripSettings PortPanel { get; set; }
		public ToolStripSettings MessagePanel { get; set; }
		public int UnionInterval { get; set; }
		public string[] UserEncodings { get; set; }
		public string UserEncodingName
		{
			get
			{
				return FUserEncodingName;
			}
			set
			{
				FUserEncodingName = value;
				FUserEncoding = null;
			}
		}
		public int SendCoderIndex { get; set; }

		public DataCoder SendCoder
		{
			get
			{
				return DataCoders[SendCoderIndex];
			}
		}

		public int ReceiveCoderIndex { get; set; }

		public DataCoder ReceiveCoder
		{
			get
			{
				return DataCoders[ReceiveCoderIndex];
			}
		}

		public XMLRestorator[] RTemplates
		{
			get
			{
				return Templates.Select(t => new XMLRestorator(t)).ToArray();
			}
			set
			{ 
				if (value == null)
					Templates = new BaseTemplate[0];
				Templates = value.Select(t => t.Restore<BaseTemplate>()).ToArray();
			}
		}

		[XmlIgnore]
		public BaseTemplate[] Templates { get; set; }

		public int TemplateIndex
		{
			get; set;
		}

		[XmlIgnore]
		public BaseTemplate SelectedTemplate
		{
			get
			{
				if ((TemplateIndex == -1) || (TemplateIndex >= Templates.Length))
					return null;
				return Templates[TemplateIndex];
			}
		}

		public SerialRWSettings()
		{
			SerialPort = new SerialPortSettings();
			MainForm = new FormPositionSettings();
			PortPanel = new ToolStripSettings();
			MessagePanel = new ToolStripSettings();
			UnionInterval = 5;
			MessageCleanAfterSend = true;
			UserEncodings = new string[] { Encoding.Default.WebName };
			UserEncodingName = UserEncodings[0];
			SendCoderIndex = 1;
			ReceiveCoderIndex = 1;
			Templates = new BaseTemplate[0];
			TemplateIndex = -1;
		}

		public Encoding UserEncoding
		{
			get
			{
				if (FUserEncoding == null)
				{
					int encind = Array.FindIndex<string>(UserEncodings, s => s == UserEncodingName);
					if (encind == -1)
						return Encoding.Default;
					return Encoding.GetEncoding(UserEncodings[encind]);
				}
				return FUserEncoding;
			}
		}

		public static SerialRWSettings CreateFromFile(string AFileName = null)
		{
			if (string.IsNullOrEmpty(AFileName))
				AFileName = SettingsFileName;
			SerialRWSettings r = new SerialRWSettings();
			try
			{
				if (File.Exists(AFileName))
				{
					using (FileStream fs = new FileStream(AFileName, FileMode.Open, FileAccess.Read))
					{
						XmlSerializer s = new XmlSerializer(r.GetType());
						r = (SerialRWSettings)s.Deserialize(fs);
					}
				}
			}
			catch (Exception ex)
			{
				Program.ShowError("Ошибка при загрузке настроек: " + ex.Message);
			}
			return r;
		}

		public void SaveToFile(string AFileName = null)
		{
			if (string.IsNullOrEmpty(AFileName))
				AFileName = SettingsFileName;
			try
			{
				Directory.CreateDirectory(SettingsPath);
				using (FileStream fs = new FileStream(AFileName, FileMode.Create, FileAccess.Write))
				{
					new XmlSerializer(GetType()).Serialize(fs, this);
				}
			}
			catch (Exception ex)
			{
				Program.ShowError("Ошибка при сохранении настроек: " + ex.Message);
			}
		}

		public object Clone()
		{
			SerialRWSettings r = (SerialRWSettings)MemberwiseClone();
			r.SerialPort = (SerialPortSettings)SerialPort.Clone();
			return r;
		}
	}
}
