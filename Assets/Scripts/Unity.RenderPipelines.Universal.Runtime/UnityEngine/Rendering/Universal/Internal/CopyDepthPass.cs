namespace UnityEngine.Rendering.Universal.Internal
{
	public class CopyDepthPass : ScriptableRenderPass
	{
		private Material m_CopyDepthMaterial;

		private RenderTargetHandle source { get; set; }

		private RenderTargetHandle destination { get; set; }

		internal bool AllocateRT { get; set; }

		public CopyDepthPass(RenderPassEvent evt, Material copyDepthMaterial)
		{
		}

		public void Setup(RenderTargetHandle source, RenderTargetHandle destination)
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
