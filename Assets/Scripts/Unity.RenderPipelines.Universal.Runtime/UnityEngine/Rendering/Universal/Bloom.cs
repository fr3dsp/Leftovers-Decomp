using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public sealed class Bloom : VolumeComponent, IPostProcessComponent
	{
		public MinFloatParameter threshold;

		public MinFloatParameter intensity;

		public ClampedFloatParameter scatter;

		public MinFloatParameter clamp;

		public ColorParameter tint;

		public BoolParameter highQualityFiltering;

		public ClampedIntParameter skipIterations;

		public TextureParameter dirtTexture;

		public MinFloatParameter dirtIntensity;

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
