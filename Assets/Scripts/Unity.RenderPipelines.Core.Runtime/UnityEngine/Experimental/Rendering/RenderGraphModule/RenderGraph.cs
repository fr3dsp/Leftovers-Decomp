using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	public class RenderGraph
	{
		internal struct CompiledResourceInfo
		{
			public List<int> producers;

			public List<int> consumers;

			public bool resourceCreated;

			public int refCount;

			public void Reset()
			{
			}
		}

		internal struct CompiledPassInfo
		{
			public RenderGraphPass pass;

			public List<int>[] resourceCreateList;

			public List<int>[] resourceReleaseList;

			public int refCount;

			public bool culled;

			public bool hasSideEffect;

			public int syncToPassIndex;

			public int syncFromPassIndex;

			public bool needGraphicsFence;

			public GraphicsFence fence;

			public bool enableAsyncCompute;

			public bool allowPassCulling => false;

			public void Reset(RenderGraphPass pass)
			{
			}
		}

		private class ProfilingScopePassData
		{
			public ProfilingSampler sampler;
		}

		internal delegate void OnGraphRegisteredDelegate(RenderGraph graph);

		public static readonly int kMaxMRTCount;

		private RenderGraphResourceRegistry m_Resources;

		private RenderGraphObjectPool m_RenderGraphPool;

		private List<RenderGraphPass> m_RenderPasses;

		private List<RendererListHandle> m_RendererLists;

		private RenderGraphDebugParams m_DebugParameters;

		private RenderGraphLogger m_Logger;

		private RenderGraphDefaultResources m_DefaultResources;

		private Dictionary<int, ProfilingSampler> m_DefaultProfilingSamplers;

		private bool m_ExecutionExceptionWasRaised;

		private RenderGraphContext m_RenderGraphContext;

		private CommandBuffer m_PreviousCommandBuffer;

		private int m_CurrentImmediatePassIndex;

		private List<int>[] m_ImmediateModeResourceList;

		private DynamicArray<CompiledResourceInfo>[] m_CompiledResourcesInfos;

		private DynamicArray<CompiledPassInfo> m_CompiledPassInfos;

		private Stack<int> m_CullingStack;

		private int m_ExecutionCount;

		private RenderGraphDebugData m_RenderGraphDebugData;

		private static List<RenderGraph> s_RegisteredGraphs;

		public string name { get; private set; }

		internal static bool requireDebugData { get; set; }

		public RenderGraphDefaultResources defaultResources => null;

		internal static event OnGraphRegisteredDelegate onGraphRegistered
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal static event OnGraphRegisteredDelegate onGraphUnregistered
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public RenderGraph(string name = "RenderGraph")
		{
		}

		public void Cleanup()
		{
		}

		internal RenderGraphDebugData GetDebugData()
		{
			return null;
		}

		public void EndFrame()
		{
		}

		public TextureHandle ImportTexture(RTHandle rt)
		{
			return default(TextureHandle);
		}

		public TextureHandle ImportBackbuffer(RenderTargetIdentifier rt)
		{
			return default(TextureHandle);
		}

		public TextureHandle CreateTexture(in TextureDesc desc)
		{
			return default(TextureHandle);
		}

		public TextureHandle CreateTexture(TextureHandle texture)
		{
			return default(TextureHandle);
		}

		public void CreateTextureIfInvalid(in TextureDesc desc, ref TextureHandle texture)
		{
		}

		public TextureDesc GetTextureDesc(TextureHandle texture)
		{
			return default(TextureDesc);
		}

		public RendererListHandle CreateRendererList(in RendererListDesc desc)
		{
			return default(RendererListHandle);
		}

		public ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer)
		{
			return default(ComputeBufferHandle);
		}

		public ComputeBufferHandle CreateComputeBuffer(in ComputeBufferDesc desc)
		{
			return default(ComputeBufferHandle);
		}

		public ComputeBufferHandle CreateComputeBuffer(in ComputeBufferHandle computeBuffer)
		{
			return default(ComputeBufferHandle);
		}

		public ComputeBufferDesc GetComputeBufferDesc(in ComputeBufferHandle computeBuffer)
		{
			return default(ComputeBufferDesc);
		}

		public RenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData, ProfilingSampler sampler) where PassData : class, new()
		{
			passData = null;
			return default(RenderGraphBuilder);
		}

		public RenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData) where PassData : class, new()
		{
			passData = null;
			return default(RenderGraphBuilder);
		}

		public void Begin(in RenderGraphParameters parameters)
		{
		}

		public void Execute()
		{
		}

		public void BeginProfilingSampler(ProfilingSampler sampler)
		{
		}

		public void EndProfilingSampler(ProfilingSampler sampler)
		{
		}

		internal static List<RenderGraph> GetRegisteredRenderGraphs()
		{
			return null;
		}

		internal DynamicArray<CompiledPassInfo> GetCompiledPassInfos()
		{
			return null;
		}

		internal void ClearCompiledGraph()
		{
		}

		private void InvalidateContext()
		{
		}

		internal void OnPassAdded(RenderGraphPass pass)
		{
		}

		private void InitResourceInfosData(DynamicArray<CompiledResourceInfo> resourceInfos, int count)
		{
		}

		private void InitializeCompilationData()
		{
		}

		private void CountReferences()
		{
		}

		private void CullOutputlessPasses()
		{
		}

		private void CullUnusedPasses()
		{
		}

		private void UpdatePassSynchronization(ref CompiledPassInfo currentPassInfo, ref CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex)
		{
		}

		private void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, in CompiledResourceInfo resource)
		{
		}

		private int GetLatestProducerIndex(int passIndex, in CompiledResourceInfo info)
		{
			return 0;
		}

		private int GetLatestValidReadIndex(in CompiledResourceInfo info)
		{
			return 0;
		}

		private int GetFirstValidWriteIndex(in CompiledResourceInfo info)
		{
			return 0;
		}

		private int GetLatestValidWriteIndex(in CompiledResourceInfo info)
		{
			return 0;
		}

		private void UpdateResourceAllocationAndSynchronization()
		{
		}

		internal void CompileRenderGraph()
		{
		}

		private ref CompiledPassInfo CompilePassImmediatly(RenderGraphPass pass)
		{
			throw null;
		}

		private void ExecutePassImmediatly(RenderGraphPass pass)
		{
		}

		private void ExecuteCompiledPass(ref CompiledPassInfo passInfo, int passIndex)
		{
		}

		private void ExecuteRenderGraph()
		{
		}

		private void PreRenderPassSetRenderTargets(in CompiledPassInfo passInfo, RenderGraphContext rgContext)
		{
		}

		private void PreRenderPassExecute(in CompiledPassInfo passInfo, RenderGraphContext rgContext)
		{
		}

		private void PostRenderPassExecute(ref CompiledPassInfo passInfo, RenderGraphContext rgContext)
		{
		}

		private void ClearRenderPasses()
		{
		}

		private void ReleaseImmediateModeResources()
		{
		}

		private void LogFrameInformation()
		{
		}

		private void LogRendererListsCreation()
		{
		}

		private void LogRenderPassBegin(in CompiledPassInfo passInfo)
		{
		}

		private void LogCulledPasses()
		{
		}

		private ProfilingSampler GetDefaultProfilingSampler(string name)
		{
			return null;
		}

		private void UpdateImportedResourceLifeTime(ref RenderGraphDebugData.ResourceDebugData data, List<int> passList)
		{
		}

		private void GenerateDebugData()
		{
		}
	}
}
