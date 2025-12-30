using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class ClampedFloatParameter : FloatParameter
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

		public ClampedFloatParameter(float value, float min, float max, bool overrideState = false)
			: base(0f)
		{
		}
	}
}
