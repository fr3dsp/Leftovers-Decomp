namespace UnityEngine.Rendering.Universal
{
	internal class CapturePass : ScriptableRenderPass
	{
		private RenderTargetHandle m_CameraColorHandle;

		private const string m_ProfilerTag = "Capture Pass";

		private static readonly ProfilingSampler m_ProfilingSampler;

		public CapturePass(RenderPassEvent evt)
		{
		}

		public void Setup(RenderTargetHandle colorHandle)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
}
