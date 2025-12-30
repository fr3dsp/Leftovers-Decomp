using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public sealed class DepthOfField : VolumeComponent, IPostProcessComponent
	{
		public DepthOfFieldModeParameter mode;

		public MinFloatParameter gaussianStart;

		public MinFloatParameter gaussianEnd;

		public ClampedFloatParameter gaussianMaxRadius;

		public BoolParameter highQualitySampling;

		public MinFloatParameter focusDistance;

		public ClampedFloatParameter aperture;

		public ClampedFloatParameter focalLength;

		public ClampedIntParameter bladeCount;

		public ClampedFloatParameter bladeCurvature;

		public ClampedFloatParameter bladeRotation;

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
