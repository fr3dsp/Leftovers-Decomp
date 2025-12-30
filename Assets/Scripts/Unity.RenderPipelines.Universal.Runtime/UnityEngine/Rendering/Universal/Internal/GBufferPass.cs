namespace UnityEngine.Rendering.Universal.Internal
{
	internal class GBufferPass : ScriptableRenderPass
	{
		private static ShaderTagId s_ShaderTagLit;

		private static ShaderTagId s_ShaderTagSimpleLit;

		private static ShaderTagId s_ShaderTagUnlit;

		private static ShaderTagId s_ShaderTagUniversalGBuffer;

		private static ShaderTagId s_ShaderTagUniversalMaterialType;

		private ProfilingSampler m_ProfilingSampler;

		private DeferredLights m_DeferredLights;

		private ShaderTagId[] m_ShaderTagValues;

		private RenderStateBlock[] m_RenderStateBlocks;

		private FilteringSettings m_FilteringSettings;

		private RenderStateBlock m_RenderStateBlock;

		public GBufferPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference, DeferredLights deferredLights)
		{
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
	}
}
