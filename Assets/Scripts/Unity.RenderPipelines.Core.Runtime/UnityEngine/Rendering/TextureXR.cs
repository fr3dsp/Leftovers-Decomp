namespace UnityEngine.Rendering
{
	public static class TextureXR
	{
		private static int m_MaxViews;

		private static Texture m_BlackUIntTexture2DArray;

		private static Texture m_BlackUIntTexture;

		private static RTHandle m_BlackUIntTexture2DArrayRTH;

		private static RTHandle m_BlackUIntTextureRTH;

		private static Texture2DArray m_ClearTexture2DArray;

		private static Texture2D m_ClearTexture;

		private static RTHandle m_ClearTexture2DArrayRTH;

		private static RTHandle m_ClearTextureRTH;

		private static Texture2DArray m_MagentaTexture2DArray;

		private static Texture2D m_MagentaTexture;

		private static RTHandle m_MagentaTexture2DArrayRTH;

		private static RTHandle m_MagentaTextureRTH;

		private static Texture3D m_BlackTexture3D;

		private static Texture2DArray m_BlackTexture2DArray;

		private static RTHandle m_BlackTexture2DArrayRTH;

		private static RTHandle m_BlackTextureRTH;

		private static RTHandle m_BlackTexture3DRTH;

		private static Texture2DArray m_WhiteTexture2DArray;

		private static RTHandle m_WhiteTexture2DArrayRTH;

		private static RTHandle m_WhiteTextureRTH;

		public static int maxViews
		{
			set
			{
			}
		}

		public static int slices => 0;

		public static bool useTexArray => false;

		public static TextureDimension dimension => default(TextureDimension);

		public static RTHandle GetBlackUIntTexture()
		{
			return null;
		}

		public static RTHandle GetClearTexture()
		{
			return null;
		}

		public static RTHandle GetMagentaTexture()
		{
			return null;
		}

		public static RTHandle GetBlackTexture()
		{
			return null;
		}

		public static RTHandle GetBlackTextureArray()
		{
			return null;
		}

		public static RTHandle GetBlackTexture3D()
		{
			return null;
		}

		public static RTHandle GetWhiteTexture()
		{
			return null;
		}

		public static void Initialize(CommandBuffer cmd, ComputeShader clearR32_UIntShader)
		{
		}

		private static Texture2DArray CreateTexture2DArrayFromTexture2D(Texture2D source, string name)
		{
			return null;
		}

		private static Texture CreateBlackUIntTextureArray(CommandBuffer cmd, ComputeShader clearR32_UIntShader)
		{
			return null;
		}

		private static Texture CreateBlackUintTexture(CommandBuffer cmd, ComputeShader clearR32_UIntShader)
		{
			return null;
		}

		private static Texture3D CreateBlackTexture3D(string name)
		{
			return null;
		}
	}
}
