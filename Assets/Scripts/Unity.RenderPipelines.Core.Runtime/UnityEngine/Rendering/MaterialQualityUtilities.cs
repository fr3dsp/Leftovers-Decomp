namespace UnityEngine.Rendering
{
	public static class MaterialQualityUtilities
	{
		public static string[] KeywordNames;

		public static string[] EnumNames;

		public static ShaderKeyword[] Keywords;

		public static MaterialQuality GetHighestQuality(this MaterialQuality levels)
		{
			return default(MaterialQuality);
		}

		public static MaterialQuality GetClosestQuality(this MaterialQuality availableLevels, MaterialQuality requestedLevel)
		{
			return default(MaterialQuality);
		}

		public static void SetGlobalShaderKeywords(this MaterialQuality level)
		{
		}

		public static void SetGlobalShaderKeywords(this MaterialQuality level, CommandBuffer cmd)
		{
		}

		public static int ToFirstIndex(this MaterialQuality level)
		{
			return 0;
		}

		public static MaterialQuality FromIndex(int index)
		{
			return default(MaterialQuality);
		}
	}
}
