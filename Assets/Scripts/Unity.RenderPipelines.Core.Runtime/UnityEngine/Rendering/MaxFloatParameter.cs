using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class MaxFloatParameter : FloatParameter
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

		public MaxFloatParameter(float value, float max, bool overrideState = false)
			: base(0f)
		{
		}
	}
}
