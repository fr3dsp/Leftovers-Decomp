using System;
using System.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	public abstract class ScriptableRenderer : IDisposable
	{
		private static class Profiling
		{
			public static class RenderBlock
			{
				private const string k_Name = "RenderPassBlock";

				public static readonly ProfilingSampler beforeRendering;

				public static readonly ProfilingSampler mainRenderingOpaque;

				public static readonly ProfilingSampler mainRenderingTransparent;

				public static readonly ProfilingSampler afterRendering;
			}

			public static class RenderPass
			{
				private const string k_Name = "ScriptableRenderPass";

				public static readonly ProfilingSampler configure;
			}

			private const string k_Name = "ScriptableRenderer";

			public static readonly ProfilingSampler setPerCameraShaderVariables;

			public static readonly ProfilingSampler sortRenderPasses;

			public static readonly ProfilingSampler setupLights;

			public static readonly ProfilingSampler setupCamera;

			public static readonly ProfilingSampler addRenderPasses;

			public static readonly ProfilingSampler clearRenderingState;

			public static readonly ProfilingSampler internalStartRendering;

			public static readonly ProfilingSampler internalFinishRendering;
		}

		public class RenderingFeatures
		{
			public bool cameraStacking { get; set; }

			public bool msaa { get; set; }
		}

		private static class RenderPassBlock
		{
			public static readonly int BeforeRendering;

			public static readonly int MainRenderingOpaque;

			public static readonly int MainRenderingTransparent;

			public static readonly int AfterRendering;
		}

		internal struct RenderBlocks : IDisposable
		{
			public struct BlockRange : IDisposable
			{
				private int m_Current;

				private int m_End;

				public int Current => 0;

				public BlockRange(int begin, int end)
				{
					m_Current = 0;
					m_End = 0;
				}

				public BlockRange GetEnumerator()
				{
					return default(BlockRange);
				}

				public bool MoveNext()
				{
					return false;
				}

				public void Dispose()
				{
				}
			}

			private NativeArray<RenderPassEvent> m_BlockEventLimits;

			private NativeArray<int> m_BlockRanges;

			private NativeArray<int> m_BlockRangeLengths;

			public RenderBlocks(List<ScriptableRenderPass> activeRenderPassQueue)
			{
				m_BlockEventLimits = default(NativeArray<RenderPassEvent>);
				m_BlockRanges = default(NativeArray<int>);
				m_BlockRangeLengths = default(NativeArray<int>);
			}

			public void Dispose()
			{
			}

			private void FillBlockRanges(List<ScriptableRenderPass> activeRenderPassQueue)
			{
			}

			public int GetLength(int index)
			{
				return 0;
			}

			public BlockRange GetRange(int index)
			{
				return default(BlockRange);
			}
		}

		internal static ScriptableRenderer current;

		private const int k_RenderPassBlockCount = 4;

		private List<ScriptableRenderPass> m_ActiveRenderPassQueue;

		private List<ScriptableRendererFeature> m_RendererFeatures;

		private RenderTargetIdentifier m_CameraColorTarget;

		private RenderTargetIdentifier m_CameraDepthTarget;

		private bool m_FirstTimeCameraColorTargetIsBound;

		private bool m_FirstTimeCameraDepthTargetIsBound;

		private bool m_IsPipelineExecuting;

		internal bool isCameraColorTargetValid;

		private static RenderTargetIdentifier[] m_ActiveColorAttachments;

		private static RenderTargetIdentifier m_ActiveDepthAttachment;

		private static RenderTargetIdentifier[][] m_TrimmedColorAttachmentCopies;

		[Obsolete]
		public RenderTargetIdentifier cameraDepth => default(RenderTargetIdentifier);

		protected ProfilingSampler profilingExecute { get; set; }

		public RenderTargetIdentifier cameraColorTarget => default(RenderTargetIdentifier);

		public RenderTargetIdentifier cameraDepthTarget => default(RenderTargetIdentifier);

		protected List<ScriptableRendererFeature> rendererFeatures => null;

		protected List<ScriptableRenderPass> activeRenderPassQueue => null;

		public RenderingFeatures supportedRenderingFeatures { get; set; }

		public GraphicsDeviceType[] unsupportedGraphicsDeviceTypes { get; set; }

		public static void SetCameraMatrices(CommandBuffer cmd, ref CameraData cameraData, bool setInverseMatrices)
		{
		}

		private void SetPerCameraShaderVariables(CommandBuffer cmd, ref CameraData cameraData)
		{
		}

		private void SetShaderTimeValues(CommandBuffer cmd, float time, float deltaTime, float smoothDeltaTime)
		{
		}

		internal static void ConfigureActiveTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment)
		{
		}

		public ScriptableRenderer(ScriptableRendererData data)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public void ConfigureCameraTarget(RenderTargetIdentifier colorTarget, RenderTargetIdentifier depthTarget)
		{
		}

		internal void ConfigureCameraColorTarget(RenderTargetIdentifier colorTarget)
		{
		}

		public abstract void Setup(ScriptableRenderContext context, ref RenderingData renderingData);

		public virtual void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public virtual void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
		{
		}

		public virtual void FinishRendering(CommandBuffer cmd)
		{
		}

		public void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public void EnqueuePass(ScriptableRenderPass pass)
		{
		}

		protected static ClearFlag GetCameraClearFlag(ref CameraData cameraData)
		{
			return default(ClearFlag);
		}

		protected void AddRenderPasses(ref RenderingData renderingData)
		{
		}

		private void ClearRenderingState(CommandBuffer cmd)
		{
		}

		internal void Clear(CameraRenderType cameraType)
		{
		}

		private void ExecuteBlock(int blockIndex, in RenderBlocks renderBlocks, ScriptableRenderContext context, ref RenderingData renderingData, bool submit = false)
		{
		}

		private void ExecuteRenderPass(ScriptableRenderContext context, ScriptableRenderPass renderPass, ref RenderingData renderingData)
		{
		}

		private void SetRenderPassAttachments(CommandBuffer cmd, ScriptableRenderPass renderPass, ref CameraData cameraData)
		{
		}

		private void BeginXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData)
		{
		}

		private void EndXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData)
		{
		}

		internal static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor)
		{
		}

		private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, ClearFlag clearFlags, Color clearColor)
		{
		}

		private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthAttachment, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlags, Color clearColor)
		{
		}

		private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorAttachments, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor)
		{
		}

		private void DrawGizmos(ScriptableRenderContext context, Camera camera, GizmoSubset gizmoSubset)
		{
		}

		private void DrawWireOverlay(ScriptableRenderContext context, Camera camera)
		{
		}

		private void InternalStartRendering(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private void InternalFinishRendering(ScriptableRenderContext context, bool resolveFinalTarget)
		{
		}

		internal static void SortStable(List<ScriptableRenderPass> list)
		{
		}
	}
}
