using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	public struct CameraData
	{
		private Matrix4x4 m_ViewMatrix;

		private Matrix4x4 m_ProjectionMatrix;

		public Camera camera;

		public CameraRenderType renderType;

		public RenderTexture targetTexture;

		public RenderTextureDescriptor cameraTargetDescriptor;

		internal Rect pixelRect;

		internal int pixelWidth;

		internal int pixelHeight;

		internal float aspectRatio;

		public float renderScale;

		public bool clearDepth;

		public CameraType cameraType;

		public bool isDefaultViewport;

		public bool isHdrEnabled;

		public bool requiresDepthTexture;

		public bool requiresOpaqueTexture;

		public bool xrRendering;

		public SortingCriteria defaultOpaqueSortFlags;

		internal XRPass xr;

		[Obsolete]
		public bool isStereoEnabled;

		public float maxShadowDistance;

		public bool postProcessEnabled;

		public IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> captureActions;

		public LayerMask volumeLayerMask;

		public Transform volumeTrigger;

		public bool isStopNaNEnabled;

		public bool isDitheringEnabled;

		public AntialiasingMode antialiasing;

		public AntialiasingQuality antialiasingQuality;

		public ScriptableRenderer renderer;

		public bool resolveFinalTarget;

		internal bool requireSrgbConversion => false;

		public bool isSceneViewCamera => false;

		public bool isPreviewCamera => false;

		internal void SetViewAndProjectionMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix)
		{
		}

		public Matrix4x4 GetViewMatrix(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		public Matrix4x4 GetProjectionMatrix(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		public Matrix4x4 GetGPUProjectionMatrix(int viewIndex = 0)
		{
			return default(Matrix4x4);
		}

		public bool IsCameraProjectionMatrixFlipped()
		{
			return false;
		}
	}
}
