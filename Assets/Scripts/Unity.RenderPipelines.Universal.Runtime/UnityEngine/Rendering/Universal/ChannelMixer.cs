using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public sealed class ChannelMixer : VolumeComponent, IPostProcessComponent
	{
		public ClampedFloatParameter redOutRedIn;

		public ClampedFloatParameter redOutGreenIn;

		public ClampedFloatParameter redOutBlueIn;

		public ClampedFloatParameter greenOutRedIn;

		public ClampedFloatParameter greenOutGreenIn;

		public ClampedFloatParameter greenOutBlueIn;

		public ClampedFloatParameter blueOutRedIn;

		public ClampedFloatParameter blueOutGreenIn;

		public ClampedFloatParameter blueOutBlueIn;

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
