using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public class PostProcessData : ScriptableObject
	{
		[Serializable]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			public Shader stopNanPS;

			public Shader subpixelMorphologicalAntialiasingPS;

			public Shader gaussianDepthOfFieldPS;

			public Shader bokehDepthOfFieldPS;

			public Shader cameraMotionBlurPS;

			public Shader paniniProjectionPS;

			public Shader lutBuilderLdrPS;

			public Shader lutBuilderHdrPS;

			public Shader bloomPS;

			public Shader uberPostPS;

			public Shader finalPostPassPS;
		}

		[Serializable]
		[ReloadGroup]
		public sealed class TextureResources
		{
			public Texture2D[] blueNoise16LTex;

			public Texture2D[] filmGrainTex;

			public Texture2D smaaAreaTex;

			public Texture2D smaaSearchTex;
		}

		public ShaderResources shaders;

		public TextureResources textures;
	}
}
