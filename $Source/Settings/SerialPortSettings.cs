using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Management;

namespace SerialRW.Settings
{
	public interface IValueConverter
	{
		object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture);
		object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture);
	}

	public class SerialPortName
	{
		public string Name { get; private set; }
		public string Description { get; private set; }

		public SerialPortName(string AName, string ADescription)
		{
			Name = AName;
			Description = ADescription;
		}

		public override string ToString()
		{
			if (string.IsNullOrEmpty(Description))
				return Name;
			return string.Format("{0} ({1})", Name, Description);
		}
	}

	#region ParityConverter
	public class ParityConverter: IValueConverter
	{
		public static string ParityToString(Parity AValue)
		{
			switch (AValue)
			{
				case Parity.Even:
					return "Чёт";
				case Parity.Odd:
					return "Нечёт";
				case Parity.Mark:
					return "Маркер";
				case Parity.Space:
					return "Пробел";
				case Parity.None:
					return "Нет";
				default:
					return AValue.ToString();
			}
		}

		public static Parity StringToParity(string AValue)
		{
			return ParityEnum.Single(p => ParityToString(p) == AValue);
		}

		public static readonly Parity[] ParityEnum = Enum.GetValues(typeof(Parity)).Cast<Parity>().ToArray();

		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if ((value is IEnumerable<Parity>) && (targetType == typeof(System.Collections.IEnumerable)))
				return (value as IEnumerable<Parity>).Select(v => ParityToString(v));
			if ((value is Parity) && (targetType == typeof(object)))
				return ParityToString((Parity)value);
			throw new ArgumentException(string.Format("Неверные типы аргументов >> value: {0}, targetType: {1}", value.GetType(), targetType));
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (targetType == typeof(Parity))
				return StringToParity(value.ToString());
			throw new ArgumentException(string.Format("Неверные типы аргументов >> value: {0}, targetType: {1}", value.GetType(), targetType));
		}
	}
	#endregion

	#region StopBitsConverter
	public class StopBitsConverter: IValueConverter
	{
		public static readonly StopBits[] StopBitsEnum = Enum.GetValues(typeof(StopBits)).Cast<StopBits>().Skip(1).ToArray();

		public static string StopBitsToString(StopBits AValue)
		{
			switch (AValue)
			{
				case StopBits.None:
					return "Нет";
				case StopBits.One:
					return "1";
				case StopBits.OnePointFive:
					return "1.5";
				case StopBits.Two:
					return "2";
				default:
					return AValue.ToString();
			}
		}

		public static StopBits StringToStopBits(string AValue)
		{
			return StopBitsEnum.Single(p => StopBitsToString(p) == AValue);
		}

		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if ((value is IEnumerable<StopBits>) && (targetType == typeof(System.Collections.IEnumerable)))
				return (value as IEnumerable<StopBits>).Select(v => StopBitsToString(v));
			if ((value is StopBits) && (targetType == typeof(object)))
				return StopBitsToString((StopBits)value);
			throw new ArgumentException(string.Format("Неверные типы аргументов >> value: {0}, targetType: {1}", value.GetType(), targetType));
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (targetType == typeof(StopBits))
				return StringToStopBits(value.ToString());
			throw new ArgumentException(string.Format("Неверные типы аргументов >> value: {0}, targetType: {1}", value.GetType(), targetType));
		}
	}
	#endregion

	#region HandshakeConverter
	public class HandshakeConverter: IValueConverter
	{
		public static readonly Handshake[] HandshakeEnum = Enum.GetValues(typeof(Handshake)).Cast<Handshake>().ToArray();

		public static string HandshakeToString(Handshake AValue)
		{
			switch (AValue)
			{
				case Handshake.None:
					return "Нет";
				case Handshake.RequestToSend:
					return "Аппаратное";
				case Handshake.RequestToSendXOnXOff:
					return "Оба";
				case Handshake.XOnXOff:
					return "Программное";
				default:
					return AValue.ToString();
			}
		}

		public static Handshake StringToHandshake(string AValue)
		{
			return HandshakeEnum.Single(p => HandshakeToString(p) == AValue);
		}

		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if ((value is IEnumerable<Handshake>) && (targetType == typeof(System.Collections.IEnumerable)))
				return (value as IEnumerable<Handshake>).Select(v => HandshakeToString(v));
			if ((value is Handshake) && (targetType == typeof(object)))
				return HandshakeToString((Handshake)value);
			throw new ArgumentException(string.Format("Неверные типы аргументов >> value: {0}, targetType: {1}", value.GetType(), targetType));
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (targetType == typeof(Handshake))
				return StringToHandshake(value.ToString());
			throw new ArgumentException(string.Format("Неверные типы аргументов >> value: {0}, targetType: {1}", value.GetType(), targetType));
		}
	}
	#endregion

	[Flags]
	public enum DtrRts
	{ 
		None = 0,
		Dtr = 1,
		Rts = 2,
		DtrRts = 3
	}

	public class SerialPortSettings: ICloneable
	{
		private static readonly int[] FBaudrateEnum = new[] { 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000 };
		private static readonly int[] FDataBitsEnum = Enumerable.Range(4, 5).ToArray();

		private int FBaudrateValue = 9600;
		private int FDataBitsValue = 8;
		private Parity FParityValue = Parity.None;
		private StopBits FStopBitsValue = StopBits.One;
		private Handshake FHandshakeValue = Handshake.None;
		private string FPortNameValue = string.Empty;
		private DtrRts FDtrRts = DtrRts.None;

		public static List<KeyValuePair<DtrRts, string>> DtrRtsEnum
		{
			get
			{
				Dictionary<DtrRts, string> r = new Dictionary<DtrRts, string>();
				r.Add(DtrRts.None, "Не использовать");
				r.Add(DtrRts.Dtr, "DTR");
				r.Add(DtrRts.Rts, "RTS");
				r.Add(DtrRts.DtrRts, "DTR и RTS");
				return r.ToList();
			}
		}

		/// <summary>
		/// Список всех битрейтов
		/// </summary>
		public static int[] BaudrateEnum
		{
			get
			{
				return FBaudrateEnum;
			}
		}

		public static int[] DataBitsEnum
		{
			get
			{
				return FDataBitsEnum;
			}
		}


		public static List<KeyValuePair<string, Parity>> ParityEnum
		{
			get
			{
				List<KeyValuePair<string, Parity>> r = new List<KeyValuePair<string, Parity>>();
				foreach (var v in ParityConverter.ParityEnum)
					r.Add(new KeyValuePair<string, Parity>(ParityConverter.ParityToString(v), v));
				return r;
			}
		}

		public static List<KeyValuePair<string, StopBits>> StopBitsEnum
		{
			get
			{
				List<KeyValuePair<string, StopBits>> r = new List<KeyValuePair<string, StopBits>>();
				foreach (var v in StopBitsConverter.StopBitsEnum)
					r.Add(new KeyValuePair<string, StopBits>(StopBitsConverter.StopBitsToString(v), v));
				return r;
			}
		}

		public static List<KeyValuePair<string, Handshake>> HandshakeEnum
		{
			get
			{
				List<KeyValuePair<string, Handshake>> r = new List<KeyValuePair<string, Handshake>>();
				foreach (var v in HandshakeConverter.HandshakeEnum)
					r.Add(new KeyValuePair<string, Handshake>(HandshakeConverter.HandshakeToString(v), v));
				return r;
			}
		}

		public static SerialPortName[] PortNameEnum
		{
			get
			{
				using (var searcher = new ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort"))
				{
					var wmiPorts = searcher.Get().Cast<ManagementBaseObject>();
					var regPorts = SerialPort.GetPortNames();
					var ports = new List<SerialPortName>();
					foreach (var p in regPorts)
					{
						string des = string.Empty;
						var wDes = wmiPorts.FirstOrDefault(wp => wp["DeviceID"].ToString() == p);
						if (wDes != null)
							des = wDes["Description"].ToString();

						ports.Add(new SerialPortName(p, des));
					}
					//var ports = searcher.Get().Cast<ManagementBaseObject>().Select(p => new SerialPortName(p["DeviceID"].ToString(), p["Description"].ToString())).ToList();

					ports.Sort(new Comparison<SerialPortName>((SerialPortName a, SerialPortName b) =>
					{
						if (a.Name.Length == b.Name.Length)
							return a.Name.CompareTo(b.Name);
						else
							return a.Name.Length.CompareTo(b.Name.Length);
					}));

					return ports.ToArray();
				}
			}
		}

		public int BaudrateValue
		{
			get
			{
				return FBaudrateValue;
			}
			set
			{
				try
				{
					if (FBaudrateValue == value)
						return;
					// Проверка на наличие такой скорости в исписке
					FBaudrateValue = FBaudrateEnum.Single(v => v == value);
				}
				catch
				{
					throw new Exception("Неверное значение скорости");
				}
			}
		}

		public int DataBitsValue
		{
			get
			{
				return FDataBitsValue;
			}
			set
			{
				try
				{
					if (FDataBitsValue == value)
						return;
					// Проверка на наличие такого значения в исписке
					FDataBitsValue = FDataBitsEnum.AsParallel().Single(v => v == value);
				}
				catch
				{
					throw new Exception("Неверное значение битов данных");
				}
			}
		}

		public Parity ParityValue
		{
			get
			{
				return FParityValue;
			}
			set
			{
				if (FParityValue == value)
					return;
				FParityValue = value;
			}
		}

		public DtrRts DtrRtsValue
		{
			get
			{
				return FDtrRts;
			}
			set
			{
				if (FDtrRts == value)
					return;
				FDtrRts = value;
			}
		}

		public StopBits StopBitsValue
		{
			get
			{
				return FStopBitsValue;
			}
			set
			{
				if (FStopBitsValue == value)
					return;
				FStopBitsValue = value;
			}
		}

		public Handshake HandshakeValue
		{
			get
			{
				return FHandshakeValue;
			}
			set
			{
				if (FHandshakeValue == value)
					return;
				FHandshakeValue = value;
			}
		}

		public string PortNameValue
		{
			get
			{
				return FPortNameValue;
			}
			set
			{
				if (FPortNameValue == value)
					return;
				FPortNameValue = value;
			}
		}

		public object Clone()
		{
			return MemberwiseClone();
		}

		public void ToPort(SerialPort ASerialPort)
		{
			if (string.IsNullOrEmpty(PortNameValue))
				throw new Exception("Порт не задан!");
			ASerialPort.PortName = PortNameValue;
			ASerialPort.BaudRate = BaudrateValue;
			ASerialPort.DataBits = DataBitsValue;
			ASerialPort.Parity = ParityValue;
			ASerialPort.StopBits = StopBitsValue;
			ASerialPort.Handshake = HandshakeValue;
			ASerialPort.DtrEnable = DtrRtsValue.HasFlag(DtrRts.Dtr);
			ASerialPort.RtsEnable = DtrRtsValue.HasFlag(DtrRts.Rts);
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(PortNameValue);
			sb.Append(": ");
			sb.Append(BaudrateValue);
			sb.Append(", ");
			sb.Append(DataBitsValue);
			sb.Append(", ");
			sb.Append(ParityConverter.ParityToString(ParityValue));
			sb.Append(", ");
			sb.Append(StopBitsConverter.StopBitsToString(StopBitsValue));
			sb.Append(", ");
			sb.Append(HandshakeConverter.HandshakeToString(HandshakeValue));

			return sb.ToString();
		}
	}
}
