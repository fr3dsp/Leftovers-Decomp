using System.Collections.Generic;
using UnityEngine.Events;

namespace TMPro
{
	internal class TMP_ObjectPool<T> where T : new()
	{
		private readonly Stack<T> m_Stack;

		private readonly UnityAction<T> m_ActionOnGet;

		private readonly UnityAction<T> m_ActionOnRelease;

		public int countAll { get; private set; }

		public int countActive => 0;

		public int countInactive => 0;

		public TMP_ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease)
		{
		}

		public T Get()
		{
			return default(T);
		}

		public void Release(T element)
		{
		}
	}
}
