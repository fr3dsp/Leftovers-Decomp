namespace UnityEngine.Rendering.Universal.Internal
{
	internal class DeferredPass : ScriptableRenderPass
	{
		private DeferredLights m_DeferredLights;

		public DeferredPass(RenderPassEvent evt, DeferredLights deferredLights)
		{
		}

		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescripor)
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
