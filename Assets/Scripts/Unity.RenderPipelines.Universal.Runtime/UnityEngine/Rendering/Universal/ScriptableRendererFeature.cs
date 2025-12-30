using System;

namespace UnityEngine.Rendering.Universal
{
	[ExcludeFromPreset]
	public abstract class ScriptableRendererFeature : ScriptableObject, IDisposable
	{
		[SerializeField]
		[HideInInspector]
		private bool m_Active;

		public bool isActive => false;

		public abstract void Create();

		public abstract void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData);

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		public void SetActive(bool active)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
