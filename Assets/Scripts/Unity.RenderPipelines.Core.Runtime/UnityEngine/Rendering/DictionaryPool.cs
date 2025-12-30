using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	public static class DictionaryPool<TKey, TValue>
	{
		private static readonly ObjectPool<Dictionary<TKey, TValue>> s_Pool;

		public static Dictionary<TKey, TValue> Get()
		{
			return null;
		}

		public static ObjectPool<Dictionary<TKey, TValue>>.PooledObject Get(out Dictionary<TKey, TValue> value)
		{
			value = null;
			return default(ObjectPool<Dictionary<TKey, TValue>>.PooledObject);
		}

		public static void Release(Dictionary<TKey, TValue> toRelease)
		{
		}
	}
}
