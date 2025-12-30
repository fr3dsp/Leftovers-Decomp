using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public sealed class LiftGammaGain : VolumeComponent, IPostProcessComponent
	{
		public Vector4Parameter lift;

		public Vector4Parameter gamma;

		public Vector4Parameter gain;

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
