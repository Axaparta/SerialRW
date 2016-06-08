using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using CSScriptLibrary;

namespace SerialRW.Templates
{
	[Serializable]
	public class CSScriptTemplate: BaseTemplate
	{
		public CSScriptTemplate()
			: base()
		{
			SendProcessScript =
@"using System;
public class Process
{
	public byte[] SendProcess(byte[] AData)
	{
		return null;
	}
}";
			ReceiveProcessScript =
@"using System;
public class Process
{
	public string[] ReceiveProcess(byte[] AData)
	{
		return null;
	}
}";
			AutoAnswertScript =
@"using System;
public class Process
{
	public byte[] AutoAnswert(byte[] AData)
	{
		return null;
	}
}";
		}

		public override byte[] SendProcess(byte[] ASend)
		{
			if (string.IsNullOrEmpty(SendProcessScript))
				return null;
			dynamic script = CSScript.Evaluator.LoadCode(SendProcessScript);
			return script.SendProcess(ASend);
		}

		public override string[] ReceiveProcess(byte[] AReceive)
		{
			if (string.IsNullOrEmpty(ReceiveProcessScript))
				return null;
			dynamic script = CSScript.Evaluator.LoadCode(ReceiveProcessScript);
			return script.ReceiveProcess(AReceive);
		}

		public override byte[] AutoAnswert(byte[] AReceive)
		{
			if (string.IsNullOrEmpty(AutoAnswertScript))
				return null;
			dynamic script = CSScript.Evaluator.LoadCode(AutoAnswertScript);
			return script.AutoAnswert(AReceive);
		}
	}
}
