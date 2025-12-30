namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	internal struct ResourceHandle
	{
		private const uint kValidityMask = 4294901760u;

		private const uint kIndexMask = 65535u;

		private uint m_Value;

		private static uint s_CurrentValidBit;

		public int index => 0;

		public RenderGraphResourceType type { get; private set; }

		public int iType => 0;

		internal ResourceHandle(int value, RenderGraphResourceType type)
		{
			m_Value = 0u;
			this.type = default(RenderGraphResourceType);
		}

		public static implicit operator int(ResourceHandle handle)
		{
			return 0;
		}

		public bool IsValid()
		{
			return false;
		}

		public static void NewFrame(int executionIndex)
		{
		}
	}
}
