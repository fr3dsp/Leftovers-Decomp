using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class NoInterpClampedIntParameter : VolumeParameter<int>
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

		public NoInterpClampedIntParameter(int value, int min, int max, bool overrideState = false)
		{
		}
	}
}
