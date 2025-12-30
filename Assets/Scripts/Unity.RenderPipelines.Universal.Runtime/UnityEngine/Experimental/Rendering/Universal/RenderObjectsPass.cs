using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Experimental.Rendering.Universal
{
	public class RenderObjectsPass : ScriptableRenderPass
	{
		private RenderQueueType renderQueueType;

		private FilteringSettings m_FilteringSettings;

		private RenderObjects.CustomCameraSettings m_CameraSettings;

		private string m_ProfilerTag;

		private ProfilingSampler m_ProfilingSampler;

		private List<ShaderTagId> m_ShaderTagIdList;

		private RenderStateBlock m_RenderStateBlock;

		public Material overrideMaterial { get; set; }

		public int overrideMaterialPassIndex { get; set; }

		public void SetDetphState(bool writeEnabled, CompareFunction function = CompareFunction.Less)
		{
		}

		public void SetStencilState(int reference, CompareFunction compareFunction, StencilOp passOp, StencilOp failOp, StencilOp zFailOp)
		{
		}

		public RenderObjectsPass(string profilerTag, RenderPassEvent renderPassEvent, string[] shaderTags, RenderQueueType renderQueueType, int layerMask, RenderObjects.CustomCameraSettings cameraSettings)
		{
		}

		internal RenderObjectsPass(URPProfileId profileId, RenderPassEvent renderPassEvent, string[] shaderTags, RenderQueueType renderQueueType, int layerMask, RenderObjects.CustomCameraSettings cameraSettings)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
}
