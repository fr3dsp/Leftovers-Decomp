using System;

namespace UnityEngine.Rendering.Universal
{
	[ExcludeFromPreset]
	public class UniversalRenderPipelineAsset : RenderPipelineAsset, ISerializationCallbackReceiver
	{
		private Shader m_DefaultShader;

		private ScriptableRenderer[] m_Renderers;

		[SerializeField]
		private int k_AssetVersion;

		[SerializeField]
		private int k_AssetPreviousVersion;

		[SerializeField]
		private RendererType m_RendererType;

		[SerializeField]
		internal ScriptableRendererData m_RendererData;

		[SerializeField]
		internal ScriptableRendererData[] m_RendererDataList;

		[SerializeField]
		internal int m_DefaultRendererIndex;

		[SerializeField]
		private bool m_RequireDepthTexture;

		[SerializeField]
		private bool m_RequireOpaqueTexture;

		[SerializeField]
		private Downsampling m_OpaqueDownsampling;

		[SerializeField]
		private bool m_SupportsTerrainHoles;

		[SerializeField]
		private bool m_SupportsHDR;

		[SerializeField]
		private MsaaQuality m_MSAA;

		[SerializeField]
		private float m_RenderScale;

		[SerializeField]
		private LightRenderingMode m_MainLightRenderingMode;

		[SerializeField]
		private bool m_MainLightShadowsSupported;

		[SerializeField]
		private ShadowResolution m_MainLightShadowmapResolution;

		[SerializeField]
		private LightRenderingMode m_AdditionalLightsRenderingMode;

		[SerializeField]
		private int m_AdditionalLightsPerObjectLimit;

		[SerializeField]
		private bool m_AdditionalLightShadowsSupported;

		[SerializeField]
		private ShadowResolution m_AdditionalLightsShadowmapResolution;

		[SerializeField]
		private float m_ShadowDistance;

		[SerializeField]
		private int m_ShadowCascadeCount;

		[SerializeField]
		private float m_Cascade2Split;

		[SerializeField]
		private Vector2 m_Cascade3Split;

		[SerializeField]
		private Vector3 m_Cascade4Split;

		[SerializeField]
		private float m_ShadowDepthBias;

		[SerializeField]
		private float m_ShadowNormalBias;

		[SerializeField]
		private bool m_SoftShadowsSupported;

		[SerializeField]
		private bool m_UseSRPBatcher;

		[SerializeField]
		private bool m_SupportsDynamicBatching;

		[SerializeField]
		private bool m_MixedLightingSupported;

		[SerializeField]
		[Obsolete]
		private PipelineDebugLevel m_DebugLevel;

		[SerializeField]
		private bool m_UseAdaptivePerformance;

		[SerializeField]
		private ColorGradingMode m_ColorGradingMode;

		[SerializeField]
		private int m_ColorGradingLutSize;

		[SerializeField]
		private ShadowQuality m_ShadowType;

		[SerializeField]
		private bool m_LocalShadowsSupported;

		[SerializeField]
		private ShadowResolution m_LocalShadowsAtlasResolution;

		[SerializeField]
		private int m_MaxPixelLights;

		[SerializeField]
		private ShadowResolution m_ShadowAtlasResolution;

		[SerializeField]
		private ShaderVariantLogLevel m_ShaderVariantLogLevel;

		public const int k_MinLutSize = 16;

		public const int k_MaxLutSize = 65;

		internal const int k_ShadowCascadeMinCount = 1;

		internal const int k_ShadowCascadeMaxCount = 4;

		[Obsolete]
		[SerializeField]
		private ShadowCascadesOption m_ShadowCascades;

		public ScriptableRenderer scriptableRenderer => null;

		internal ScriptableRendererData scriptableRendererData => null;

		internal int[] rendererIndexList => null;

		public bool supportsCameraDepthTexture
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool supportsCameraOpaqueTexture
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Downsampling opaqueDownsampling => default(Downsampling);

		public bool supportsTerrainHoles => false;

		public bool supportsHDR
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int msaaSampleCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float renderScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public LightRenderingMode mainLightRenderingMode => default(LightRenderingMode);

		public bool supportsMainLightShadows => false;

		public int mainLightShadowmapResolution => 0;

		public LightRenderingMode additionalLightsRenderingMode => default(LightRenderingMode);

		public int maxAdditionalLightsCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool supportsAdditionalLightShadows => false;

		public int additionalLightsShadowmapResolution => 0;

		public float shadowDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int shadowCascadeCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float cascade2Split => 0f;

		public Vector2 cascade3Split => default(Vector2);

		public Vector3 cascade4Split => default(Vector3);

		public float shadowDepthBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float shadowNormalBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool supportsSoftShadows => false;

		public bool supportsDynamicBatching
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool supportsMixedLighting => false;

		public ShaderVariantLogLevel shaderVariantLogLevel
		{
			get
			{
				return default(ShaderVariantLogLevel);
			}
			set
			{
			}
		}

		[Obsolete]
		public PipelineDebugLevel debugLevel => default(PipelineDebugLevel);

		public bool useSRPBatcher
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ColorGradingMode colorGradingMode
		{
			get
			{
				return default(ColorGradingMode);
			}
			set
			{
			}
		}

		public int colorGradingLutSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool useAdaptivePerformance
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override Material defaultMaterial => null;

		public override Material defaultParticleMaterial => null;

		public override Material defaultLineMaterial => null;

		public override Material defaultTerrainMaterial => null;

		public override Material defaultUIMaterial => null;

		public override Material defaultUIOverdrawMaterial => null;

		public override Material defaultUIETC1SupportedMaterial => null;

		public override Material default2DMaterial => null;

		public override Shader defaultShader => null;

		[Obsolete]
		public ShadowCascadesOption shadowCascadeOption
		{
			get
			{
				return default(ShadowCascadesOption);
			}
			set
			{
			}
		}

		public ScriptableRendererData LoadBuiltinRendererData(RendererType type = RendererType.ForwardRenderer)
		{
			return null;
		}

		protected override RenderPipeline CreatePipeline()
		{
			return null;
		}

		private void DestroyRenderers()
		{
		}

		private void DestroyRenderer(ref ScriptableRenderer renderer)
		{
		}

		protected override void OnValidate()
		{
		}

		protected override void OnDisable()
		{
		}

		private void CreateRenderers()
		{
		}

		private Material GetMaterial(DefaultMaterialType materialType)
		{
			return null;
		}

		public ScriptableRenderer GetRenderer(int index)
		{
			return null;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		private float ValidateShadowBias(float value)
		{
			return 0f;
		}

		private int ValidatePerObjectLights(int value)
		{
			return 0;
		}

		private float ValidateRenderScale(float value)
		{
			return 0f;
		}

		internal bool ValidateRendererDataList(bool partial = false)
		{
			return false;
		}

		internal bool ValidateRendererData(int index)
		{
			return false;
		}
	}
}
