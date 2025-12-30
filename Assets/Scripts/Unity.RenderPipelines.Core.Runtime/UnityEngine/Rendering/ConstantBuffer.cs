using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	public class ConstantBuffer
	{
		internal abstract class ConstantBufferBase
		{
			public abstract void Release();
		}

		private class TypedConstantBuffer<CBType> : ConstantBufferBase where CBType : struct
		{
			private HashSet<int> m_GlobalBindings;

			private CBType[] m_Data;

			private static TypedConstantBuffer<CBType> s_Instance;

			private ComputeBuffer m_GPUConstantBuffer;

			internal static TypedConstantBuffer<CBType> instance
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			private TypedConstantBuffer()
			{
			}

			public void UpdateData(CommandBuffer cmd, in CBType data)
			{
			}

			public void SetGlobal(CommandBuffer cmd, int shaderId)
			{
			}

			public void Set(CommandBuffer cmd, ComputeShader cs, int shaderId)
			{
			}

			public void Set(Material mat, int shaderId)
			{
			}

			public override void Release()
			{
			}
		}

		private static List<ConstantBufferBase> m_RegisteredConstantBuffers;

		public static void PushGlobal<CBType>(CommandBuffer cmd, in CBType data, int shaderId) where CBType : struct
		{
		}

		public static void Push<CBType>(CommandBuffer cmd, in CBType data, ComputeShader cs, int shaderId) where CBType : struct
		{
		}

		public static void Push<CBType>(CommandBuffer cmd, in CBType data, Material mat, int shaderId) where CBType : struct
		{
		}

		public static void UpdateData<CBType>(CommandBuffer cmd, in CBType data) where CBType : struct
		{
		}

		public static void SetGlobal<CBType>(CommandBuffer cmd, int shaderId) where CBType : struct
		{
		}

		public static void Set<CBType>(CommandBuffer cmd, ComputeShader cs, int shaderId) where CBType : struct
		{
		}

		public static void Set<CBType>(Material mat, int shaderId) where CBType : struct
		{
		}

		public static void ReleaseAll()
		{
		}

		internal static void Register(ConstantBufferBase cb)
		{
		}
	}
}
