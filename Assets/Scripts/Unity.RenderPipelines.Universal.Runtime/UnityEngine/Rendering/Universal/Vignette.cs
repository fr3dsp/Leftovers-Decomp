using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public sealed class Vignette : VolumeComponent, IPostProcessComponent
	{
		public ColorParameter color;

		public Vector2Parameter center;

		public ClampedFloatParameter intensity;

		public ClampedFloatParameter smoothness;

		public BoolParameter rounded;

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
