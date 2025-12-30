using System;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Experimental.Rendering.Universal
{
	[ExcludeFromPreset]
	public class RenderObjects : ScriptableRendererFeature
	{
		[Serializable]
		public class RenderObjectsSettings
		{
			public string passTag;

			public RenderPassEvent Event;

			public FilterSettings filterSettings;

			public Material overrideMaterial;

			public int overrideMaterialPassIndex;

			public bool overrideDepthState;

			public CompareFunction depthCompareFunction;

			public bool enableWrite;

			public StencilStateData stencilSettings;

			public CustomCameraSettings cameraSettings;
		}

		[Serializable]
		public class FilterSettings
		{
			public RenderQueueType RenderQueueType;

			public LayerMask LayerMask;

			public string[] PassNames;
		}

		[Serializable]
		public class CustomCameraSettings
		{
			public bool overrideCamera;

			public bool restoreCamera;

			public Vector4 offset;

			public float cameraFieldOfView;
		}

		public RenderObjectsSettings settings;

		private RenderObjectsPass renderObjectsPass;

		public override void Create()
		{
		}

		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}
	}
}
