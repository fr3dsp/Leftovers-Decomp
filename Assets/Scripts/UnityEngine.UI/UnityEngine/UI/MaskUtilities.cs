using System.Collections.Generic;

namespace UnityEngine.UI
{
	public class MaskUtilities
	{
		public static void Notify2DMaskStateChanged(Component mask)
		{
		}

		public static void NotifyStencilStateChanged(Component mask)
		{
		}

		public static Transform FindRootSortOverrideCanvas(Transform start)
		{
			return null;
		}

		public static int GetStencilDepth(Transform transform, Transform stopAfter)
		{
			return 0;
		}

		public static bool IsDescendantOrSelf(Transform father, Transform child)
		{
			return false;
		}

		public static RectMask2D GetRectMaskForClippable(IClippable clippable)
		{
			return null;
		}

		public static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks)
		{
		}
	}
}
