using System;
using System.Drawing;
using System.Windows.Forms;

namespace SerialRW.Settings
{
	public class ToolStripSettings: ICloneable
	{
		public Point? Location { get; set; }
		public bool Visible { get; set; }
		public AnchorStyles Align { get; set; }

		public ToolStripSettings()
		{
			Location = null;
			Visible = true;
			Align = AnchorStyles.None;
		}

		public void FromToolStrip(ToolStrip AToolStrip)
		{
			Location = AToolStrip.Location;
			Align = AnchorStyles.None;
			if ((AToolStrip.Parent != null) && (AToolStrip.Parent.Parent is ToolStripContainer))
			{
				ToolStripContainer c = (ToolStripContainer)AToolStrip.Parent.Parent;
				if (AToolStrip.Parent == c.TopToolStripPanel)
					Align = AnchorStyles.Top;
				else
					if (AToolStrip.Parent == c.BottomToolStripPanel)
						Align = AnchorStyles.Bottom;
					else
						if (AToolStrip.Parent == c.LeftToolStripPanel)
							Align = AnchorStyles.Left;
						else
							if (AToolStrip.Parent == c.RightToolStripPanel)
								Align = AnchorStyles.Right;
			}
		}

		public void ToToolStrip(ToolStrip AToolStrip)
		{
			AToolStrip.Visible = Visible;
			if ((AToolStrip.Parent != null) && (AToolStrip.Parent.Parent is ToolStripContainer))
			{
				switch (Align)
				{
					case AnchorStyles.Top:
						(AToolStrip.Parent.Parent as ToolStripContainer).TopToolStripPanel.Controls.Add(AToolStrip);
						break;
					case AnchorStyles.Left:
						(AToolStrip.Parent.Parent as ToolStripContainer).LeftToolStripPanel.Controls.Add(AToolStrip);
						break;
					case AnchorStyles.Bottom:
						(AToolStrip.Parent.Parent as ToolStripContainer).BottomToolStripPanel.Controls.Add(AToolStrip);
						break;
					case AnchorStyles.Right:
						(AToolStrip.Parent.Parent as ToolStripContainer).RightToolStripPanel.Controls.Add(AToolStrip);
						break;
				}
			}
			if (Location.HasValue)
				AToolStrip.Location = Location.Value;
		}

		public object Clone()
		{
			return MemberwiseClone();
		}
	}
}
