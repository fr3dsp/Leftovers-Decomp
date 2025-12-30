using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public sealed class WhiteBalance : VolumeComponent, IPostProcessComponent
	{
		public ClampedFloatParameter temperature;

		public ClampedFloatParameter tint;

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
