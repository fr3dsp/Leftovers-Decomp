namespace UnityEngine.Rendering.Universal.Internal
{
	public class FinalBlitPass : ScriptableRenderPass
	{
		private RenderTargetHandle m_Source;

		private Material m_BlitMaterial;

		public FinalBlitPass(RenderPassEvent evt, Material blitMaterial)
		{
		}

		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorHandle)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
}
