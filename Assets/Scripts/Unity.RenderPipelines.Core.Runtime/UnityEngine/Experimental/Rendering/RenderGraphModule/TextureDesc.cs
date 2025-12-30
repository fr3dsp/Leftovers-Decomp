using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	public struct TextureDesc
	{
		public TextureSizeMode sizeMode;

		public int width;

		public int height;

		public int slices;

		public Vector2 scale;

		public ScaleFunc func;

		public DepthBits depthBufferBits;

		public GraphicsFormat colorFormat;

		public FilterMode filterMode;

		public TextureWrapMode wrapMode;

		public TextureDimension dimension;

		public bool enableRandomWrite;

		public bool useMipMap;

		public bool autoGenerateMips;

		public bool isShadowMap;

		public int anisoLevel;

		public float mipMapBias;

		public bool enableMSAA;

		public MSAASamples msaaSamples;

		public bool bindTextureMS;

		public bool useDynamicScale;

		public RenderTextureMemoryless memoryless;

		public string name;

		public FastMemoryDesc fastMemoryDesc;

		public bool fallBackToBlackTexture;

		public bool clearBuffer;

		public Color clearColor;

		private void InitDefaultValues(bool dynamicResolution, bool xrReady)
		{
		}

		public TextureDesc(int width, int height, bool dynamicResolution = false, bool xrReady = false)
		{
			sizeMode = default(TextureSizeMode);
			this.width = 0;
			this.height = 0;
			slices = 0;
			scale = default(Vector2);
			func = null;
			depthBufferBits = default(DepthBits);
			colorFormat = default(GraphicsFormat);
			filterMode = default(FilterMode);
			wrapMode = default(TextureWrapMode);
			dimension = default(TextureDimension);
			enableRandomWrite = false;
			useMipMap = false;
			autoGenerateMips = false;
			isShadowMap = false;
			anisoLevel = 0;
			mipMapBias = 0f;
			enableMSAA = false;
			msaaSamples = default(MSAASamples);
			bindTextureMS = false;
			useDynamicScale = false;
			memoryless = default(RenderTextureMemoryless);
			name = null;
			fastMemoryDesc = default(FastMemoryDesc);
			fallBackToBlackTexture = false;
			clearBuffer = false;
			clearColor = default(Color);
		}

		public TextureDesc(Vector2 scale, bool dynamicResolution = false, bool xrReady = false)
		{
			sizeMode = default(TextureSizeMode);
			width = 0;
			height = 0;
			slices = 0;
			this.scale = default(Vector2);
			func = null;
			depthBufferBits = default(DepthBits);
			colorFormat = default(GraphicsFormat);
			filterMode = default(FilterMode);
			wrapMode = default(TextureWrapMode);
			dimension = default(TextureDimension);
			enableRandomWrite = false;
			useMipMap = false;
			autoGenerateMips = false;
			isShadowMap = false;
			anisoLevel = 0;
			mipMapBias = 0f;
			enableMSAA = false;
			msaaSamples = default(MSAASamples);
			bindTextureMS = false;
			useDynamicScale = false;
			memoryless = default(RenderTextureMemoryless);
			name = null;
			fastMemoryDesc = default(FastMemoryDesc);
			fallBackToBlackTexture = false;
			clearBuffer = false;
			clearColor = default(Color);
		}

		public TextureDesc(ScaleFunc func, bool dynamicResolution = false, bool xrReady = false)
		{
			sizeMode = default(TextureSizeMode);
			width = 0;
			height = 0;
			slices = 0;
			scale = default(Vector2);
			this.func = null;
			depthBufferBits = default(DepthBits);
			colorFormat = default(GraphicsFormat);
			filterMode = default(FilterMode);
			wrapMode = default(TextureWrapMode);
			dimension = default(TextureDimension);
			enableRandomWrite = false;
			useMipMap = false;
			autoGenerateMips = false;
			isShadowMap = false;
			anisoLevel = 0;
			mipMapBias = 0f;
			enableMSAA = false;
			msaaSamples = default(MSAASamples);
			bindTextureMS = false;
			useDynamicScale = false;
			memoryless = default(RenderTextureMemoryless);
			name = null;
			fastMemoryDesc = default(FastMemoryDesc);
			fallBackToBlackTexture = false;
			clearBuffer = false;
			clearColor = default(Color);
		}

		public TextureDesc(TextureDesc input)
		{
			sizeMode = default(TextureSizeMode);
			width = 0;
			height = 0;
			slices = 0;
			scale = default(Vector2);
			func = null;
			depthBufferBits = default(DepthBits);
			colorFormat = default(GraphicsFormat);
			filterMode = default(FilterMode);
			wrapMode = default(TextureWrapMode);
			dimension = default(TextureDimension);
			enableRandomWrite = false;
			useMipMap = false;
			autoGenerateMips = false;
			isShadowMap = false;
			anisoLevel = 0;
			mipMapBias = 0f;
			enableMSAA = false;
			msaaSamples = default(MSAASamples);
			bindTextureMS = false;
			useDynamicScale = false;
			memoryless = default(RenderTextureMemoryless);
			name = null;
			fastMemoryDesc = default(FastMemoryDesc);
			fallBackToBlackTexture = false;
			clearBuffer = false;
			clearColor = default(Color);
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
