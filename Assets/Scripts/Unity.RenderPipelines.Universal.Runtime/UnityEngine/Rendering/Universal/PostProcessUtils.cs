using System;

namespace UnityEngine.Rendering.Universal
{
	public static class PostProcessUtils
	{
		private static class ShaderConstants
		{
			public static readonly int _Grain_Texture;

			public static readonly int _Grain_Params;

			public static readonly int _Grain_TilingParams;

			public static readonly int _BlueNoise_Texture;

			public static readonly int _Dithering_Params;

			public static readonly int _SourceSize;
		}

		[Obsolete]
		public static int ConfigureDithering(PostProcessData data, int index, Camera camera, Material material)
		{
			return 0;
		}

		public static int ConfigureDithering(PostProcessData data, int index, int cameraPixelWidth, int cameraPixelHeight, Material material)
		{
			return 0;
		}

		[Obsolete]
		public static void ConfigureFilmGrain(PostProcessData data, FilmGrain settings, Camera camera, Material material)
		{
		}

		public static void ConfigureFilmGrain(PostProcessData data, FilmGrain settings, int cameraPixelWidth, int cameraPixelHeight, Material material)
		{
		}

		internal static void SetSourceSize(CommandBuffer cmd, RenderTextureDescriptor desc)
		{
		}
	}
}
