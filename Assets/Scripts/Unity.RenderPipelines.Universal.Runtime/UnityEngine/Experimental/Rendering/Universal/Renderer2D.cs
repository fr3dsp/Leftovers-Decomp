using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Experimental.Rendering.Universal
{
	internal class Renderer2D : ScriptableRenderer
	{
		private ColorGradingLutPass m_ColorGradingLutPass;

		private Render2DLightingPass m_Render2DLightingPass;

		private PostProcessPass m_PostProcessPass;

		private PixelPerfectBackgroundPass m_PixelPerfectBackgroundPass;

		private FinalBlitPass m_FinalBlitPass;

		private PostProcessPass m_FinalPostProcessPass;

		private Light2DCullResult m_LightCullResult;

		private static readonly ProfilingSampler m_ProfilingSampler;

		private bool m_UseDepthStencilBuffer;

		private bool m_CreateColorTexture;

		private bool m_CreateDepthTexture;

		private readonly RenderTargetHandle k_ColorTextureHandle;

		private readonly RenderTargetHandle k_DepthTextureHandle;

		private readonly RenderTargetHandle k_AfterPostProcessColorHandle;

		private readonly RenderTargetHandle k_ColorGradingLutHandle;

		private Material m_BlitMaterial;

		private Renderer2DData m_Renderer2DData;

		internal bool createColorTexture => false;

		internal bool createDepthTexture => false;

		public Renderer2D(Renderer2DData data)
			: base(null)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public Renderer2DData GetRenderer2DData()
		{
			return null;
		}

		private void CreateRenderTextures(ref CameraData cameraData, bool forceCreateColorTexture, FilterMode colorTextureFilterMode, CommandBuffer cmd, out RenderTargetHandle colorTargetHandle, out RenderTargetHandle depthTargetHandle)
		{
			colorTargetHandle = default(RenderTargetHandle);
			depthTargetHandle = default(RenderTargetHandle);
		}

		public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
		{
		}

		public override void FinishRendering(CommandBuffer cmd)
		{
		}
	}
}
