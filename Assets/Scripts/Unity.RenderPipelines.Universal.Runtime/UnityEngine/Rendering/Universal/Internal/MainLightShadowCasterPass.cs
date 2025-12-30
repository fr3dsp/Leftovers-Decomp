namespace UnityEngine.Rendering.Universal.Internal
{
	public class MainLightShadowCasterPass : ScriptableRenderPass
	{
		private static class MainLightShadowConstantBuffer
		{
			public static int _WorldToShadow;

			public static int _ShadowParams;

			public static int _CascadeShadowSplitSpheres0;

			public static int _CascadeShadowSplitSpheres1;

			public static int _CascadeShadowSplitSpheres2;

			public static int _CascadeShadowSplitSpheres3;

			public static int _CascadeShadowSplitSphereRadii;

			public static int _ShadowOffset0;

			public static int _ShadowOffset1;

			public static int _ShadowOffset2;

			public static int _ShadowOffset3;

			public static int _ShadowmapSize;
		}

		private const int k_MaxCascades = 4;

		private const int k_ShadowmapBufferBits = 16;

		private float m_MaxShadowDistance;

		private int m_ShadowmapWidth;

		private int m_ShadowmapHeight;

		private int m_ShadowCasterCascadesCount;

		private bool m_SupportsBoxFilterForShadows;

		private RenderTargetHandle m_MainLightShadowmap;

		private RenderTexture m_MainLightShadowmapTexture;

		private Matrix4x4[] m_MainLightShadowMatrices;

		private ShadowSliceData[] m_CascadeSlices;

		private Vector4[] m_CascadeSplitDistances;

		private ProfilingSampler m_ProfilingSetupSampler;

		public MainLightShadowCasterPass(RenderPassEvent evt)
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

		private void Clear()
		{
		}

		private void RenderMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref CullingResults cullResults, ref LightData lightData, ref ShadowData shadowData)
		{
		}

		private void SetupMainLightShadowReceiverConstants(CommandBuffer cmd, VisibleLight shadowLight, bool supportsSoftShadows)
		{
		}
	}
}
