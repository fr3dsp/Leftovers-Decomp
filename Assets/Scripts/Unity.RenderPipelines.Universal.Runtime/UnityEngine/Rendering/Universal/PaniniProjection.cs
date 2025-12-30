using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public sealed class PaniniProjection : VolumeComponent, IPostProcessComponent
	{
		public ClampedFloatParameter distance;

		public ClampedFloatParameter cropToFit;

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
