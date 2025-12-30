using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public sealed class ShadowsMidtonesHighlights : VolumeComponent, IPostProcessComponent
	{
		public Vector4Parameter shadows;

		public Vector4Parameter midtones;

		public Vector4Parameter highlights;

		public MinFloatParameter shadowsStart;

		public MinFloatParameter shadowsEnd;

		public MinFloatParameter highlightsStart;

		public MinFloatParameter highlightsEnd;

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
