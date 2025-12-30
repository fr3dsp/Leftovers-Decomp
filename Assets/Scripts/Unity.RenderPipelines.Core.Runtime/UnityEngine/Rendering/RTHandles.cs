using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	public static class RTHandles
	{
		private static RTHandleSystem s_DefaultInstance;

		public static int maxWidth => 0;

		public static int maxHeight => 0;

		public static RTHandleProperties rtHandleProperties => default(RTHandleProperties);

		public static RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, string name = "")
		{
			return null;
		}

		public static RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, bool enableMSAA = false, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, string name = "")
		{
			return null;
		}

		public static RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, bool enableMSAA = false, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, string name = "")
		{
			return null;
		}

		public static RTHandle Alloc(Texture tex)
		{
			return null;
		}

		public static RTHandle Alloc(RenderTexture tex)
		{
			return null;
		}

		public static RTHandle Alloc(RenderTargetIdentifier tex)
		{
			return null;
		}

		public static RTHandle Alloc(RenderTargetIdentifier tex, string name)
		{
			return null;
		}

		private static RTHandle Alloc(RTHandle tex)
		{
			return null;
		}

		public static void Initialize(int width, int height, bool scaledRTsupportsMSAA, MSAASamples scaledRTMSAASamples)
		{
		}

		public static void Release(RTHandle rth)
		{
		}

		public static void SetHardwareDynamicResolutionState(bool hwDynamicResRequested)
		{
		}

		public static void SetReferenceSize(int width, int height, MSAASamples msaaSamples)
		{
		}

		public static void ResetReferenceSize(int width, int height)
		{
		}
	}
}
