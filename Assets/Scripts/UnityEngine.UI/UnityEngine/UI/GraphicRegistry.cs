using System.Collections.Generic;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	public class GraphicRegistry
	{
		private static GraphicRegistry s_Instance;

		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics;

		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics;

		private static readonly List<Graphic> s_EmptyList;

		public static GraphicRegistry instance => null;

		protected GraphicRegistry()
		{
		}

		public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
		}

		public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas)
		{
			return null;
		}

		public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas)
		{
			return null;
		}
	}
}
