using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	internal static class MultipleDisplayUtilities
	{
		public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position)
		{
			return false;
		}

		public static Vector2 GetMousePositionRelativeToMainDisplayResolution()
		{
			return default(Vector2);
		}
	}
}
