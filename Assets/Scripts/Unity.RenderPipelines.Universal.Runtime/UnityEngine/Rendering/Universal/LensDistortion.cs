using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public sealed class LensDistortion : VolumeComponent, IPostProcessComponent
	{
		public ClampedFloatParameter intensity;

		public ClampedFloatParameter xMultiplier;

		public ClampedFloatParameter yMultiplier;

		public Vector2Parameter center;

		public ClampedFloatParameter scale;

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
