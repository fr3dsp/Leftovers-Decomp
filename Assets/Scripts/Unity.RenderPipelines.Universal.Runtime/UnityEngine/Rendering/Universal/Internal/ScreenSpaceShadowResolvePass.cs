namespace UnityEngine.Rendering.Universal.Internal
{
	public class ScreenSpaceShadowResolvePass : ScriptableRenderPass
	{
		private Material m_ScreenSpaceShadowsMaterial;

		private RenderTargetHandle m_ScreenSpaceShadowmap;

		private RenderTextureDescriptor m_RenderTextureDescriptor;

		public ScreenSpaceShadowResolvePass(RenderPassEvent evt, Material screenspaceShadowsMaterial)
		{
		}

		public void Setup(RenderTextureDescriptor baseDescriptor)
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
