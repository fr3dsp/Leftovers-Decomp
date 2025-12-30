namespace UnityEngine.Rendering.Universal.Internal
{
	internal class TileDepthRangePass : ScriptableRenderPass
	{
		private DeferredLights m_DeferredLights;

		private int m_PassIndex;

		public TileDepthRangePass(RenderPassEvent evt, DeferredLights deferredLights, int passIndex)
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
