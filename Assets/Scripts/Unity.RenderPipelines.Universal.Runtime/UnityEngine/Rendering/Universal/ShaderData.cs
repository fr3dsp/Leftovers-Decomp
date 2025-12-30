using System;

namespace UnityEngine.Rendering.Universal
{
	internal class ShaderData : IDisposable
	{
		private static ShaderData m_Instance;

		private ComputeBuffer m_LightDataBuffer;

		private ComputeBuffer m_LightIndicesBuffer;

		private ComputeBuffer m_ShadowDataBuffer;

		private ComputeBuffer m_ShadowIndicesBuffer;

		internal static ShaderData instance => null;

		private ShaderData()
		{
		}

		public void Dispose()
		{
		}

		internal ComputeBuffer GetLightDataBuffer(int size)
		{
			return null;
		}

		internal ComputeBuffer GetLightIndicesBuffer(int size)
		{
			return null;
		}

		internal ComputeBuffer GetShadowDataBuffer(int size)
		{
			return null;
		}

		internal ComputeBuffer GetShadowIndicesBuffer(int size)
		{
			return null;
		}

		private ComputeBuffer GetOrUpdateBuffer<T>(ref ComputeBuffer buffer, int size) where T : struct
		{
			return null;
		}

		private void DisposeBuffer(ref ComputeBuffer buffer)
		{
		}
	}
}
