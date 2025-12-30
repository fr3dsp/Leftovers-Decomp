using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public sealed class ColorAdjustments : VolumeComponent, IPostProcessComponent
	{
		public FloatParameter postExposure;

		public ClampedFloatParameter contrast;

		public ColorParameter colorFilter;

		public ClampedFloatParameter hueShift;

		public ClampedFloatParameter saturation;

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
