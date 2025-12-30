using System;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	public struct RenderGraphBuilder : IDisposable
	{
		private RenderGraphPass m_RenderPass;

		private RenderGraphResourceRegistry m_Resources;

		private RenderGraph m_RenderGraph;

		private bool m_Disposed;

		public TextureHandle UseColorBuffer(in TextureHandle input, int index)
		{
			return default(TextureHandle);
		}

		public TextureHandle UseDepthBuffer(in TextureHandle input, DepthAccess flags)
		{
			return default(TextureHandle);
		}

		public TextureHandle ReadTexture(in TextureHandle input)
		{
			return default(TextureHandle);
		}

		public TextureHandle WriteTexture(in TextureHandle input)
		{
			return default(TextureHandle);
		}

		public TextureHandle ReadWriteTexture(in TextureHandle input)
		{
			return default(TextureHandle);
		}

		public TextureHandle CreateTransientTexture(in TextureDesc desc)
		{
			return default(TextureHandle);
		}

		public TextureHandle CreateTransientTexture(in TextureHandle texture)
		{
			return default(TextureHandle);
		}

		public RendererListHandle UseRendererList(in RendererListHandle input)
		{
			return default(RendererListHandle);
		}

		public ComputeBufferHandle ReadComputeBuffer(in ComputeBufferHandle input)
		{
			return default(ComputeBufferHandle);
		}

		public ComputeBufferHandle WriteComputeBuffer(in ComputeBufferHandle input)
		{
			return default(ComputeBufferHandle);
		}

		public ComputeBufferHandle CreateTransientComputeBuffer(in ComputeBufferDesc desc)
		{
			return default(ComputeBufferHandle);
		}

		public ComputeBufferHandle CreateTransientComputeBuffer(in ComputeBufferHandle computebuffer)
		{
			return default(ComputeBufferHandle);
		}

		public void SetRenderFunc<PassData>(RenderFunc<PassData> renderFunc) where PassData : class, new()
		{
		}

		public void EnableAsyncCompute(bool value)
		{
		}

		public void AllowPassCulling(bool value)
		{
		}

		public void Dispose()
		{
		}

		internal RenderGraphBuilder(RenderGraphPass renderPass, RenderGraphResourceRegistry resources, RenderGraph renderGraph)
		{
			m_RenderPass = null;
			m_Resources = null;
			m_RenderGraph = null;
			m_Disposed = false;
		}

		private void Dispose(bool disposing)
		{
		}

		private void CheckResource(in ResourceHandle res)
		{
		}

		internal void GenerateDebugData(bool value)
		{
		}
	}
}
