using System.Collections.Generic;
using UnityEngine.XR;

namespace UnityEngine.Rendering.Universal
{
	internal class XRSystem
	{
		internal static class XRShaderIDs
		{
			public static readonly int _SourceTexArraySlice;

			public static readonly int _SRGBRead;

			public static readonly int _SRGBWrite;
		}

		internal readonly XRPass emptyPass;

		private List<XRPass> framePasses;

		private static List<XRDisplaySubsystem> displayList;

		private XRDisplaySubsystem display;

		private static int msaaLevel;

		private Material occlusionMeshMaterial;

		private Material mirrorViewMaterial;

		private MaterialPropertyBlock mirrorViewMaterialProperty;

		private RenderTexture testRenderTexture;

		private const string k_XRMirrorTag = "XR Mirror View";

		private static ProfilingSampler _XRMirrorProfilingSampler;

		internal XRSystem()
		{
		}

		internal void InitializeXRSystemData(XRSystemData data)
		{
		}

		private static void GetDisplaySubsystem()
		{
		}

		[RuntimeInitializeOnLoadMethod]
		internal static void XRSystemInit()
		{
		}

		internal static void UpdateMSAALevel(int level)
		{
		}

		internal static int GetMSAALevel()
		{
			return 0;
		}

		internal static void UpdateRenderScale(float renderScale)
		{
		}

		internal int GetMaxViews()
		{
			return 0;
		}

		internal List<XRPass> SetupFrame(CameraData cameraData)
		{
			return null;
		}

		internal void ReleaseFrame()
		{
		}

		internal bool RefreshXrSdk()
		{
			return false;
		}

		internal void UpdateCameraData(ref CameraData baseCameraData, in XRPass xr)
		{
		}

		internal void UpdateFromCamera(ref XRPass xrPass, CameraData cameraData)
		{
		}

		private void CreateLayoutFromXrSdk(Camera camera, bool singlePassAllowed)
		{
		}

		internal void Dispose()
		{
		}

		internal void AddPassToFrame(XRPass xrPass)
		{
		}

		internal void RenderMirrorView(CommandBuffer cmd, Camera camera)
		{
		}
	}
}
