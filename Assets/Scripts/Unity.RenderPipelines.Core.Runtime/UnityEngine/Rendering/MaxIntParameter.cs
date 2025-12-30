using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class MaxIntParameter : IntParameter
	{
		public int max;

		public override int value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public MaxIntParameter(int value, int max, bool overrideState = false)
			: base(0)
		{
		}
	}
}
