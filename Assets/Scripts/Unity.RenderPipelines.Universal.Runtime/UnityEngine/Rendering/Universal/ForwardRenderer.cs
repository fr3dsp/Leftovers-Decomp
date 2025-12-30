using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal
{
	public sealed class ForwardRenderer : ScriptableRenderer
	{
		private static class Profiling
		{
			private const string k_Name = "ForwardRenderer";

			public static readonly ProfilingSampler createCameraRenderTarget;
		}

		private struct RenderPassInputSummary
		{
			internal bool requiresDepthTexture;

			internal bool requiresDepthPrepass;

			internal bool requiresNormalsTexture;

			internal bool requiresColorTexture;
		}

		private const int k_DepthStencilBufferBits = 32;

		private ColorGradingLutPass m_ColorGradingLutPass;

		private DepthOnlyPass m_DepthPrepass;

		private DepthNormalOnlyPass m_DepthNormalPrepass;

		private MainLightShadowCasterPass m_MainLightShadowCasterPass;

		private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass;

		private GBufferPass m_GBufferPass;

		private CopyDepthPass m_GBufferCopyDepthPass;

		private TileDepthRangePass m_TileDepthRangePass;

		private TileDepthRangePass m_TileDepthRangeExtraPass;

		private DeferredPass m_DeferredPass;

		private DrawObjectsPass m_RenderOpaqueForwardOnlyPass;

		private DrawObjectsPass m_RenderOpaqueForwardPass;

		private DrawSkyboxPass m_DrawSkyboxPass;

		private CopyDepthPass m_CopyDepthPass;

		private CopyColorPass m_CopyColorPass;

		private TransparentSettingsPass m_TransparentSettingsPass;

		private DrawObjectsPass m_RenderTransparentForwardPass;

		private InvokeOnRenderObjectCallbackPass m_OnRenderObjectCallbackPass;

		private PostProcessPass m_PostProcessPass;

		private PostProcessPass m_FinalPostProcessPass;

		private FinalBlitPass m_FinalBlitPass;

		private CapturePass m_CapturePass;

		private XROcclusionMeshPass m_XROcclusionMeshPass;

		private CopyDepthPass m_XRCopyDepthPass;

		private RenderTargetHandle m_ActiveCameraColorAttachment;

		private RenderTargetHandle m_ActiveCameraDepthAttachment;

		private RenderTargetHandle m_CameraColorAttachment;

		private RenderTargetHandle m_CameraDepthAttachment;

		private RenderTargetHandle m_DepthTexture;

		private RenderTargetHandle m_NormalsTexture;

		private RenderTargetHandle[] m_GBufferHandles;

		private RenderTargetHandle m_OpaqueColor;

		private RenderTargetHandle m_AfterPostProcessColor;

		private RenderTargetHandle m_ColorGradingLut;

		private RenderTargetHandle m_DepthInfoTexture;

		private RenderTargetHandle m_TileDepthInfoTexture;

		private ForwardLights m_ForwardLights;

		private DeferredLights m_DeferredLights;

		private RenderingMode m_RenderingMode;

		private StencilState m_DefaultStencilState;

		private Material m_BlitMaterial;

		private Material m_CopyDepthMaterial;

		private Material m_SamplingMaterial;

		private Material m_ScreenspaceShadowsMaterial;

		private Material m_TileDepthInfoMaterial;

		private Material m_TileDeferredMaterial;

		private Material m_StencilDeferredMaterial;

		internal RenderingMode renderingMode => default(RenderingMode);

		internal RenderingMode actualRenderingMode => default(RenderingMode);

		internal bool accurateGbufferNormals => false;

		public ForwardRenderer(ForwardRendererData data)
			: base(null)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
		{
		}

		public override void FinishRendering(CommandBuffer cmd)
		{
		}

		private void EnqueueDeferred(ref RenderingData renderingData, bool hasDepthPrepass, bool applyMainShadow, bool applyAdditionalShadow)
		{
		}

		private RenderPassInputSummary GetRenderPassInputs(ref RenderingData renderingData)
		{
			return default(RenderPassInputSummary);
		}

		private void CreateCameraRenderTarget(ScriptableRenderContext context, ref RenderTextureDescriptor descriptor, bool createColor, bool createDepth)
		{
		}

		private bool PlatformRequiresExplicitMsaaResolve()
		{
			return false;
		}

		private bool RequiresIntermediateColorTexture(ref CameraData cameraData)
		{
			return false;
		}

		private bool CanCopyDepth(ref CameraData cameraData)
		{
			return false;
		}
	}
}
