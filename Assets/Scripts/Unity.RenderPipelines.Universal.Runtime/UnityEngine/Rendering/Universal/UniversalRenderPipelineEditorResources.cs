using System;

namespace UnityEngine.Rendering.Universal
{
	public class UniversalRenderPipelineEditorResources : ScriptableObject
	{
		[Serializable]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			public Shader autodeskInteractivePS;

			public Shader autodeskInteractiveTransparentPS;

			public Shader autodeskInteractiveMaskedPS;

			public Shader terrainDetailLitPS;

			public Shader terrainDetailGrassPS;

			public Shader terrainDetailGrassBillboardPS;

			public Shader defaultSpeedTree7PS;

			public Shader defaultSpeedTree8PS;
		}

		[Serializable]
		[ReloadGroup]
		public sealed class MaterialResources
		{
			public Material lit;

			public Material particleLit;

			public Material terrainLit;
		}

		public ShaderResources shaders;

		public MaterialResources materials;
	}
}
