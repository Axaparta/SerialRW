using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerialRW.DataCoders
{
	public class PlainTextCoder: DataCoder
	{
		public override string DataToString(byte[] AData, Encoding AEncoding)
		{
			string str = AEncoding.GetString(AData);
			StringBuilder sb = new StringBuilder();
			foreach (var ch in str)
				if (!char.IsControl(ch))
					sb.Append(ch);
				else
					if (ch == NewLineChar)
						sb.AppendLine();

			return sb.ToString().TrimEnd();
		}

		public override byte[] StringToData(string AString, Encoding AEncoding)
		{
			return AEncoding.GetBytes(AString);
		}

		public override string Name
		{
			get
			{
				return "Простой текст";
			}
		}
	}
}
