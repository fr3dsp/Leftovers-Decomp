using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class XRGraphics
	{
		public enum StereoRenderingMode
		{
			MultiPass = 0,
			SinglePass = 1,
			SinglePassInstanced = 2,
			SinglePassMultiView = 3
		}

		public static float eyeTextureResolutionScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float renderViewportScale => 0f;

		public static bool enabled => false;

		public static bool isDeviceActive => false;

		public static string loadedDeviceName => null;

		public static string[] supportedDevices => null;

		public static StereoRenderingMode stereoRenderingMode => default(StereoRenderingMode);

		public static RenderTextureDescriptor eyeTextureDesc => default(RenderTextureDescriptor);

		public static int eyeTextureWidth => 0;

		public static int eyeTextureHeight => 0;
	}
}
