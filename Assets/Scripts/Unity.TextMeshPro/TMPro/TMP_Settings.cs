using System;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	[ExcludeFromPreset]
	public class TMP_Settings : ScriptableObject
	{
		public class LineBreakingTable
		{
			public Dictionary<int, char> leadingCharacters;

			public Dictionary<int, char> followingCharacters;
		}

		private static TMP_Settings s_Instance;

		[SerializeField]
		private bool m_enableWordWrapping;

		[SerializeField]
		private bool m_enableKerning;

		[SerializeField]
		private bool m_enableExtraPadding;

		[SerializeField]
		private bool m_enableTintAllSprites;

		[SerializeField]
		private bool m_enableParseEscapeCharacters;

		[SerializeField]
		private bool m_EnableRaycastTarget;

		[SerializeField]
		private bool m_GetFontFeaturesAtRuntime;

		[SerializeField]
		private int m_missingGlyphCharacter;

		[SerializeField]
		private bool m_warningsDisabled;

		[SerializeField]
		private TMP_FontAsset m_defaultFontAsset;

		[SerializeField]
		private string m_defaultFontAssetPath;

		[SerializeField]
		private float m_defaultFontSize;

		[SerializeField]
		private float m_defaultAutoSizeMinRatio;

		[SerializeField]
		private float m_defaultAutoSizeMaxRatio;

		[SerializeField]
		private Vector2 m_defaultTextMeshProTextContainerSize;

		[SerializeField]
		private Vector2 m_defaultTextMeshProUITextContainerSize;

		[SerializeField]
		private bool m_autoSizeTextContainer;

		[SerializeField]
		private bool m_IsTextObjectScaleStatic;

		[SerializeField]
		private List<TMP_FontAsset> m_fallbackFontAssets;

		[SerializeField]
		private bool m_matchMaterialPreset;

		[SerializeField]
		private TMP_SpriteAsset m_defaultSpriteAsset;

		[SerializeField]
		private string m_defaultSpriteAssetPath;

		[SerializeField]
		private bool m_enableEmojiSupport;

		[SerializeField]
		private uint m_MissingCharacterSpriteUnicode;

		[SerializeField]
		private string m_defaultColorGradientPresetsPath;

		[SerializeField]
		private TMP_StyleSheet m_defaultStyleSheet;

		[SerializeField]
		private string m_StyleSheetsResourcePath;

		[SerializeField]
		private TextAsset m_leadingCharacters;

		[SerializeField]
		private TextAsset m_followingCharacters;

		[SerializeField]
		private LineBreakingTable m_linebreakingRules;

		[SerializeField]
		private bool m_UseModernHangulLineBreakingRules;

		public static string version => null;

		public static bool enableWordWrapping => false;

		public static bool enableKerning => false;

		public static bool enableExtraPadding => false;

		public static bool enableTintAllSprites => false;

		public static bool enableParseEscapeCharacters => false;

		public static bool enableRaycastTarget => false;

		public static bool getFontFeaturesAtRuntime => false;

		public static int missingGlyphCharacter
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool warningsDisabled => false;

		public static TMP_FontAsset defaultFontAsset => null;

		public static string defaultFontAssetPath => null;

		public static float defaultFontSize => 0f;

		public static float defaultTextAutoSizingMinRatio => 0f;

		public static float defaultTextAutoSizingMaxRatio => 0f;

		public static Vector2 defaultTextMeshProTextContainerSize => default(Vector2);

		public static Vector2 defaultTextMeshProUITextContainerSize => default(Vector2);

		public static bool autoSizeTextContainer => false;

		public static bool isTextObjectScaleStatic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static List<TMP_FontAsset> fallbackFontAssets => null;

		public static bool matchMaterialPreset => false;

		public static TMP_SpriteAsset defaultSpriteAsset => null;

		public static string defaultSpriteAssetPath => null;

		public static bool enableEmojiSupport
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static uint missingCharacterSpriteUnicode
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public static string defaultColorGradientPresetsPath => null;

		public static TMP_StyleSheet defaultStyleSheet => null;

		public static string styleSheetsResourcePath => null;

		public static TextAsset leadingCharacters => null;

		public static TextAsset followingCharacters => null;

		public static LineBreakingTable linebreakingRules => null;

		public static bool useModernHangulLineBreakingRules
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static TMP_Settings instance => null;

		public static TMP_Settings LoadDefaultSettings()
		{
			return null;
		}

		public static TMP_Settings GetSettings()
		{
			return null;
		}

		public static TMP_FontAsset GetFontAsset()
		{
			return null;
		}

		public static TMP_SpriteAsset GetSpriteAsset()
		{
			return null;
		}

		public static TMP_StyleSheet GetStyleSheet()
		{
			return null;
		}

		public static void LoadLinebreakingRules()
		{
		}

		private static Dictionary<int, char> GetCharacters(TextAsset file)
		{
			return null;
		}
	}
}
