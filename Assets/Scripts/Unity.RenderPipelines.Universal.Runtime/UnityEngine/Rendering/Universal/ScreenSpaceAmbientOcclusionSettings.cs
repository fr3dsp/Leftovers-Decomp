using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	internal class ScreenSpaceAmbientOcclusionSettings
	{
		internal enum DepthSource
		{
			Depth = 0,
			DepthNormals = 1
		}

		internal enum NormalQuality
		{
			Low = 0,
			Medium = 1,
			High = 2
		}

		[SerializeField]
		internal bool Downsample;

		[SerializeField]
		internal DepthSource Source;

		[SerializeField]
		internal NormalQuality NormalSamples;

		[SerializeField]
		internal float Intensity;

		[SerializeField]
		internal float DirectLightingStrength;

		[SerializeField]
		internal float Radius;

		[SerializeField]
		internal int SampleCount;
	}
}
