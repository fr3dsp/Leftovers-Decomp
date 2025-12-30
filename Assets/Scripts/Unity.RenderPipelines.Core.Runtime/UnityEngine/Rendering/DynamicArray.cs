namespace UnityEngine.Rendering
{
	public class DynamicArray<T> where T : new()
	{
		private T[] m_Array;

		public int size { get; private set; }

		public int capacity => 0;

		public ref T Item
		{
			get
			{
				throw null;
			}
		}

		public DynamicArray()
		{
		}

		public DynamicArray(int size)
		{
		}

		public void Clear()
		{
		}

		public int Add(in T value)
		{
			return 0;
		}

		public void Resize(int newSize, bool keepContent = false)
		{
		}
	}
}
