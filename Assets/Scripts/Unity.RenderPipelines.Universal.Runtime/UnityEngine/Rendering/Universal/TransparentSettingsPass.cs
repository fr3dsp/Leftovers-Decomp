namespace UnityEngine.Rendering.Universal
{
	internal class TransparentSettingsPass : ScriptableRenderPass
	{
		private bool m_shouldReceiveShadows;

		private const string m_ProfilerTag = "Transparent Settings Pass";

		private static readonly ProfilingSampler m_ProfilingSampler;

		public TransparentSettingsPass(RenderPassEvent evt, bool shadowReceiveSupported)
		{
		}

		public bool Setup(ref RenderingData renderingData)
		{
			return false;
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
}
