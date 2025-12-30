using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class NoInterpMaxIntParameter : VolumeParameter<int>
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

		public NoInterpMaxIntParameter(int value, int max, bool overrideState = false)
		{
		}
	}
}
