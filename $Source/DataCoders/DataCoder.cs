using System;
using System.Text;

namespace SerialRW.DataCoders
{
	public abstract class DataCoder
	{
		public const char ReturnChar = (char)13;
		public const char NewLineChar = (char)10;

		public abstract string DataToString(byte[] AData, Encoding AEncoding);
		public abstract byte[] StringToData(string AString, Encoding AEncoding);
		public abstract string Name { get; }
	}
}
