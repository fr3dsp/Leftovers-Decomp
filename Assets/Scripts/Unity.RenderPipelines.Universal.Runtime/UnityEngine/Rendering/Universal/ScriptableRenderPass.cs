using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	public abstract class ScriptableRenderPass
	{
		private RenderTargetIdentifier[] m_ColorAttachments;

		private RenderTargetIdentifier m_DepthAttachment;

		private ScriptableRenderPassInput m_Input;

		private ClearFlag m_ClearFlag;

		private Color m_ClearColor;

		public RenderPassEvent renderPassEvent { get; set; }

		public RenderTargetIdentifier[] colorAttachments => null;

		public RenderTargetIdentifier colorAttachment => default(RenderTargetIdentifier);

		public RenderTargetIdentifier depthAttachment => default(RenderTargetIdentifier);

		public ScriptableRenderPassInput input => default(ScriptableRenderPassInput);

		public ClearFlag clearFlag => default(ClearFlag);

		public Color clearColor => default(Color);

		protected internal ProfilingSampler profilingSampler { get; set; }

		internal bool overrideCameraTarget { get; set; }

		internal bool isBlitRenderPass { get; set; }

		public virtual void FrameCleanup(CommandBuffer cmd)
		{
		}

		public ScriptableRenderPass()
		{
		}

		public void ConfigureInput(ScriptableRenderPassInput passInput)
		{
		}

		public void ConfigureTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment)
		{
		}

		public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments, RenderTargetIdentifier depthAttachment)
		{
		}

		public void ConfigureTarget(RenderTargetIdentifier colorAttachment)
		{
		}

		public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments)
		{
		}

		public void ConfigureClear(ClearFlag clearFlag, Color clearColor)
		{
		}

		public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		public virtual void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		public virtual void OnFinishCameraStackRendering(CommandBuffer cmd)
		{
		}

		public abstract void Execute(ScriptableRenderContext context, ref RenderingData renderingData);

		public void Blit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material = null, int passIndex = 0)
		{
		}

		public DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		public DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		public static bool operator <(ScriptableRenderPass lhs, ScriptableRenderPass rhs)
		{
			return false;
		}

		public static bool operator >(ScriptableRenderPass lhs, ScriptableRenderPass rhs)
		{
			return false;
		}
	}
}
