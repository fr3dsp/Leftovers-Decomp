using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public class XRSystemData : ScriptableObject
	{
		[Serializable]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			public Shader xrOcclusionMeshPS;

			public Shader xrMirrorViewPS;
		}

		public ShaderResources shaders;
	}
}
