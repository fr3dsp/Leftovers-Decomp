using System.Collections.Generic;

namespace UnityEngine.Experimental.Rendering.Universal
{
	public abstract class ShadowCasterGroup2D : MonoBehaviour
	{
		[SerializeField]
		internal int m_ShadowGroup;

		private List<ShadowCaster2D> m_ShadowCasters;

		public List<ShadowCaster2D> GetShadowCasters()
		{
			return null;
		}

		public int GetShadowGroup()
		{
			return 0;
		}

		public void RegisterShadowCaster2D(ShadowCaster2D shadowCaster2D)
		{
		}

		public void UnregisterShadowCaster2D(ShadowCaster2D shadowCaster2D)
		{
		}
	}
}
