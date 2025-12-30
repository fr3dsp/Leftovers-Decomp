using System.Runtime.CompilerServices;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class PostProcessPass : ScriptableRenderPass
	{
		private class MaterialLibrary
		{
			public readonly Material stopNaN;

			public readonly Material subpixelMorphologicalAntialiasing;

			public readonly Material gaussianDepthOfField;

			public readonly Material bokehDepthOfField;

			public readonly Material cameraMotionBlur;

			public readonly Material paniniProjection;

			public readonly Material bloom;

			public readonly Material uber;

			public readonly Material finalPass;

			public MaterialLibrary(PostProcessData data)
			{
			}

			private Material Load(Shader shader)
			{
				return null;
			}

			internal void Cleanup()
			{
			}
		}

		private static class ShaderConstants
		{
			public static readonly int _TempTarget;

			public static readonly int _TempTarget2;

			public static readonly int _StencilRef;

			public static readonly int _StencilMask;

			public static readonly int _FullCoCTexture;

			public static readonly int _HalfCoCTexture;

			public static readonly int _DofTexture;

			public static readonly int _CoCParams;

			public static readonly int _BokehKernel;

			public static readonly int _PongTexture;

			public static readonly int _PingTexture;

			public static readonly int _Metrics;

			public static readonly int _AreaTexture;

			public static readonly int _SearchTexture;

			public static readonly int _EdgeTexture;

			public static readonly int _BlendTexture;

			public static readonly int _ColorTexture;

			public static readonly int _Params;

			public static readonly int _SourceTexLowMip;

			public static readonly int _Bloom_Params;

			public static readonly int _Bloom_RGBM;

			public static readonly int _Bloom_Texture;

			public static readonly int _LensDirt_Texture;

			public static readonly int _LensDirt_Params;

			public static readonly int _LensDirt_Intensity;

			public static readonly int _Distortion_Params1;

			public static readonly int _Distortion_Params2;

			public static readonly int _Chroma_Params;

			public static readonly int _Vignette_Params1;

			public static readonly int _Vignette_Params2;

			public static readonly int _Lut_Params;

			public static readonly int _UserLut_Params;

			public static readonly int _InternalLut;

			public static readonly int _UserLut;

			public static readonly int _DownSampleScaleFactor;

			public static readonly int _FullscreenProjMat;

			public static int[] _BloomMipUp;

			public static int[] _BloomMipDown;
		}

		private RenderTextureDescriptor m_Descriptor;

		private RenderTargetHandle m_Source;

		private RenderTargetHandle m_Destination;

		private RenderTargetHandle m_Depth;

		private RenderTargetHandle m_InternalLut;

		private const string k_RenderPostProcessingTag = "Render PostProcessing Effects";

		private const string k_RenderFinalPostProcessingTag = "Render Final PostProcessing Pass";

		private static readonly ProfilingSampler m_ProfilingRenderPostProcessing;

		private static readonly ProfilingSampler m_ProfilingRenderFinalPostProcessing;

		private MaterialLibrary m_Materials;

		private PostProcessData m_Data;

		private DepthOfField m_DepthOfField;

		private MotionBlur m_MotionBlur;

		private PaniniProjection m_PaniniProjection;

		private Bloom m_Bloom;

		private LensDistortion m_LensDistortion;

		private ChromaticAberration m_ChromaticAberration;

		private Vignette m_Vignette;

		private ColorLookup m_ColorLookup;

		private ColorAdjustments m_ColorAdjustments;

		private Tonemapping m_Tonemapping;

		private FilmGrain m_FilmGrain;

		private const int k_MaxPyramidSize = 16;

		private readonly GraphicsFormat m_DefaultHDRFormat;

		private bool m_UseRGBM;

		private readonly GraphicsFormat m_SMAAEdgeFormat;

		private readonly GraphicsFormat m_GaussianCoCFormat;

		private Matrix4x4[] m_PrevViewProjM;

		private bool m_ResetHistory;

		private int m_DitheringTextureIndex;

		private RenderTargetIdentifier[] m_MRT2;

		private Vector4[] m_BokehKernel;

		private int m_BokehHash;

		private bool m_IsFinalPass;

		private bool m_HasFinalPass;

		private bool m_EnableSRGBConversionIfNeeded;

		private bool m_UseDrawProcedural;

		private Material m_BlitMaterial;

		internal static readonly Matrix4x4[] viewProjMatrixStereo;

		public PostProcessPass(RenderPassEvent evt, PostProcessData data, Material blitMaterial)
		{
		}

		public void Cleanup()
		{
		}

		public void Setup(in RenderTextureDescriptor baseDescriptor, in RenderTargetHandle source, in RenderTargetHandle destination, in RenderTargetHandle depth, in RenderTargetHandle internalLut, bool hasFinalPass, bool enableSRGBConversion)
		{
		}

		public void SetupFinalPass(in RenderTargetHandle source)
		{
		}

		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		public void ResetHistory()
		{
		}

		public bool CanRunOnTile()
		{
			return false;
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private RenderTextureDescriptor GetCompatibleDescriptor()
		{
			return default(RenderTextureDescriptor);
		}

		private RenderTextureDescriptor GetCompatibleDescriptor(int width, int height, GraphicsFormat format, int depthBufferBits = 0)
		{
			return default(RenderTextureDescriptor);
		}

		private bool RequireSRGBConversionBlitToBackBuffer(CameraData cameraData)
		{
			return false;
		}

		private new void Blit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int passIndex = 0)
		{
		}

		private void DrawFullscreenMesh(CommandBuffer cmd, Material material, int passIndex)
		{
		}

		private void Render(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		private BuiltinRenderTextureType BlitDstDiscardContent(CommandBuffer cmd, RenderTargetIdentifier rt)
		{
			return default(BuiltinRenderTextureType);
		}

		private void DoSubpixelMorphologicalAntialiasing(ref CameraData cameraData, CommandBuffer cmd, int source, int destination)
		{
		}

		private void DoDepthOfField(Camera camera, CommandBuffer cmd, int source, int destination, Rect pixelRect)
		{
		}

		private void DoGaussianDepthOfField(Camera camera, CommandBuffer cmd, int source, int destination, Rect pixelRect)
		{
		}

		private void PrepareBokehKernel()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float GetMaxBokehRadiusInPixels(float viewportHeight)
		{
			return 0f;
		}

		private void DoBokehDepthOfField(CommandBuffer cmd, int source, int destination, Rect pixelRect)
		{
		}

		private void DoMotionBlur(CameraData cameraData, CommandBuffer cmd, int source, int destination)
		{
		}

		private void DoPaniniProjection(Camera camera, CommandBuffer cmd, int source, int destination)
		{
		}

		private Vector2 CalcViewExtents(Camera camera)
		{
			return default(Vector2);
		}

		private Vector2 CalcCropExtents(Camera camera, float d)
		{
			return default(Vector2);
		}

		private void SetupBloom(CommandBuffer cmd, int source, Material uberMaterial)
		{
		}

		private void SetupLensDistortion(Material material, bool isSceneView)
		{
		}

		private void SetupChromaticAberration(Material material)
		{
		}

		private void SetupVignette(Material material)
		{
		}

		private void SetupColorGrading(CommandBuffer cmd, ref RenderingData renderingData, Material material)
		{
		}

		private void SetupGrain(in CameraData cameraData, Material material)
		{
		}

		private void SetupDithering(in CameraData cameraData, Material material)
		{
		}

		private void RenderFinalPass(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}
	}
}
