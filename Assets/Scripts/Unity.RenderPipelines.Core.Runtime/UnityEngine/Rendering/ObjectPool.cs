using System;
using System.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine.Rendering
{
	public class ObjectPool<T> where T : new()
	{
		public struct PooledObject : IDisposable
		{
			private readonly T m_ToReturn;

			private readonly ObjectPool<T> m_Pool;

			internal PooledObject(T value, ObjectPool<T> pool)
			{
				m_ToReturn = default(T);
				m_Pool = null;
			}

			void IDisposable.Dispose()
			{
			}
		}

		private readonly Stack<T> m_Stack;

		private readonly UnityAction<T> m_ActionOnGet;

		private readonly UnityAction<T> m_ActionOnRelease;

		private readonly bool m_CollectionCheck;

		public int countAll { get; private set; }

		public int countActive => 0;

		public int countInactive => 0;

		public ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease, bool collectionCheck = true)
		{
		}

		public T Get()
		{
			return default(T);
		}

		public PooledObject Get(out T v)
		{
			v = default(T);
			return default(PooledObject);
		}

		public void Release(T element)
		{
		}
	}
}
