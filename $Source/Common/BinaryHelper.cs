using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerialRW
{
	public static class BinaryHelper
	{
		public static void Save(Stream AStream, object AObject)
		{
			BinaryFormatter bformatter = new BinaryFormatter();
			bformatter.Binder = new ClassBinder();
			bformatter.Serialize(AStream, AObject);
		}

		public static void Save(string AFileName, object AObject)
		{
			using (var s = File.Create(AFileName))
				Save(s, AObject);
		}

		public static T Load<T>(Stream AStream)
		{
			BinaryFormatter bformatter = new BinaryFormatter();
			bformatter.Binder = new ClassBinder();
			return (T)bformatter.Deserialize(AStream);
		}

		public static T Load<T>(string AFileName)
		{
			using (var s = File.OpenRead(AFileName))
				return Load<T>(s);
		}

		public static byte[] ToBytes<T>(T[] AArray)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				Save(ms, AArray);
				return ms.ToArray();
			}
		}

		public static T[] ToArray<T>(byte[] AData)
		{
			using (MemoryStream ms = new MemoryStream(AData))
			{
				return Load<T[]>(ms);
			}
		}

		private sealed class ClassBinder: SerializationBinder
		{
			public override Type BindToType(string assemblyName, string typeName)
			{
				if (!string.IsNullOrEmpty(assemblyName) && !string.IsNullOrEmpty(typeName))
				{
					Type typeToDeserialize = null;
					assemblyName = Assembly.GetExecutingAssembly().FullName;
					typeToDeserialize = Type.GetType(String.Format("{0}, {1}", typeName, assemblyName));
					return typeToDeserialize;
				}
				return null;
			}

			public override void BindToName(Type serializedType, out string assemblyName, out string typeName)
			{
				assemblyName = serializedType.Assembly.GetName().Name;
				typeName = serializedType.FullName;
			}
		}
	}
}
