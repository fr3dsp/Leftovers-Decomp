using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	public class MaterialReferenceManager
	{
		private static MaterialReferenceManager s_Instance;

		private Dictionary<int, Material> m_FontMaterialReferenceLookup;

		private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup;

		private Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup;

		private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup;

		public static MaterialReferenceManager instance => null;

		public static void AddFontAsset(TMP_FontAsset fontAsset)
		{
		}

		private void AddFontAssetInternal(TMP_FontAsset fontAsset)
		{
		}

		public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset)
		{
		}

		private void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset)
		{
		}

		public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset)
		{
		}

		private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset)
		{
		}

		public static void AddFontMaterial(int hashCode, Material material)
		{
		}

		private void AddFontMaterialInternal(int hashCode, Material material)
		{
		}

		public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset)
		{
		}

		private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset)
		{
		}

		public bool Contains(TMP_FontAsset font)
		{
			return false;
		}

		public bool Contains(TMP_SpriteAsset sprite)
		{
			return false;
		}

		public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset)
		{
			fontAsset = null;
			return false;
		}

		private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset)
		{
			fontAsset = null;
			return false;
		}

		public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset)
		{
			spriteAsset = null;
			return false;
		}

		private bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset)
		{
			spriteAsset = null;
			return false;
		}

		public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset)
		{
			gradientPreset = null;
			return false;
		}

		private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset)
		{
			gradientPreset = null;
			return false;
		}

		public static bool TryGetMaterial(int hashCode, out Material material)
		{
			material = null;
			return false;
		}

		private bool TryGetMaterialInternal(int hashCode, out Material material)
		{
			material = null;
			return false;
		}
	}
}
