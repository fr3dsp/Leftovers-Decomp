using System;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal.Internal
{
	internal struct BitArray : IDisposable
	{
		private NativeArray<uint> m_Mem;

		private int m_BitCount;

		private int m_IntCount;

		public BitArray(int bitCount, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
		{
			m_Mem = default(NativeArray<uint>);
			m_BitCount = 0;
			m_IntCount = 0;
		}

		public void Dispose()
		{
		}

		public void Clear()
		{
		}

		public bool IsSet(int bitIndex)
		{
			return false;
		}

		public void Set(int bitIndex, bool val)
		{
		}
	}
}
