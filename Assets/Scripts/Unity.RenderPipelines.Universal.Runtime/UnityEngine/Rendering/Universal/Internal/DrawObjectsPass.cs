using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class DrawObjectsPass : ScriptableRenderPass
	{
		private FilteringSettings m_FilteringSettings;

		private RenderStateBlock m_RenderStateBlock;

		private List<ShaderTagId> m_ShaderTagIdList;

		private string m_ProfilerTag;

		private ProfilingSampler m_ProfilingSampler;

		private bool m_IsOpaque;

		private static readonly int s_DrawObjectPassDataPropID;

		public DrawObjectsPass(string profilerTag, ShaderTagId[] shaderTagIds, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
		{
		}

		public DrawObjectsPass(string profilerTag, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
		{
		}

		internal DrawObjectsPass(URPProfileId profileId, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
}
