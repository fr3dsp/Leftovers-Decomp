using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	public static class CameraCaptureBridge
	{
		private static Dictionary<Camera, HashSet<Action<RenderTargetIdentifier, CommandBuffer>>> actionDict;

		private static bool _enabled;

		public static bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> GetCaptureActions(Camera camera)
		{
			return null;
		}

		public static void AddCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action)
		{
		}

		public static void RemoveCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action)
		{
		}
	}
}
