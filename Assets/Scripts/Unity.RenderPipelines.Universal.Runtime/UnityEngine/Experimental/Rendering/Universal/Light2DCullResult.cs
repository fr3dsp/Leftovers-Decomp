using System.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.Universal
{
	internal class Light2DCullResult : ILight2DCullResult
	{
		private List<Light2D> m_VisibleLights;

		public List<Light2D> visibleLights => null;

		public bool IsSceneLit()
		{
			return false;
		}

		public LightStats GetLightStatsByLayer(int layer)
		{
			return default(LightStats);
		}

		public void SetupCulling(ref ScriptableCullingParameters cullingParameters, Camera camera)
		{
		}
	}
}
