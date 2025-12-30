using System;

namespace UnityEngine.Rendering
{
	public static class ListBufferExtensions
	{
		public static void QuickSort<T>(this ListBuffer<T> self) where T : struct, IComparable<T>
		{
		}
	}
}
