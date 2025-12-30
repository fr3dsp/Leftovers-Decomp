using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public sealed class ChromaticAberration : VolumeComponent, IPostProcessComponent
	{
		public ClampedFloatParameter intensity;

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
