using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class ColorGradingLutPass : ScriptableRenderPass
	{
		private static class ShaderConstants
		{
			public static readonly int _Lut_Params;

			public static readonly int _ColorBalance;

			public static readonly int _ColorFilter;

			public static readonly int _ChannelMixerRed;

			public static readonly int _ChannelMixerGreen;

			public static readonly int _ChannelMixerBlue;

			public static readonly int _HueSatCon;

			public static readonly int _Lift;

			public static readonly int _Gamma;

			public static readonly int _Gain;

			public static readonly int _Shadows;

			public static readonly int _Midtones;

			public static readonly int _Highlights;

			public static readonly int _ShaHiLimits;

			public static readonly int _SplitShadows;

			public static readonly int _SplitHighlights;

			public static readonly int _CurveMaster;

			public static readonly int _CurveRed;

			public static readonly int _CurveGreen;

			public static readonly int _CurveBlue;

			public static readonly int _CurveHueVsHue;

			public static readonly int _CurveHueVsSat;

			public static readonly int _CurveLumVsSat;

			public static readonly int _CurveSatVsSat;
		}

		private readonly Material m_LutBuilderLdr;

		private readonly Material m_LutBuilderHdr;

		private readonly GraphicsFormat m_HdrLutFormat;

		private readonly GraphicsFormat m_LdrLutFormat;

		private RenderTargetHandle m_InternalLut;

		public ColorGradingLutPass(RenderPassEvent evt, PostProcessData data)
		{
		}

		public void Setup(in RenderTargetHandle internalLut)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void OnFinishCameraStackRendering(CommandBuffer cmd)
		{
		}

		public void Cleanup()
		{
		}
	}
}
