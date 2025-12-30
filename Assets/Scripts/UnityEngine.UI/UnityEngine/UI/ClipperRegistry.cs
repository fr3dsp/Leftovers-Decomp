using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	public class ClipperRegistry
	{
		private static ClipperRegistry s_Instance;

		private readonly IndexedSet<IClipper> m_Clippers;

		public static ClipperRegistry instance => null;

		protected ClipperRegistry()
		{
		}

		public void Cull()
		{
		}

		public static void Register(IClipper c)
		{
		}

		public static void Unregister(IClipper c)
		{
		}
	}
}
