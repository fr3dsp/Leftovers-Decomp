namespace UnityEngine.Rendering
{
	public static class CommandBufferPool
	{
		private static ObjectPool<CommandBuffer> s_BufferPool;

		public static CommandBuffer Get()
		{
			return null;
		}

		public static CommandBuffer Get(string name)
		{
			return null;
		}

		public static void Release(CommandBuffer buffer)
		{
		}
	}
}
