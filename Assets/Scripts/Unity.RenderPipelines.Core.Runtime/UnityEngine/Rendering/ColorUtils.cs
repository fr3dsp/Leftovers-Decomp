namespace UnityEngine.Rendering
{
	public static class ColorUtils
	{
		public static float s_LightMeterCalibrationConstant;

		public static float s_LensAttenuation;

		public static float lensImperfectionExposureScale => 0f;

		public static float StandardIlluminantY(float x)
		{
			return 0f;
		}

		public static Vector3 CIExyToLMS(float x, float y)
		{
			return default(Vector3);
		}

		public static Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint)
		{
			return default(Vector3);
		}

		public static (Vector4, Vector4, Vector4) PrepareShadowsMidtonesHighlights(in Vector4 inShadows, in Vector4 inMidtones, in Vector4 inHighlights)
		{
			return default((Vector4, Vector4, Vector4));
		}

		public static (Vector4, Vector4, Vector4) PrepareLiftGammaGain(in Vector4 inLift, in Vector4 inGamma, in Vector4 inGain)
		{
			return default((Vector4, Vector4, Vector4));
		}

		public static (Vector4, Vector4) PrepareSplitToning(in Vector4 inShadows, in Vector4 inHighlights, float balance)
		{
			return default((Vector4, Vector4));
		}

		public static float Luminance(in Color color)
		{
			return 0f;
		}

		public static float ComputeEV100(float aperture, float shutterSpeed, float ISO)
		{
			return 0f;
		}

		public static float ConvertEV100ToExposure(float EV100)
		{
			return 0f;
		}

		public static float ConvertExposureToEV100(float exposure)
		{
			return 0f;
		}

		public static float ComputeEV100FromAvgLuminance(float avgLuminance)
		{
			return 0f;
		}

		public static float ComputeISO(float aperture, float shutterSpeed, float targetEV100)
		{
			return 0f;
		}

		public static uint ToHex(Color c)
		{
			return 0u;
		}

		public static Color ToRGBA(uint hex)
		{
			return default(Color);
		}
	}
}
