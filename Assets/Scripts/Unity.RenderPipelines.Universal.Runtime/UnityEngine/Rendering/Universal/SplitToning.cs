using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public sealed class SplitToning : VolumeComponent, IPostProcessComponent
	{
		public ColorParameter shadows;

		public ColorParameter highlights;

		public ClampedFloatParameter balance;

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
