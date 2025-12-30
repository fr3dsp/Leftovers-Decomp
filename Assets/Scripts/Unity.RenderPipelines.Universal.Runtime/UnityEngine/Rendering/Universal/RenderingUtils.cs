using System.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal
{
	public static class RenderingUtils
	{
		internal class StereoConstants
		{
			public Matrix4x4[] viewProjMatrix;

			public Matrix4x4[] invViewMatrix;

			public Matrix4x4[] invProjMatrix;

			public Matrix4x4[] invViewProjMatrix;

			public Matrix4x4[] invCameraProjMatrix;

			public Vector4[] worldSpaceCameraPos;
		}

		private static List<ShaderTagId> m_LegacyShaderPassNames;

		private static Mesh s_FullscreenMesh;

		private static Material s_ErrorMaterial;

		internal static readonly int UNITY_STEREO_MATRIX_V;

		internal static readonly int UNITY_STEREO_MATRIX_IV;

		internal static readonly int UNITY_STEREO_MATRIX_P;

		internal static readonly int UNITY_STEREO_MATRIX_IP;

		internal static readonly int UNITY_STEREO_MATRIX_VP;

		internal static readonly int UNITY_STEREO_MATRIX_IVP;

		internal static readonly int UNITY_STEREO_CAMERA_PROJECTION;

		internal static readonly int UNITY_STEREO_CAMERA_INV_PROJECTION;

		internal static readonly int UNITY_STEREO_VECTOR_CAMPOS;

		private static readonly StereoConstants stereoConstants;

		private static Dictionary<RenderTextureFormat, bool> m_RenderTextureFormatSupport;

		private static Dictionary<GraphicsFormat, Dictionary<FormatUsage, bool>> m_GraphicsFormatSupport;

		public static Mesh fullscreenMesh => null;

		internal static bool useStructuredBuffer => false;

		private static Material errorMaterial => null;

		public static void SetViewAndProjectionMatrices(CommandBuffer cmd, Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, bool setInverseMatrices)
		{
		}

		internal static void SetStereoViewAndProjectionMatrices(CommandBuffer cmd, Matrix4x4[] viewMatrix, Matrix4x4[] projMatrix, Matrix4x4[] cameraProjMatrix, bool setInverseMatrices)
		{
		}

		internal static void Blit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int passIndex = 0, bool useDrawProcedural = false, RenderBufferLoadAction colorLoadAction = RenderBufferLoadAction.Load, RenderBufferStoreAction colorStoreAction = RenderBufferStoreAction.Store, RenderBufferLoadAction depthLoadAction = RenderBufferLoadAction.Load, RenderBufferStoreAction depthStoreAction = RenderBufferStoreAction.Store)
		{
		}

		internal static void RenderObjectsWithError(ScriptableRenderContext context, ref CullingResults cullResults, Camera camera, FilteringSettings filterSettings, SortingCriteria sortFlags)
		{
		}

		internal static void ClearSystemInfoCache()
		{
		}

		public static bool SupportsRenderTextureFormat(RenderTextureFormat format)
		{
			return false;
		}

		public static bool SupportsGraphicsFormat(GraphicsFormat format, FormatUsage usage)
		{
			return false;
		}

		internal static int GetLastValidColorBufferIndex(RenderTargetIdentifier[] colorBuffers)
		{
			return 0;
		}

		internal static uint GetValidColorBufferCount(RenderTargetIdentifier[] colorBuffers)
		{
			return 0u;
		}

		internal static bool IsMRT(RenderTargetIdentifier[] colorBuffers)
		{
			return false;
		}

		internal static bool Contains(RenderTargetIdentifier[] source, RenderTargetIdentifier value)
		{
			return false;
		}

		internal static int IndexOf(RenderTargetIdentifier[] source, RenderTargetIdentifier value)
		{
			return 0;
		}

		internal static uint CountDistinct(RenderTargetIdentifier[] source, RenderTargetIdentifier value)
		{
			return 0u;
		}

		internal static int LastValid(RenderTargetIdentifier[] source)
		{
			return 0;
		}

		internal static bool Contains(ClearFlag a, ClearFlag b)
		{
			return false;
		}

		internal static bool SequenceEqual(RenderTargetIdentifier[] left, RenderTargetIdentifier[] right)
		{
			return false;
		}
	}
}
