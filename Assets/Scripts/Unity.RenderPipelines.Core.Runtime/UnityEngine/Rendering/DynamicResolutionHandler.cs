using System;

namespace UnityEngine.Rendering
{
	public class DynamicResolutionHandler
	{
		private bool m_Enabled;

		private float m_MinScreenFraction;

		private float m_MaxScreenFraction;

		private float m_CurrentFraction;

		private float m_PrevFraction;

		private bool m_ForcingRes;

		private bool m_CurrentCameraRequest;

		private bool m_ForceSoftwareFallback;

		private float m_PrevHWScaleWidth;

		private float m_PrevHWScaleHeight;

		private Vector2Int m_LastScaledSize;

		private DynamicResScalePolicyType m_ScalerType;

		private Vector2Int cachedOriginalSize;

		private DynamicResolutionType type;

		private PerformDynamicRes m_DynamicResMethod;

		private static DynamicResolutionHandler s_Instance;

		public DynamicResUpscaleFilter filter { get; set; }

		public Vector2Int finalViewport { get; set; }

		public static DynamicResolutionHandler instance => null;

		private DynamicResolutionHandler()
		{
		}

		private static float DefaultDynamicResMethod()
		{
			return 0f;
		}

		private void ProcessSettings(GlobalDynamicResolutionSettings settings)
		{
		}

		public static void SetDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = DynamicResScalePolicyType.ReturnsMinMaxLerpFactor)
		{
		}

		public void SetCurrentCameraRequest(bool cameraRequest)
		{
		}

		public void Update(GlobalDynamicResolutionSettings settings, Action OnResolutionChange = null)
		{
		}

		public bool SoftwareDynamicResIsEnabled()
		{
			return false;
		}

		public bool HardwareDynamicResIsEnabled()
		{
			return false;
		}

		public bool RequestsHardwareDynamicResolution()
		{
			return false;
		}

		public bool DynamicResolutionEnabled()
		{
			return false;
		}

		public void ForceSoftwareFallback()
		{
		}

		public Vector2Int GetScaledSize(Vector2Int size)
		{
			return default(Vector2Int);
		}

		public float GetCurrentScale()
		{
			return 0f;
		}

		public Vector2Int GetLastScaledSize()
		{
			return default(Vector2Int);
		}
	}
}
