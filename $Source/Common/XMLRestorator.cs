using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;

namespace SerialRW.Common
{
	[Serializable]
	public class XMLRestorator
	{
		public byte[] XMLData { get; set; }

		private static Type[] FTypes = null;
		public static Type[] Types
		{
			get
			{
				if (FTypes == null)
					FTypes = Assembly.GetExecutingAssembly().GetTypes();
				return FTypes;
			}
		}

		public XMLRestorator()
		{
			XMLData = null;
		}

		public XMLRestorator(object AObject)
		{
			XMLData = Serialize(AObject);
		}

		public object Restore()
		{
			return Deserialize(XMLData);
		}

		public T Restore<T>()
		{
			return (T)Restore();
		}

		private static byte[] Serialize(object AObject)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				BinaryHelper.Save(ms, AObject);
				return ms.ToArray();
			}
		}

		private static object Deserialize(byte[] AData)
		{
			using (MemoryStream ms = new MemoryStream(AData))
			{
				return BinaryHelper.Load<object>(ms);
			}
		}
	}
}
