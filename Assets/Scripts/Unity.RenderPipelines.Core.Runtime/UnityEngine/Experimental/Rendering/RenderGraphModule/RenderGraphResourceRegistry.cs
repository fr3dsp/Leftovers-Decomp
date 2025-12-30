using System.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	internal class RenderGraphResourceRegistry
	{
		private class IRenderGraphResource
		{
			public bool imported;

			public int cachedHash;

			public int transientPassIndex;

			public uint writeCount;

			public bool wasReleased;

			public bool requestFallBack;

			public virtual void Reset()
			{
			}

			public virtual string GetName()
			{
				return null;
			}

			public virtual bool IsCreated()
			{
				return false;
			}

			public void IncrementWriteCount()
			{
			}

			public bool NeedsFallBack()
			{
				return false;
			}
		}

		private class RenderGraphResource<DescType, ResType> : IRenderGraphResource where DescType : struct where ResType : class
		{
			public DescType desc;

			public ResType resource;

			protected RenderGraphResource()
			{
			}

			public override void Reset()
			{
			}

			public override bool IsCreated()
			{
				return false;
			}
		}

		private class TextureResource : RenderGraphResource<TextureDesc, RTHandle>
		{
			public override string GetName()
			{
				return null;
			}
		}

		private class ComputeBufferResource : RenderGraphResource<ComputeBufferDesc, ComputeBuffer>
		{
			public override string GetName()
			{
				return null;
			}
		}

		internal struct RendererListResource
		{
			public RendererListDesc desc;

			public RendererList rendererList;

			internal RendererListResource(in RendererListDesc desc)
			{
				this.desc = default(RendererListDesc);
				rendererList = default(RendererList);
			}
		}

		private static readonly ShaderTagId s_EmptyName;

		private static RenderGraphResourceRegistry m_CurrentRegistry;

		private DynamicArray<IRenderGraphResource>[] m_Resources;

		private TexturePool m_TexturePool;

		private int m_TextureCreationIndex;

		private ComputeBufferPool m_ComputeBufferPool;

		private DynamicArray<RendererListResource> m_RendererListResources;

		private RenderGraphDebugParams m_RenderGraphDebug;

		private RenderGraphLogger m_Logger;

		private int m_CurrentFrameIndex;

		private RTHandle m_CurrentBackbuffer;

		internal static RenderGraphResourceRegistry current
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal RTHandle GetTexture(in TextureHandle handle)
		{
			return null;
		}

		internal bool TextureNeedsFallback(in TextureHandle handle)
		{
			return false;
		}

		internal RendererList GetRendererList(in RendererListHandle handle)
		{
			return default(RendererList);
		}

		internal ComputeBuffer GetComputeBuffer(in ComputeBufferHandle handle)
		{
			return null;
		}

		private RenderGraphResourceRegistry()
		{
		}

		internal RenderGraphResourceRegistry(RenderGraphDebugParams renderGraphDebug, RenderGraphLogger logger)
		{
		}

		internal void BeginRender(int currentFrameIndex, int executionCount)
		{
		}

		internal void EndRender()
		{
		}

		private void CheckHandleValidity(in ResourceHandle res)
		{
		}

		private void CheckHandleValidity(RenderGraphResourceType type, int index)
		{
		}

		internal void IncrementWriteCount(in ResourceHandle res)
		{
		}

		internal string GetResourceName(in ResourceHandle res)
		{
			return null;
		}

		internal string GetResourceName(RenderGraphResourceType type, int index)
		{
			return null;
		}

		internal bool IsResourceImported(in ResourceHandle res)
		{
			return false;
		}

		internal bool IsResourceCreated(in ResourceHandle res)
		{
			return false;
		}

		internal bool IsRendererListCreated(in RendererListHandle res)
		{
			return false;
		}

		internal bool IsResourceImported(RenderGraphResourceType type, int index)
		{
			return false;
		}

		internal int GetResourceTransientIndex(in ResourceHandle res)
		{
			return 0;
		}

		internal TextureHandle ImportTexture(RTHandle rt)
		{
			return default(TextureHandle);
		}

		internal TextureHandle ImportBackbuffer(RenderTargetIdentifier rt)
		{
			return default(TextureHandle);
		}

		private int AddNewResource<ResType>(DynamicArray<IRenderGraphResource> resourceArray, out ResType outRes) where ResType : IRenderGraphResource, new()
		{
			outRes = null;
			return 0;
		}

		internal TextureHandle CreateTexture(in TextureDesc desc, int transientPassIndex = -1)
		{
			return default(TextureHandle);
		}

		internal int GetTextureResourceCount()
		{
			return 0;
		}

		private TextureResource GetTextureResource(in ResourceHandle handle)
		{
			return null;
		}

		internal TextureDesc GetTextureResourceDesc(in ResourceHandle handle)
		{
			return default(TextureDesc);
		}

		internal RendererListHandle CreateRendererList(in RendererListDesc desc)
		{
			return default(RendererListHandle);
		}

		internal ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer)
		{
			return default(ComputeBufferHandle);
		}

		internal ComputeBufferHandle CreateComputeBuffer(in ComputeBufferDesc desc, int transientPassIndex = -1)
		{
			return default(ComputeBufferHandle);
		}

		internal ComputeBufferDesc GetComputeBufferResourceDesc(in ResourceHandle handle)
		{
			return default(ComputeBufferDesc);
		}

		internal int GetComputeBufferResourceCount()
		{
			return 0;
		}

		private ComputeBufferResource GetComputeBufferResource(in ResourceHandle handle)
		{
			return null;
		}

		internal void CreateAndClearTexture(RenderGraphContext rgContext, int index)
		{
		}

		internal void CreateComputeBuffer(RenderGraphContext rgContext, int index)
		{
		}

		internal void ReleaseTexture(RenderGraphContext rgContext, int index)
		{
		}

		internal void ReleaseComputeBuffer(RenderGraphContext rgContext, int index)
		{
		}

		private void ValidateTextureDesc(in TextureDesc desc)
		{
		}

		private void ValidateRendererListDesc(in RendererListDesc desc)
		{
		}

		private void ValidateComputeBufferDesc(in ComputeBufferDesc desc)
		{
		}

		internal void CreateRendererLists(List<RendererListHandle> rendererLists)
		{
		}

		internal void Clear(bool onException)
		{
		}

		internal void PurgeUnusedResources()
		{
		}

		internal void Cleanup()
		{
		}

		private void LogTextureCreation(TextureResource rt)
		{
		}

		private void LogTextureRelease(TextureResource rt)
		{
		}

		private void LogComputeBufferCreation(ComputeBufferResource buffer)
		{
		}

		private void LogComputeBufferRelease(ComputeBufferResource buffer)
		{
		}

		private void LogResources()
		{
		}
	}
}
