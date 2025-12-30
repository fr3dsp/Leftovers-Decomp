using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public sealed class FilmGrain : VolumeComponent, IPostProcessComponent
	{
		public FilmGrainLookupParameter type;

		public ClampedFloatParameter intensity;

		public ClampedFloatParameter response;

		public NoInterpTextureParameter texture;

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
