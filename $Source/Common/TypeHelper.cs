using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace SerialRW.Common
{
	public static class TypeHelper
	{
		public static readonly Type[] AppTypes = Assembly.GetExecutingAssembly().GetTypes();

		public static bool ContainParent(Type AType, Type AParent)
		{
			if (AType.IsAbstract)
				return false;
			while (AType != null)
			{
				if (AType == AParent)
					return true;
				AType = AType.BaseType;
			}
			return false;
		}

		public static Type[] GetInheritors(Type AParent)
		{
			return AppTypes.Where(t => ContainParent(t, AParent)).ToArray();
		}

		public static T GetAttributeOfType<T>(this Type AType) where T: System.Attribute
		{
			//var name = typeof(T).Name;
			//foreach (var a in TypeDescriptor.GetAttributes(AType))
			//	if (string.CompareOrdinal(a.GetType().Name, name) == 0)
			//		return (T)a;
			//return null;
			return (T)Attribute.GetCustomAttribute(AType, typeof(T));
		}
	}
}
