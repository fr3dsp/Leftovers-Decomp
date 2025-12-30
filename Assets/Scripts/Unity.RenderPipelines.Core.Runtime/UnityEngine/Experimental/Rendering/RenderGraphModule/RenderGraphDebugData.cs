using System.Collections.Generic;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	internal class RenderGraphDebugData
	{
		public struct PassDebugData
		{
			public string name;

			public List<int>[] resourceReadLists;

			public List<int>[] resourceWriteLists;

			public bool culled;

			public bool generateDebugData;
		}

		public struct ResourceDebugData
		{
			public string name;

			public bool imported;

			public int creationPassIndex;

			public int releasePassIndex;

			public List<int> consumerList;

			public List<int> producerList;
		}

		public List<PassDebugData> passList;

		public List<ResourceDebugData>[] resourceLists;

		public void Clear()
		{
		}
	}
}
