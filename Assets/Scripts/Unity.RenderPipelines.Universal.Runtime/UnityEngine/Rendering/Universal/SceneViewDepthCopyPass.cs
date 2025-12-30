namespace UnityEngine.Rendering.Universal
{
	internal class SceneViewDepthCopyPass : ScriptableRenderPass
	{
		private Material m_CopyDepthMaterial;

		private const string m_ProfilerTag = "Copy Depth for Scene View";

		private static readonly ProfilingSampler m_ProfilingSampler;

		private RenderTargetHandle source { get; set; }

		public SceneViewDepthCopyPass(RenderPassEvent evt, Material copyDepthMaterial)
		{
		}

		public void Setup(RenderTargetHandle source)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
}
