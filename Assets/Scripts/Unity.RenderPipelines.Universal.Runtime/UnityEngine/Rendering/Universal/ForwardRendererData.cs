using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	[ReloadGroup]
	[ExcludeFromPreset]
	public class ForwardRendererData : ScriptableRendererData
	{
		[Serializable]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			public Shader blitPS;

			public Shader copyDepthPS;

			public Shader screenSpaceShadowPS;

			public Shader samplingPS;

			public Shader tileDepthInfoPS;

			public Shader tileDeferredPS;

			public Shader stencilDeferredPS;

			public Shader fallbackErrorPS;

			public Shader materialErrorPS;
		}

		public PostProcessData postProcessData;

		public XRSystemData xrSystemData;

		public ShaderResources shaders;

		[SerializeField]
		private LayerMask m_OpaqueLayerMask;

		[SerializeField]
		private LayerMask m_TransparentLayerMask;

		[SerializeField]
		private StencilStateData m_DefaultStencilState;

		[SerializeField]
		private bool m_ShadowTransparentReceive;

		[SerializeField]
		private RenderingMode m_RenderingMode;

		[SerializeField]
		private bool m_AccurateGbufferNormals;

		public LayerMask opaqueLayerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public LayerMask transparentLayerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public StencilStateData defaultStencilState
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool shadowTransparentReceive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public RenderingMode renderingMode
		{
			get
			{
				return default(RenderingMode);
			}
			set
			{
			}
		}

		public bool accurateGbufferNormals
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override ScriptableRenderer Create()
		{
			return null;
		}

		protected override void OnEnable()
		{
		}
	}
}
