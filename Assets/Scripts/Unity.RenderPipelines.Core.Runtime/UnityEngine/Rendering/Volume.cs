namespace UnityEngine.Rendering
{
	[ExecuteAlways]
	public class Volume : MonoBehaviour
	{
		public bool isGlobal;

		public float priority;

		public float blendDistance;

		public float weight;

		public VolumeProfile sharedProfile;

		private int m_PreviousLayer;

		private float m_PreviousPriority;

		private VolumeProfile m_InternalProfile;

		public VolumeProfile profile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal VolumeProfile profileRef => null;

		public bool HasInstantiatedProfile()
		{
			return false;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		internal void UpdateLayer()
		{
		}
	}
}
