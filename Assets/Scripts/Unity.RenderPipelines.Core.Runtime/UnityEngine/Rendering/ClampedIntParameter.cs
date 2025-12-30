using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class ClampedIntParameter : IntParameter
	{
		public int min;

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

		public ClampedIntParameter(int value, int min, int max, bool overrideState = false)
			: base(0)
		{
		}
	}
}
