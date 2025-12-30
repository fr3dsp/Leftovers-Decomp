using System;

namespace UnityEngine.UI
{
	public static class LayoutUtility
	{
		public static float GetMinSize(RectTransform rect, int axis)
		{
			return 0f;
		}

		public static float GetPreferredSize(RectTransform rect, int axis)
		{
			return 0f;
		}

		public static float GetFlexibleSize(RectTransform rect, int axis)
		{
			return 0f;
		}

		public static float GetMinWidth(RectTransform rect)
		{
			return 0f;
		}

		public static float GetPreferredWidth(RectTransform rect)
		{
			return 0f;
		}

		public static float GetFlexibleWidth(RectTransform rect)
		{
			return 0f;
		}

		public static float GetMinHeight(RectTransform rect)
		{
			return 0f;
		}

		public static float GetPreferredHeight(RectTransform rect)
		{
			return 0f;
		}

		public static float GetFlexibleHeight(RectTransform rect)
		{
			return 0f;
		}

		public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue)
		{
			return 0f;
		}

		public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source)
		{
			source = null;
			return 0f;
		}
	}
}
