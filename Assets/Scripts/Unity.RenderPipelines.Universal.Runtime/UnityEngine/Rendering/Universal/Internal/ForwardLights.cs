using Unity.Collections;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class ForwardLights
	{
		private static class LightConstantBuffer
		{
			public static int _MainLightPosition;

			public static int _MainLightColor;

			public static int _MainLightOcclusionProbesChannel;

			public static int _AdditionalLightsCount;

			public static int _AdditionalLightsPosition;

			public static int _AdditionalLightsColor;

			public static int _AdditionalLightsAttenuation;

			public static int _AdditionalLightsSpotDir;

			public static int _AdditionalLightOcclusionProbeChannel;
		}

		private int m_AdditionalLightsBufferId;

		private int m_AdditionalLightsIndicesId;

		private const string k_SetupLightConstants = "Setup Light Constants";

		private static readonly ProfilingSampler m_ProfilingSampler;

		private MixedLightingSetup m_MixedLightingSetup;

		private Vector4[] m_AdditionalLightPositions;

		private Vector4[] m_AdditionalLightColors;

		private Vector4[] m_AdditionalLightAttenuations;

		private Vector4[] m_AdditionalLightSpotDirections;

		private Vector4[] m_AdditionalLightOcclusionProbeChannels;

		private bool m_UseStructuredBuffer;

		public void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private void InitializeLightConstants(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel)
		{
			lightPos = default(Vector4);
			lightColor = default(Vector4);
			lightAttenuation = default(Vector4);
			lightSpotDir = default(Vector4);
			lightOcclusionProbeChannel = default(Vector4);
		}

		private void SetupShaderLightConstants(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		private void SetupMainLightConstants(CommandBuffer cmd, ref LightData lightData)
		{
		}

		private void SetupAdditionalLightConstants(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		private int SetupPerObjectLightIndices(CullingResults cullResults, ref LightData lightData)
		{
			return 0;
		}
	}
}
