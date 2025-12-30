using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class NoInterpMaxFloatParameter : VolumeParameter<float>
	{
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

		public NoInterpMaxFloatParameter(float value, float max, bool overrideState = false)
		{
		}
	}
}
