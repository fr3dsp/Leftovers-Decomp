using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public sealed class MotionBlur : VolumeComponent, IPostProcessComponent
	{
		public MotionBlurModeParameter mode;

		public MotionBlurQualityParameter quality;

		public ClampedFloatParameter intensity;

		public ClampedFloatParameter clamp;

		public bool IsActive()
		{
			return false;
		}

		public bool IsTileCompatible()
		{
			return false;
		}
	}
}
