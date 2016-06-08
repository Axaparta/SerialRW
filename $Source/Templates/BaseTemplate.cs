using System;

namespace SerialRW.Templates
{
	[Serializable]
	public abstract class BaseTemplate: ICloneable
	{
		public string Name
		{
			get; set;
		}

		public string SendProcessScript
		{
			get; set;
		}

		public string ReceiveProcessScript
		{
			get; set;
		}

		public string AutoAnswertScript
		{
			get; set;
		}

		public abstract byte[] SendProcess(byte[] ASend);
		public abstract string[] ReceiveProcess(byte[] AReceive);
		public abstract byte[] AutoAnswert(byte[] AData);

		public BaseTemplate()
		{
			Name = string.Empty;
			SendProcessScript = string.Empty;
			ReceiveProcessScript = string.Empty;
			AutoAnswertScript = string.Empty;
		}

		public override string ToString()
		{
			return Name;
		}

		public virtual object Clone()
		{
			var r = (BaseTemplate)MemberwiseClone();
			r.Name = this.Name;
			r.SendProcessScript = this.SendProcessScript;
			r.ReceiveProcessScript = this.ReceiveProcessScript;
			r.AutoAnswertScript = this.AutoAnswertScript;
			return r;
		}
	}
}
