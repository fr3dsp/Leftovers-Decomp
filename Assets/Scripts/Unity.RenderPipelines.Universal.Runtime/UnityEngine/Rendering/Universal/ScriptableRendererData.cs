using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	public abstract class ScriptableRendererData : ScriptableObject
	{
		[SerializeField]
		internal List<ScriptableRendererFeature> m_RendererFeatures;

		[SerializeField]
		internal List<long> m_RendererFeatureMap;

		internal bool isInvalidated { get; set; }

		public List<ScriptableRendererFeature> rendererFeatures => null;

		protected abstract ScriptableRenderer Create();

		public void SetDirty()
		{
		}

		internal ScriptableRenderer InternalCreateRenderer()
		{
			return null;
		}

		protected virtual void OnValidate()
		{
		}

		protected virtual void OnEnable()
		{
		}
	}
}
