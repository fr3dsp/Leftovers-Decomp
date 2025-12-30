using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class NoInterpMinIntParameter : VolumeParameter<int>
	{
		public int min;

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

		public NoInterpMinIntParameter(int value, int min, bool overrideState = false)
		{
		}
	}
}
