using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class AdditionalLightsShadowCasterPass : ScriptableRenderPass
	{
		private static class AdditionalShadowsConstantBuffer
		{
			public static int _AdditionalLightsWorldToShadow;

			public static int _AdditionalShadowParams;

			public static int _AdditionalShadowOffset0;

			public static int _AdditionalShadowOffset1;

			public static int _AdditionalShadowOffset2;

			public static int _AdditionalShadowOffset3;

			public static int _AdditionalShadowmapSize;
		}

		public static int m_AdditionalShadowsBufferId;

		public static int m_AdditionalShadowsIndicesId;

		private bool m_UseStructuredBuffer;

		private const int k_ShadowmapBufferBits = 16;

		private RenderTargetHandle m_AdditionalLightsShadowmap;

		private RenderTexture m_AdditionalLightsShadowmapTexture;

		private int m_ShadowmapWidth;

		private int m_ShadowmapHeight;

		private ShadowSliceData[] m_AdditionalLightSlices;

		private Matrix4x4[] m_AdditionalLightsWorldToShadow;

		private Vector4[] m_AdditionalLightsShadowParams;

		private ShaderInput.ShadowData[] m_AdditionalLightsShadowData;

		private List<int> m_AdditionalShadowCastingLightIndices;

		private List<int> m_AdditionalShadowCastingLightIndicesMap;

		private List<int> m_ShadowCastingLightIndicesMap;

		private bool m_SupportsBoxFilterForShadows;

		private ProfilingSampler m_ProfilingSetupSampler;

		public AdditionalLightsShadowCasterPass(RenderPassEvent evt)
		{
		}

		public bool Setup(ref RenderingData renderingData)
		{
			return false;
		}

		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		public int GetShadowLightIndexFromLightIndex(int visibleLightIndex)
		{
			return 0;
		}

		private void Clear()
		{
		}

		private void RenderAdditionalShadowmapAtlas(ref ScriptableRenderContext context, ref CullingResults cullResults, ref LightData lightData, ref ShadowData shadowData)
		{
		}

		private void SetupAdditionalLightsShadowReceiverConstants(CommandBuffer cmd, ref ShadowData shadowData, bool softShadows)
		{
		}

		private bool IsValidShadowCastingLight(ref LightData lightData, int i)
		{
			return false;
		}
	}
}
