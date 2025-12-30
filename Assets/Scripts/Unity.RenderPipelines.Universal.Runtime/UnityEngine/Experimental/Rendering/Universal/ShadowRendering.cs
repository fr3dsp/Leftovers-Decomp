using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Experimental.Rendering.Universal
{
	internal static class ShadowRendering
	{
		private static readonly int k_LightPosID;

		private static readonly int k_ShadowStencilGroupID;

		private static readonly int k_ShadowIntensityID;

		private static readonly int k_ShadowVolumeIntensityID;

		private static readonly int k_ShadowRadiusID;

		private static Material GetShadowMaterial(this Renderer2DData rendererData, int index)
		{
			return null;
		}

		private static Material GetRemoveSelfShadowMaterial(this Renderer2DData rendererData, int index)
		{
			return null;
		}

		private static void CreateShadowRenderTexture(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, int blendStyleIndex)
		{
		}

		public static void RenderShadows(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, int layerToRender, Light2D light, float shadowIntensity, RenderTargetIdentifier renderTexture, RenderTargetIdentifier depthTexture)
		{
		}
	}
}
