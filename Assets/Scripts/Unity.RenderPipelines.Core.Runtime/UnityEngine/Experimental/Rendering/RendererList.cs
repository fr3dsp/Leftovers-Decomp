using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
	public struct RendererList
	{
		private static readonly ShaderTagId s_EmptyName;

		public static readonly RendererList nullRendererList;

		public CullingResults cullingResult;

		public DrawingSettings drawSettings;

		public FilteringSettings filteringSettings;

		public RenderStateBlock? stateBlock;

		public bool isValid { get; private set; }

		public static RendererList Create(in RendererListDesc desc)
		{
			return default(RendererList);
		}
	}
}
