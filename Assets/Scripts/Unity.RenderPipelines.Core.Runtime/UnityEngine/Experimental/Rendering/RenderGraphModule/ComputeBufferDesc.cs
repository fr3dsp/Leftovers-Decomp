namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	public struct ComputeBufferDesc
	{
		public int count;

		public int stride;

		public ComputeBufferType type;

		public string name;

		public ComputeBufferDesc(int count, int stride)
		{
			this.count = 0;
			this.stride = 0;
			type = default(ComputeBufferType);
			name = null;
		}

		public ComputeBufferDesc(int count, int stride, ComputeBufferType type)
		{
			this.count = 0;
			this.stride = 0;
			this.type = default(ComputeBufferType);
			name = null;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
