namespace UnityEngine.Experimental.Rendering.Universal
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class ShadowCaster2D : ShadowCasterGroup2D
	{
		[SerializeField]
		private bool m_HasRenderer;

		[SerializeField]
		private bool m_UseRendererSilhouette;

		[SerializeField]
		private bool m_CastsShadows;

		[SerializeField]
		private bool m_SelfShadows;

		[SerializeField]
		private int[] m_ApplyToSortingLayers;

		[SerializeField]
		private Vector3[] m_ShapePath;

		[SerializeField]
		private int m_ShapePathHash;

		[SerializeField]
		private Mesh m_Mesh;

		[SerializeField]
		private int m_InstanceId;

		internal ShadowCasterGroup2D m_ShadowCasterGroup;

		internal ShadowCasterGroup2D m_PreviousShadowCasterGroup;

		private int m_PreviousShadowGroup;

		private bool m_PreviousCastsShadows;

		private int m_PreviousPathHash;

		internal Mesh mesh => null;

		internal Vector3[] shapePath => null;

		internal int shapePathHash
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool useRendererSilhouette
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool selfShadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool castsShadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private static int[] SetDefaultSortingLayers()
		{
			return null;
		}

		internal bool IsShadowedLayer(int layer)
		{
			return false;
		}

		private void Awake()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		public void Update()
		{
		}
	}
}
