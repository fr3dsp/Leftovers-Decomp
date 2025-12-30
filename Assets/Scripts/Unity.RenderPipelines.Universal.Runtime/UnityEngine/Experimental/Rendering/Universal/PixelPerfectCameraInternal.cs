using System;

namespace UnityEngine.Experimental.Rendering.Universal
{
	[Serializable]
	internal class PixelPerfectCameraInternal : ISerializationCallbackReceiver
	{
		[NonSerialized]
		private IPixelPerfectCamera m_Component;

		private PixelPerfectCamera m_SerializableComponent;

		internal float originalOrthoSize;

		internal bool hasPostProcessLayer;

		internal bool cropFrameXAndY;

		internal bool cropFrameXOrY;

		internal bool useStretchFill;

		internal int zoom;

		internal bool useOffscreenRT;

		internal int offscreenRTWidth;

		internal int offscreenRTHeight;

		internal Rect pixelRect;

		internal float orthoSize;

		internal float unitsPerPixel;

		internal int cinemachineVCamZoom;

		internal PixelPerfectCameraInternal(IPixelPerfectCamera component)
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		internal void CalculateCameraProperties(int screenWidth, int screenHeight)
		{
		}

		internal Rect CalculateFinalBlitPixelRect(int screenWidth, int screenHeight)
		{
			return default(Rect);
		}

		internal float CorrectCinemachineOrthoSize(float targetOrthoSize)
		{
			return 0f;
		}
	}
}
