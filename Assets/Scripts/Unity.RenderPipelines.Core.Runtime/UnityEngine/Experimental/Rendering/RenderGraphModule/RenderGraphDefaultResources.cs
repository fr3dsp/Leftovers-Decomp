using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	public class RenderGraphDefaultResources
	{
		private bool m_IsValid;

		private RTHandle m_BlackTexture2D;

		private RTHandle m_WhiteTexture2D;

		public TextureHandle blackTexture { get; private set; }

		public TextureHandle whiteTexture { get; private set; }

		public TextureHandle clearTextureXR { get; private set; }

		public TextureHandle magentaTextureXR { get; private set; }

		public TextureHandle blackTextureXR { get; private set; }

		public TextureHandle blackTextureArrayXR { get; private set; }

		public TextureHandle blackUIntTextureXR { get; private set; }

		public TextureHandle blackTexture3DXR { get; private set; }

		public TextureHandle whiteTextureXR { get; private set; }

		internal RenderGraphDefaultResources()
		{
		}

		internal void Cleanup()
		{
		}

		internal void InitializeForRendering(RenderGraph renderGraph)
		{
		}
	}
}
