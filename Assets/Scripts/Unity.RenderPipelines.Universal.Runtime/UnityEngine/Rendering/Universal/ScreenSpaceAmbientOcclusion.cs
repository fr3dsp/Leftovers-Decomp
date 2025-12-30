namespace UnityEngine.Rendering.Universal
{
	[DisallowMultipleRendererFeature]
	internal class ScreenSpaceAmbientOcclusion : ScriptableRendererFeature
	{
		private class ScreenSpaceAmbientOcclusionPass : ScriptableRenderPass
		{
			private enum ShaderPasses
			{
				AO = 0,
				BlurHorizontal = 1,
				BlurVertical = 2,
				BlurFinal = 3
			}

			internal string profilerTag;

			internal Material material;

			private ScreenSpaceAmbientOcclusionSettings m_CurrentSettings;

			private ProfilingSampler m_ProfilingSampler;

			private RenderTargetIdentifier m_SSAOTexture1Target;

			private RenderTargetIdentifier m_SSAOTexture2Target;

			private RenderTargetIdentifier m_SSAOTexture3Target;

			private RenderTextureDescriptor m_Descriptor;

			private const string k_SSAOAmbientOcclusionParamName = "_AmbientOcclusionParam";

			private const string k_SSAOTextureName = "_ScreenSpaceOcclusionTexture";

			private static readonly int s_BaseMapID;

			private static readonly int s_SSAOParamsID;

			private static readonly int s_SSAOTexture1ID;

			private static readonly int s_SSAOTexture2ID;

			private static readonly int s_SSAOTexture3ID;

			internal ScreenSpaceAmbientOcclusionPass()
			{
			}

			internal bool Setup(ScreenSpaceAmbientOcclusionSettings featureSettings)
			{
				return false;
			}

			public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
			{
			}

			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
			}

			private void Render(CommandBuffer cmd, RenderTargetIdentifier target, ShaderPasses pass)
			{
			}

			private void RenderAndSetBaseMap(CommandBuffer cmd, RenderTargetIdentifier baseMap, RenderTargetIdentifier target, ShaderPasses pass)
			{
			}

			public override void OnCameraCleanup(CommandBuffer cmd)
			{
			}
		}

		[SerializeField]
		[HideInInspector]
		private Shader m_Shader;

		[SerializeField]
		private ScreenSpaceAmbientOcclusionSettings m_Settings;

		private Material m_Material;

		private ScreenSpaceAmbientOcclusionPass m_SSAOPass;

		private const string k_ShaderName = "Hidden/Universal Render Pipeline/ScreenSpaceAmbientOcclusion";

		private const string k_OrthographicCameraKeyword = "_ORTHOGRAPHIC";

		private const string k_NormalReconstructionLowKeyword = "_RECONSTRUCT_NORMAL_LOW";

		private const string k_NormalReconstructionMediumKeyword = "_RECONSTRUCT_NORMAL_MEDIUM";

		private const string k_NormalReconstructionHighKeyword = "_RECONSTRUCT_NORMAL_HIGH";

		private const string k_SourceDepthKeyword = "_SOURCE_DEPTH";

		private const string k_SourceDepthNormalsKeyword = "_SOURCE_DEPTH_NORMALS";

		private const string k_SourceGBufferKeyword = "_SOURCE_GBUFFER";

		public override void Create()
		{
		}

		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		private bool GetMaterial()
		{
			return false;
		}
	}
}
