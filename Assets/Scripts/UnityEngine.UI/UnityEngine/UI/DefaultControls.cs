using System;

namespace UnityEngine.UI
{
	public static class DefaultControls
	{
		public interface IFactoryControls
		{
			GameObject CreateGameObject(string name, params Type[] components);
		}

		private class DefaultRuntimeFactory : IFactoryControls
		{
			public static IFactoryControls Default;

			public GameObject CreateGameObject(string name, params Type[] components)
			{
				return null;
			}
		}

		public struct Resources
		{
			public Sprite standard;

			public Sprite background;

			public Sprite inputField;

			public Sprite knob;

			public Sprite checkmark;

			public Sprite dropdown;

			public Sprite mask;
		}

		private static IFactoryControls m_CurrentFactory;

		private const float kWidth = 160f;

		private const float kThickHeight = 30f;

		private const float kThinHeight = 20f;

		private static Vector2 s_ThickElementSize;

		private static Vector2 s_ThinElementSize;

		private static Vector2 s_ImageElementSize;

		private static Color s_DefaultSelectableColor;

		private static Color s_PanelColor;

		private static Color s_TextColor;

		public static IFactoryControls factory => null;

		private static GameObject CreateUIElementRoot(string name, Vector2 size, params Type[] components)
		{
			return null;
		}

		private static GameObject CreateUIObject(string name, GameObject parent, params Type[] components)
		{
			return null;
		}

		private static void SetDefaultTextValues(Text lbl)
		{
		}

		private static void SetDefaultColorTransitionValues(Selectable slider)
		{
		}

		private static void SetParentAndAlign(GameObject child, GameObject parent)
		{
		}

		private static void SetLayerRecursively(GameObject go, int layer)
		{
		}

		public static GameObject CreatePanel(Resources resources)
		{
			return null;
		}

		public static GameObject CreateButton(Resources resources)
		{
			return null;
		}

		public static GameObject CreateText(Resources resources)
		{
			return null;
		}

		public static GameObject CreateImage(Resources resources)
		{
			return null;
		}

		public static GameObject CreateRawImage(Resources resources)
		{
			return null;
		}

		public static GameObject CreateSlider(Resources resources)
		{
			return null;
		}

		public static GameObject CreateScrollbar(Resources resources)
		{
			return null;
		}

		public static GameObject CreateToggle(Resources resources)
		{
			return null;
		}

		public static GameObject CreateInputField(Resources resources)
		{
			return null;
		}

		public static GameObject CreateDropdown(Resources resources)
		{
			return null;
		}

		public static GameObject CreateScrollView(Resources resources)
		{
			return null;
		}
	}
}
