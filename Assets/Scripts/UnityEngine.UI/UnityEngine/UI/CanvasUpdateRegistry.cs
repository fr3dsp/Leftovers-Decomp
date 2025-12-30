using System;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	public class CanvasUpdateRegistry
	{
		private static CanvasUpdateRegistry s_Instance;

		private bool m_PerformingLayoutUpdate;

		private bool m_PerformingGraphicUpdate;

		private string[] m_CanvasUpdateProfilerStrings;

		private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull";

		private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue;

		private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue;

		private static readonly Comparison<ICanvasElement> s_SortLayoutFunction;

		public static CanvasUpdateRegistry instance => null;

		protected CanvasUpdateRegistry()
		{
		}

		private bool ObjectValidForUpdate(ICanvasElement element)
		{
			return false;
		}

		private void CleanInvalidItems()
		{
		}

		private void PerformUpdate()
		{
		}

		private static int ParentCount(Transform child)
		{
			return 0;
		}

		private static int SortLayoutList(ICanvasElement x, ICanvasElement y)
		{
			return 0;
		}

		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
		}

		public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			return false;
		}

		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			return false;
		}

		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
		}

		public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			return false;
		}

		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			return false;
		}

		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element)
		{
		}

		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
		}

		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
		}

		public static bool IsRebuildingLayout()
		{
			return false;
		}

		public static bool IsRebuildingGraphics()
		{
			return false;
		}
	}
}
