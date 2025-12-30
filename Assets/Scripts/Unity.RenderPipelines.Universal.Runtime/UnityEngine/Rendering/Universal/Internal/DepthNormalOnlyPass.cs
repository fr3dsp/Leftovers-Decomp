namespace UnityEngine.Rendering.Universal.Internal
{
	public class DepthNormalOnlyPass : ScriptableRenderPass
	{
		private ShaderTagId m_ShaderTagId;

		private FilteringSettings m_FilteringSettings;

		private const int k_DepthBufferBits = 32;

		internal RenderTextureDescriptor normalDescriptor { get; private set; }

		internal RenderTextureDescriptor depthDescriptor { get; private set; }

		private RenderTargetHandle depthHandle { get; set; }

		private RenderTargetHandle normalHandle { get; set; }

		public DepthNormalOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask)
		{
		}

		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle depthHandle, RenderTargetHandle normalHandle)
		{
		}

		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
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
