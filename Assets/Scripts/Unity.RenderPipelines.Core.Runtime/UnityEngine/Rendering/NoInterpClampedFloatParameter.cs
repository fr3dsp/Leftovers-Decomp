using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class NoInterpClampedFloatParameter : VolumeParameter<float>
	{
		public float min;

		public float max;

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

		public NoInterpClampedFloatParameter(float value, float min, float max, bool overrideState = false)
		{
		}
	}
}
