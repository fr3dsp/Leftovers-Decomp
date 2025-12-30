namespace UnityEngine.Rendering
{
	public static class UnsafeGenericPool<T> where T : new()
	{
		private static readonly ObjectPool<T> s_Pool;

		public static T Get()
		{
			return default(T);
		}

		public static ObjectPool<T>.PooledObject Get(out T value)
		{
			value = default(T);
			return default(ObjectPool<T>.PooledObject);
		}

		public static void Release(T toRelease)
		{
		}
	}
}
