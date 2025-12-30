using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class MinFloatParameter : FloatParameter
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

		public MinFloatParameter(float value, float min, bool overrideState = false)
			: base(0f)
		{
		}
	}
}
