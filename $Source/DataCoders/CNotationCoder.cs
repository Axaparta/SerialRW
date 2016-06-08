using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SerialRW.DataCoders
{
	public class CNotationCoder: DataCoder
	{
		public override string DataToString(byte[] AData, Encoding AEncoding)
		{
			string str = AEncoding.GetString(AData);
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < str.Length; i++)
			{
				switch (str[i])
				{ 
					case (char)10:
						sb.Append("\\n");
						break;
					case (char)13:
						sb.Append("\\r");
						break;
					case (char)9:
						sb.Append("\\t");
						break;
					default:
						if (char.IsControl(str[i]))
						{
							sb.Append("\\x");
							sb.Append(Convert.ToByte(str[i]).ToString("X2"));
						}
						else
							sb.Append(str[i]);
						break;
				}
			}
			return sb.ToString();
		}

		public override byte[] StringToData(string AString, Encoding AEncoding)
		{
			StringBuilder r = new StringBuilder();
			for (int i = 0; i < AString.Length; i++)
			{
				if (AString[i] == '\\')
				{
					i++;
					if (i >= AString.Length)
						throw new Exception("Завершающий '\\' не имеет завершения!");
					switch (AString[i])
					{
						case 'n':
							r.Append(NewLineChar);
							break;
						case 'r':
							r.Append(ReturnChar);
							break;
						case 't':
							r.Append((char)9);
							break;
						case 'x':
							i += 2;
							if (i >= AString.Length)
								throw new Exception("Завершающему '\\x' не хватает данных!");
							try
							{
								int v = int.Parse(AString.Substring(i - 1, 2), NumberStyles.HexNumber);
								r.Append((char)v);
							}
							catch
							{
								throw new Exception(string.Format("Ошибка при конвертировании '\\x{0}'", AString.Substring(i - 1, 2)));
							}
							break;
						case 'd':
							i += 3;
							if (i >= AString.Length)
								throw new Exception("Завершающему '\\d' не хватает данных!");
							try
							{
								int v = int.Parse(AString.Substring(i - 2, 3), NumberStyles.Integer);
								r.Append((char)v);
							}
							catch
							{
								throw new Exception(string.Format("Ошибка при конвертировании '\\d{0}'", AString.Substring(i - 1, 3)));
							}
							break;
						default:
							throw new Exception(string.Format("Нераспознанная последовательность '\\{0}'!", AString[i]));
					}
				}
				else
					r.Append(AString[i]);
			}
			return AEncoding.GetBytes(r.ToString());
		}

		public override string Name
		{
			get
			{
				return "Формат строки C";
			}
		}
	}
}
