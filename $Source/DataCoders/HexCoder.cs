using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerialRW.DataCoders
{
	public class HexCoder: DataCoder
	{
		public override string DataToString(byte[] AData, Encoding AEncoding)
		{
			return string.Join<string>(" ", AData.Select(d => d.ToString("X2")));
		}

		public override byte[] StringToData(string AString, Encoding AEncoding)
		{
			AString = AString.ToUpper();
			StringBuilder sb = new StringBuilder(AString.Length);
			foreach (var ch in AString)
				if (((ch >= '0') && (ch <= '9')) || (ch >= 'A') && (ch <='F'))
					sb.Append(ch);
				else
					if (!char.IsSeparator(ch) && !char.IsPunctuation(ch))
						throw new Exception(string.Format("Некорректный символ {0}", ch));
			AString = sb.ToString();
			if (AString.Length%2 != 0)
				throw new Exception("Шестнадцатиричных знаков должно быть чётное число!");
			int rindex = 0;
			byte[] r = new byte[AString.Length/2];
			for (int i = 0; i < AString.Length; i+=2, rindex++)
				r[rindex] = byte.Parse(AString.Substring(i, 2), System.Globalization.NumberStyles.HexNumber);
			return r;
		}

		public override string Name
		{
			get
			{
				return "Только HEX";
			}
		}
	}
}
