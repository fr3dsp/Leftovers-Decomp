using UnityEngine.Animations;

namespace UnityEngine.Experimental.Rendering.Universal
{
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public sealed class Light2D : MonoBehaviour
	{
		public enum LightType
		{
			Parametric = 0,
			Freeform = 1,
			Sprite = 2,
			Point = 3,
			Global = 4
		}

		public enum PointLightQuality
		{
			Fast = 0,
			Accurate = 1
		}

		[NotKeyable]
		[SerializeField]
		private LightType m_LightType;

		[SerializeField]
		private int m_BlendStyleIndex;

		[SerializeField]
		private float m_FalloffIntensity;

		[SerializeField]
		private Color m_Color;

		[SerializeField]
		private float m_Intensity;

		[SerializeField]
		private float m_LightVolumeOpacity;

		[SerializeField]
		private int[] m_ApplyToSortingLayers;

		[SerializeField]
		private Sprite m_LightCookieSprite;

		[SerializeField]
		private bool m_UseNormalMap;

		[SerializeField]
		private int m_LightOrder;

		[SerializeField]
		private bool m_AlphaBlendOnOverlap;

		[SerializeField]
		private float m_ShadowIntensity;

		[SerializeField]
		private float m_ShadowVolumeIntensity;

		private int m_PreviousLightCookieSprite;

		private Mesh m_Mesh;

		private Bounds m_LocalBounds;

		[SerializeField]
		private float m_PointLightInnerAngle;

		[SerializeField]
		private float m_PointLightOuterAngle;

		[SerializeField]
		private float m_PointLightInnerRadius;

		[SerializeField]
		private float m_PointLightOuterRadius;

		[SerializeField]
		private float m_PointLightDistance;

		[NotKeyable]
		[SerializeField]
		private PointLightQuality m_PointLightQuality;

		[SerializeField]
		private int m_ShapeLightParametricSides;

		[SerializeField]
		private float m_ShapeLightParametricAngleOffset;

		[SerializeField]
		private float m_ShapeLightParametricRadius;

		[SerializeField]
		private float m_ShapeLightFalloffSize;

		[SerializeField]
		private Vector2 m_ShapeLightFalloffOffset;

		[SerializeField]
		private Vector3[] m_ShapePath;

		private float m_PreviousShapeLightFalloffSize;

		private int m_PreviousShapeLightParametricSides;

		private float m_PreviousShapeLightParametricAngleOffset;

		private float m_PreviousShapeLightParametricRadius;

		internal int[] affectedSortingLayers => null;

		private int lightCookieSpriteInstanceID => 0;

		internal BoundingSphere boundingSphere { get; private set; }

		internal Mesh lightMesh => null;

		public LightType lightType
		{
			get
			{
				return default(LightType);
			}
			set
			{
			}
		}

		public int blendStyleIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float shadowIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float shadowVolumeIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float intensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float volumeOpacity => 0f;

		public Sprite lightCookieSprite => null;

		public float falloffIntensity => 0f;

		public bool useNormalMap => false;

		public bool alphaBlendOnOverlap => false;

		public int lightOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float pointLightInnerAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float pointLightOuterAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float pointLightInnerRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float pointLightOuterRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float pointLightDistance => 0f;

		public PointLightQuality pointLightQuality => default(PointLightQuality);

		internal bool isPointLight => false;

		public int shapeLightParametricSides => 0;

		public float shapeLightParametricAngleOffset => 0f;

		public float shapeLightParametricRadius => 0f;

		public float shapeLightFalloffSize => 0f;

		public Vector2 shapeLightFalloffOffset => default(Vector2);

		public Vector3[] shapePath => null;

		internal int GetTopMostLitLayer()
		{
			return 0;
		}

		internal void UpdateMesh()
		{
		}

		internal void UpdateBoundingSphere()
		{
		}

		internal bool IsLitLayer(int layer)
		{
			return false;
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
