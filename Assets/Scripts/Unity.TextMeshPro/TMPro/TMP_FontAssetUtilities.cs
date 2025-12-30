using System.Collections.Generic;

namespace TMPro
{
	public class TMP_FontAssetUtilities
	{
		private static readonly TMP_FontAssetUtilities s_Instance;

		private static HashSet<int> k_SearchedAssets;

		private static bool k_IsFontEngineInitialized;

		public static TMP_FontAssetUtilities instance => null;

		static TMP_FontAssetUtilities()
		{
		}

		public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
		{
			isAlternativeTypeface = default(bool);
			return null;
		}

		private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
		{
			isAlternativeTypeface = default(bool);
			return null;
		}

		public static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
		{
			isAlternativeTypeface = default(bool);
			return null;
		}

		public static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks)
		{
			return null;
		}

		private static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks)
		{
			return null;
		}
	}
}
