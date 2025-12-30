using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	public static class HashSetPool<T>
	{
		private static readonly ObjectPool<HashSet<T>> s_Pool;

		public static HashSet<T> Get()
		{
			return null;
		}

		public static ObjectPool<HashSet<T>>.PooledObject Get(out HashSet<T> value)
		{
			value = null;
			return default(ObjectPool<HashSet<T>>.PooledObject);
		}

		public static void Release(HashSet<T> toRelease)
		{
		}
	}
}
