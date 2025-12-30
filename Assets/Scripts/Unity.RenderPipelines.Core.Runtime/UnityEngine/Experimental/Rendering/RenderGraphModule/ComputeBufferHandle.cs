namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	public struct ComputeBufferHandle
	{
		private static ComputeBufferHandle s_NullHandle;

		internal ResourceHandle handle;

		public static ComputeBufferHandle nullHandle => default(ComputeBufferHandle);

		internal ComputeBufferHandle(int handle)
		{
			this.handle = default(ResourceHandle);
		}

		public static implicit operator ComputeBuffer(ComputeBufferHandle buffer)
		{
			return null;
		}

		public bool IsValid()
		{
			return false;
		}
	}
}
