namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	internal class ComputeBufferPool : RenderGraphResourcePool<ComputeBuffer>
	{
		protected override void ReleaseInternalResource(ComputeBuffer res)
		{
		}

		protected override string GetResourceName(ComputeBuffer res)
		{
			return null;
		}

		protected override long GetResourceSize(ComputeBuffer res)
		{
			return 0L;
		}

		protected override string GetResourceTypeName()
		{
			return null;
		}

		public override void PurgeUnusedResources(int currentFrameIndex)
		{
		}
	}
}
