using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public sealed class ColorLookup : VolumeComponent, IPostProcessComponent
	{
		public TextureParameter texture;

		public ClampedFloatParameter contribution;

		public bool IsActive()
		{
			return false;
		}

		public bool IsTileCompatible()
		{
			return false;
		}

		public bool ValidateLUT()
		{
			return false;
		}
	}
}
