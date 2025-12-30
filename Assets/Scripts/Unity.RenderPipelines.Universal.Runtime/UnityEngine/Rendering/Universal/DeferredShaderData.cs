using System;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	internal class DeferredShaderData : IDisposable
	{
		private struct ComputeBufferInfo
		{
			public uint frameUsed;

			public ComputeBufferType type;
		}

		private static DeferredShaderData m_Instance;

		private NativeArray<PreTile>[] m_PreTiles;

		private ComputeBuffer[] m_Buffers;

		private ComputeBufferInfo[] m_BufferInfos;

		private int m_BufferCount;

		private int m_CachedBufferIndex;

		private uint m_FrameIndex;

		internal static DeferredShaderData instance => null;

		private DeferredShaderData()
		{
		}

		public void Dispose()
		{
		}

		internal void ResetBuffers()
		{
		}

		internal NativeArray<PreTile> GetPreTiles(int level, int count)
		{
			return default(NativeArray<PreTile>);
		}

		internal ComputeBuffer ReserveBuffer<T>(int count, bool asCBuffer) where T : struct
		{
			return null;
		}

		private NativeArray<T> GetOrUpdateNativeArray<T>(ref NativeArray<T>[] nativeArrays, int level, int count) where T : struct
		{
			return default(NativeArray<T>);
		}

		private void DisposeNativeArrays<T>(ref NativeArray<T>[] nativeArrays) where T : struct
		{
		}

		private ComputeBuffer GetOrUpdateBuffer(int count, int stride, bool isConstantBuffer)
		{
			return null;
		}

		private void DisposeBuffers(ComputeBuffer[,] buffers)
		{
		}

		private static bool IsLessCircular(uint a, uint b)
		{
			return false;
		}

		private static int Align(int s, int alignment)
		{
			return 0;
		}
	}
}
