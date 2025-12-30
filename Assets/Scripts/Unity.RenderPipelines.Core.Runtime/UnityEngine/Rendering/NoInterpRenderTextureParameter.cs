using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class NoInterpRenderTextureParameter : VolumeParameter<RenderTexture>
	{
		public NoInterpRenderTextureParameter(RenderTexture value, bool overrideState = false)
		{
		}
	}
}
