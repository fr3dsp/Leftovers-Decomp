using System;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Experimental.Rendering.Universal
{
	[Serializable]
	[ReloadGroup]
	[ExcludeFromPreset]
	public class Renderer2DData : ScriptableRendererData
	{
		public enum Renderer2DDefaultMaterialType
		{
			Lit = 0,
			Unlit = 1,
			Custom = 2
		}

		[SerializeField]
		private TransparencySortMode m_TransparencySortMode;

		[SerializeField]
		private Vector3 m_TransparencySortAxis;

		[SerializeField]
		private float m_HDREmulationScale;

		[SerializeField]
		private Light2DBlendStyle[] m_LightBlendStyles;

		[SerializeField]
		private bool m_UseDepthStencilBuffer;

		[SerializeField]
		private Shader m_ShapeLightShader;

		[SerializeField]
		private Shader m_ShapeLightVolumeShader;

		[SerializeField]
		private Shader m_PointLightShader;

		[SerializeField]
		private Shader m_PointLightVolumeShader;

		[SerializeField]
		private Shader m_BlitShader;

		[SerializeField]
		private Shader m_ShadowGroupShader;

		[SerializeField]
		private Shader m_RemoveSelfShadowShader;

		[SerializeField]
		private PostProcessData m_PostProcessData;

		internal RenderTargetHandle normalsRenderTarget;

		internal RenderTargetHandle shadowsRenderTarget;

		public float hdrEmulationScale => 0f;

		public Light2DBlendStyle[] lightBlendStyles => null;

		internal bool useDepthStencilBuffer => false;

		internal Shader shapeLightShader => null;

		internal Shader shapeLightVolumeShader => null;

		internal Shader pointLightShader => null;

		internal Shader pointLightVolumeShader => null;

		internal Shader blitShader => null;

		internal Shader shadowGroupShader => null;

		internal Shader removeSelfShadowShader => null;

		internal PostProcessData postProcessData => null;

		internal TransparencySortMode transparencySortMode => default(TransparencySortMode);

		internal Vector3 transparencySortAxis => default(Vector3);

		internal Dictionary<uint, Material> lightMaterials { get; }

		internal Material[] shadowMaterials { get; private set; }

		internal Material[] removeSelfShadowMaterials { get; private set; }

		internal ILight2DCullResult lightCullResult { get; set; }

		protected override ScriptableRenderer Create()
		{
			return null;
		}

		protected override void OnEnable()
		{
		}
	}
}
