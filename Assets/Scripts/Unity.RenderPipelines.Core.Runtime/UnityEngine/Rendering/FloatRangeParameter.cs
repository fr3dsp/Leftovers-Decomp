using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class FloatRangeParameter : VolumeParameter<Vector2>
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

		public FloatRangeParameter(Vector2 value, float min, float max, bool overrideState = false)
		{
		}

		public override void Interp(Vector2 from, Vector2 to, float t)
		{
		}
	}
}
