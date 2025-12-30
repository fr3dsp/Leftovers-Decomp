using System.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	internal abstract class RenderGraphPass
	{
		public List<ResourceHandle>[] resourceReadLists;

		public List<ResourceHandle>[] resourceWriteLists;

		public List<ResourceHandle>[] transientResourceList;

		public List<RendererListHandle> usedRendererListList;

		public string name { get; protected set; }

		public int index { get; protected set; }

		public ProfilingSampler customSampler { get; protected set; }

		public bool enableAsyncCompute { get; protected set; }

		public bool allowPassCulling { get; protected set; }

		public TextureHandle depthBuffer { get; protected set; }

		public TextureHandle[] colorBuffers { get; protected set; }

		public int colorBufferMaxIndex { get; protected set; }

		public int refCount { get; protected set; }

		public bool generateDebugData { get; protected set; }

		public RenderFunc<PassData> GetExecuteDelegate<PassData>() where PassData : class, new()
		{
			return null;
		}

		public abstract void Execute(RenderGraphContext renderGraphContext);

		public abstract void Release(RenderGraphObjectPool pool);

		public abstract bool HasRenderFunc();

		public RenderGraphPass()
		{
		}

		public void Clear()
		{
		}

		public void AddResourceWrite(in ResourceHandle res)
		{
		}

		public void AddResourceRead(in ResourceHandle res)
		{
		}

		public void AddTransientResource(in ResourceHandle res)
		{
		}

		public void UseRendererList(RendererListHandle rendererList)
		{
		}

		public void EnableAsyncCompute(bool value)
		{
		}

		public void AllowPassCulling(bool value)
		{
		}

		public void GenerateDebugData(bool value)
		{
		}

		public void SetColorBuffer(TextureHandle resource, int index)
		{
		}

		public void SetDepthBuffer(TextureHandle resource, DepthAccess flags)
		{
		}
	}
	internal sealed class RenderGraphPass<PassData> : RenderGraphPass where PassData : class, new()
	{
		internal PassData data;

		internal RenderFunc<PassData> renderFunc;

		public override void Execute(RenderGraphContext renderGraphContext)
		{
		}

		public void Initialize(int passIndex, PassData passData, string passName, ProfilingSampler sampler)
		{
		}

		public override void Release(RenderGraphObjectPool pool)
		{
		}

		public override bool HasRenderFunc()
		{
			return false;
		}
	}
}
