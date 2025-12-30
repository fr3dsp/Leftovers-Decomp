using System.Collections.Generic;

namespace TMPro
{
	public class TMP_ResourceManager
	{
		private static readonly TMP_ResourceManager s_instance;

		private static TMP_Settings s_TextSettings;

		private static readonly List<TMP_FontAsset> s_FontAssetReferences;

		private static readonly Dictionary<int, TMP_FontAsset> s_FontAssetReferenceLookup;

		static TMP_ResourceManager()
		{
		}

		internal static TMP_Settings GetTextSettings()
		{
			return null;
		}

		public static void AddFontAsset(TMP_FontAsset fontAsset)
		{
		}

		public static bool TryGetFontAsset(int hashcode, out TMP_FontAsset fontAsset)
		{
			fontAsset = null;
			return false;
		}

		internal static void RebuildFontAssetCache(int instanceID)
		{
		}
	}
}
