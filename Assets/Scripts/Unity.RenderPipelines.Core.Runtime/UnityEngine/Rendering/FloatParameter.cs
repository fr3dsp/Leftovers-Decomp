using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class FloatParameter : VolumeParameter<float>
	{
		public FloatParameter(float value, bool overrideState = false)
		{
		}

		public sealed override void Interp(float from, float to, float t)
		{
		}
	}
}
