using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
	public struct RendererListDesc
	{
		public SortingCriteria sortingCriteria;

		public PerObjectData rendererConfiguration;

		public RenderQueueRange renderQueueRange;

		public RenderStateBlock? stateBlock;

		public Material overrideMaterial;

		public bool excludeObjectMotionVectors;

		public int layerMask;

		public int overrideMaterialPassIndex;

		internal CullingResults cullingResult { get; private set; }

		internal Camera camera { get; set; }

		internal ShaderTagId passName { get; private set; }

		internal ShaderTagId[] passNames { get; private set; }

		public RendererListDesc(ShaderTagId passName, CullingResults cullingResult, Camera camera)
		{
			sortingCriteria = default(SortingCriteria);
			rendererConfiguration = default(PerObjectData);
			renderQueueRange = default(RenderQueueRange);
			stateBlock = null;
			overrideMaterial = null;
			excludeObjectMotionVectors = false;
			layerMask = 0;
			overrideMaterialPassIndex = 0;
			this.cullingResult = default(CullingResults);
			this.camera = null;
			this.passName = default(ShaderTagId);
			passNames = null;
		}

		public RendererListDesc(ShaderTagId[] passNames, CullingResults cullingResult, Camera camera)
		{
			sortingCriteria = default(SortingCriteria);
			rendererConfiguration = default(PerObjectData);
			renderQueueRange = default(RenderQueueRange);
			stateBlock = null;
			overrideMaterial = null;
			excludeObjectMotionVectors = false;
			layerMask = 0;
			overrideMaterialPassIndex = 0;
			this.cullingResult = default(CullingResults);
			this.camera = null;
			passName = default(ShaderTagId);
			this.passNames = null;
		}

		public bool IsValid()
		{
			return false;
		}
	}
}
