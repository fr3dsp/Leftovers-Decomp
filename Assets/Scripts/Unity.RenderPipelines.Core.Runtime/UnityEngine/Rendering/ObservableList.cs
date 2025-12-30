using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering
{
	public class ObservableList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		private IList<T> m_List;

		public T Item
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool IsReadOnly => false;

		public event ListChangedEventHandler<T> ItemAdded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event ListChangedEventHandler<T> ItemRemoved
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public ObservableList()
		{
		}

		public ObservableList(int capacity)
		{
		}

		public ObservableList(IEnumerable<T> collection)
		{
		}

		private void OnEvent(ListChangedEventHandler<T> e, int index, T item)
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public int IndexOf(T item)
		{
			return 0;
		}

		public void Add(T item)
		{
		}

		public void Add(params T[] items)
		{
		}

		public void Insert(int index, T item)
		{
		}

		public bool Remove(T item)
		{
			return false;
		}

		public int Remove(params T[] items)
		{
			return 0;
		}

		public void RemoveAt(int index)
		{
		}

		public void Clear()
		{
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
