using System;

namespace UnityEngine.Rendering.LookDev
{
	public class StageRuntimeInterface
	{
		private Func<bool, GameObject> m_AddGameObject;

		private Func<Camera> m_GetCamera;

		private Func<Light> m_GetSunLight;

		public object SRPData;

		public Camera camera => null;

		public Light sunLight => null;

		public StageRuntimeInterface(Func<bool, GameObject> AddGameObject, Func<Camera> GetCamera, Func<Light> GetSunLight)
		{
		}

		public GameObject AddGameObject(bool persistent = false)
		{
			return null;
		}
	}
}
