using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	public static class ListPool<T>
	{
		private static readonly ObjectPool<List<T>> s_Pool;

		public static List<T> Get()
		{
			return null;
		}

		public static ObjectPool<List<T>>.PooledObject Get(out List<T> value)
		{
			value = null;
			return default(ObjectPool<List<T>>.PooledObject);
		}

		public static void Release(List<T> toRelease)
		{
		}
	}
}
