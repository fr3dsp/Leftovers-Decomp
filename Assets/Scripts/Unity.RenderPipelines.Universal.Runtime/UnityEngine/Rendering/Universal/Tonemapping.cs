using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public sealed class Tonemapping : VolumeComponent, IPostProcessComponent
	{
		public TonemappingModeParameter mode;

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
