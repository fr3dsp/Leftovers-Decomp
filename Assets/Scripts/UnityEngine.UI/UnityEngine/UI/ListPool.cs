using System.Collections.Generic;

namespace UnityEngine.UI
{
	internal static class ListPool<T>
	{
		private static readonly ObjectPool<List<T>> s_ListPool;

		private static void Clear(List<T> l)
		{
		}

		public static List<T> Get()
		{
			return null;
		}

		public static void Release(List<T> toRelease)
		{
		}
	}
}
