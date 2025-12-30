using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class NoInterpMinFloatParameter : VolumeParameter<float>
	{
		public float min;

		public override float value
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public NoInterpMinFloatParameter(float value, float min, bool overrideState = false)
		{
		}
	}
}
