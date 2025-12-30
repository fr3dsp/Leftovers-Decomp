using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Experimental.Rendering.Universal
{
	internal class Render2DLightingPass : ScriptableRenderPass, IRenderPass2D
	{
		private static readonly int k_HDREmulationScaleID;

		private static readonly int k_InverseHDREmulationScaleID;

		private static readonly int k_UseSceneLightingID;

		private static readonly int k_RendererColorID;

		private static readonly int k_ShapeLightTexture0ID;

		private static readonly int k_ShapeLightTexture1ID;

		private static readonly int k_ShapeLightTexture2ID;

		private static readonly int k_ShapeLightTexture3ID;

		private static readonly ShaderTagId k_CombinedRenderingPassNameOld;

		private static readonly ShaderTagId k_CombinedRenderingPassName;

		private static readonly ShaderTagId k_NormalsRenderingPassName;

		private static readonly ShaderTagId k_LegacyPassName;

		private static readonly List<ShaderTagId> k_ShaderTags;

		private static readonly ProfilingSampler m_ProfilingSampler;

		private static readonly ProfilingSampler m_ProfilingSamplerUnlit;

		private readonly Renderer2DData m_Renderer2DData;

		Renderer2DData IRenderPass2D.rendererData => null;

		public Render2DLightingPass(Renderer2DData rendererData)
		{
		}

		private void GetTransparencySortingMode(Camera camera, ref SortingSettings sortingSettings)
		{
		}

		private bool CompareLightsInLayer(int layerIndex1, int layerIndex2, SortingLayer[] sortingLayers)
		{
			return false;
		}

		private int FindUpperBoundInBatch(int startLayerIndex, SortingLayer[] sortingLayers)
		{
			return 0;
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
}
