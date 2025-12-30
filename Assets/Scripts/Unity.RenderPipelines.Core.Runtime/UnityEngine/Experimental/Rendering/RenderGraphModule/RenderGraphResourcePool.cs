using System.Collections.Generic;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	internal abstract class RenderGraphResourcePool<Type> where Type : class
	{
		private struct ResourceLogInfo
		{
			public string name;

			public long size;
		}

		protected Dictionary<int, List<(Type, int)>> m_ResourcePool;

		private List<(int, Type)> m_FrameAllocatedResources;

		protected static int s_CurrentFrameIndex;

		private const int kStaleResourceLifetime = 10;

		protected abstract void ReleaseInternalResource(Type res);

		protected abstract string GetResourceName(Type res);

		protected abstract long GetResourceSize(Type res);

		protected abstract string GetResourceTypeName();

		public void ReleaseResource(int hash, Type resource, int currentFrameIndex)
		{
		}

		public bool TryGetResource(int hashCode, out Type resource)
		{
			resource = null;
			return false;
		}

		public abstract void PurgeUnusedResources(int currentFrameIndex);

		public void Cleanup()
		{
		}

		public void RegisterFrameAllocation(int hash, Type value)
		{
		}

		public void UnregisterFrameAllocation(int hash, Type value)
		{
		}

		public void CheckFrameAllocation(bool onException, int frameIndex)
		{
		}

		public void LogResources(RenderGraphLogger logger)
		{
		}

		protected static bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex)
		{
			return false;
		}
	}
}
