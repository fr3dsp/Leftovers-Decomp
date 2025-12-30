using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class NoInterpFloatRangeParameter : VolumeParameter<Vector2>
	{
		public float min;

		public float max;

		public override Vector2 value
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public NoInterpFloatRangeParameter(Vector2 value, float min, float max, bool overrideState = false)
		{
		}
	}
}
