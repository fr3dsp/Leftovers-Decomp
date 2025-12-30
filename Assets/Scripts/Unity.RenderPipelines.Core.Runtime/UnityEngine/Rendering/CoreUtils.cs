using System;
using System.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	public static class CoreUtils
	{
		public static readonly Vector3[] lookAtList;

		public static readonly Vector3[] upVectorList;

		public const int editMenuPriority1 = 320;

		public const int editMenuPriority2 = 331;

		public const int editMenuPriority3 = 342;

		public const int editMenuPriority4 = 353;

		public const int assetCreateMenuPriority1 = 230;

		public const int assetCreateMenuPriority2 = 241;

		public const int assetCreateMenuPriority3 = 300;

		public const int gameObjectMenuPriority = 10;

		private static Cubemap m_BlackCubeTexture;

		private static Cubemap m_MagentaCubeTexture;

		private static CubemapArray m_MagentaCubeTextureArray;

		private static Cubemap m_WhiteCubeTexture;

		private static RenderTexture m_EmptyUAV;

		private static Texture3D m_BlackVolumeTexture;

		private static IEnumerable<Type> m_AssemblyTypes;

		public static Cubemap blackCubeTexture => null;

		public static Cubemap magentaCubeTexture => null;

		public static CubemapArray magentaCubeTextureArray => null;

		public static Cubemap whiteCubeTexture => null;

		public static RenderTexture emptyUAV => null;

		public static Texture3D blackVolumeTexture => null;

		public static void ClearRenderTarget(CommandBuffer cmd, ClearFlag clearFlag, Color clearColor)
		{
		}

		private static int FixupDepthSlice(int depthSlice, RTHandle buffer)
		{
			return 0;
		}

		private static int FixupDepthSlice(int depthSlice, CubemapFace cubemapFace)
		{
			return 0;
		}

		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag = ClearFlag.None, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag = ClearFlag.None)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, Color clearColor)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag)
		{
		}

		private static void SetViewportAndClear(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, Color clearColor)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag = ClearFlag.None, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = CubemapFace.Unknown, int depthSlice = -1)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag = ClearFlag.None)
		{
		}

		public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag, Color clearColor)
		{
		}

		public static void SetViewport(CommandBuffer cmd, RTHandle target)
		{
		}

		public static string GetRenderTargetAutoName(int width, int height, int depth, RenderTextureFormat format, string name, bool mips = false, bool enableMSAA = false, MSAASamples msaaSamples = MSAASamples.None)
		{
			return null;
		}

		public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, string name, bool mips = false, bool enableMSAA = false, MSAASamples msaaSamples = MSAASamples.None)
		{
			return null;
		}

		public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, TextureDimension dim, string name, bool mips = false, bool enableMSAA = false, MSAASamples msaaSamples = MSAASamples.None, bool dynamicRes = false)
		{
			return null;
		}

		private static string GetRenderTargetAutoName(int width, int height, int depth, string format, TextureDimension dim, string name, bool mips, bool enableMSAA, MSAASamples msaaSamples, bool dynamicRes)
		{
			return null;
		}

		public static string GetTextureAutoName(int width, int height, TextureFormat format, TextureDimension dim = TextureDimension.None, string name = "", bool mips = false, int depth = 0)
		{
			return null;
		}

		public static string GetTextureAutoName(int width, int height, GraphicsFormat format, TextureDimension dim = TextureDimension.None, string name = "", bool mips = false, int depth = 0)
		{
			return null;
		}

		private static string GetTextureAutoName(int width, int height, string format, TextureDimension dim = TextureDimension.None, string name = "", bool mips = false, int depth = 0)
		{
			return null;
		}

		public static void ClearCubemap(CommandBuffer cmd, RenderTexture renderTexture, Color clearColor, bool clearMips = false)
		{
		}

		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, MaterialPropertyBlock properties = null, int shaderPassId = 0)
		{
		}

		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0)
		{
		}

		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0)
		{
		}

		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties = null, int shaderPassId = 0)
		{
		}

		public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, MaterialPropertyBlock properties = null, int shaderPassId = 0)
		{
		}

		public static Color ConvertSRGBToActiveColorSpace(Color color)
		{
			return default(Color);
		}

		public static Color ConvertLinearToActiveColorSpace(Color color)
		{
			return default(Color);
		}

		public static Material CreateEngineMaterial(string shaderPath)
		{
			return null;
		}

		public static Material CreateEngineMaterial(Shader shader)
		{
			return null;
		}

		public static bool HasFlag<T>(T mask, T flag) where T : IConvertible
		{
			return false;
		}

		public static void Swap<T>(ref T a, ref T b)
		{
		}

		public static void SetKeyword(CommandBuffer cmd, string keyword, bool state)
		{
		}

		public static void SetKeyword(Material material, string keyword, bool state)
		{
		}

		public static void SetKeyword(ComputeShader cs, string keyword, bool state)
		{
		}

		public static void Destroy(Object obj)
		{
		}

		public static IEnumerable<Type> GetAllAssemblyTypes()
		{
			return null;
		}

		public static IEnumerable<Type> GetAllTypesDerivedFrom<T>()
		{
			return null;
		}

		public static void SafeRelease(ComputeBuffer buffer)
		{
		}

		public static Mesh CreateCubeMesh(Vector3 min, Vector3 max)
		{
			return null;
		}

		public static bool ArePostProcessesEnabled(Camera camera)
		{
			return false;
		}

		public static bool AreAnimatedMaterialsEnabled(Camera camera)
		{
			return false;
		}

		public static bool IsSceneLightingDisabled(Camera camera)
		{
			return false;
		}

		public static bool IsLightOverlapDebugEnabled(Camera camera)
		{
			return false;
		}

		public static bool IsSceneViewFogEnabled(Camera camera)
		{
			return false;
		}

		public static void DrawRendererList(ScriptableRenderContext renderContext, CommandBuffer cmd, RendererList rendererList)
		{
		}
	}
}
