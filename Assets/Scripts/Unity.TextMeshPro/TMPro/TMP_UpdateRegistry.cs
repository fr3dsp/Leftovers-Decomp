using System.Collections.Generic;
using UnityEngine.UI;

namespace TMPro
{
	public class TMP_UpdateRegistry
	{
		private static TMP_UpdateRegistry s_Instance;

		private readonly List<ICanvasElement> m_LayoutRebuildQueue;

		private HashSet<int> m_LayoutQueueLookup;

		private readonly List<ICanvasElement> m_GraphicRebuildQueue;

		private HashSet<int> m_GraphicQueueLookup;

		public static TMP_UpdateRegistry instance => null;

		protected TMP_UpdateRegistry()
		{
		}

		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
		}

		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			return false;
		}

		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
		}

		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			return false;
		}

		private void PerformUpdateForCanvasRendererObjects()
		{
		}

		private void PerformUpdateForMeshRendererObjects()
		{
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
	}
}
