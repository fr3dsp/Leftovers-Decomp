using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.Universal
{
	[DisallowMultipleComponent]
	public class PixelPerfectCamera : MonoBehaviour, IPixelPerfectCamera
	{
		[SerializeField]
		private int m_AssetsPPU;

		[SerializeField]
		private int m_RefResolutionX;

		[SerializeField]
		private int m_RefResolutionY;

		[SerializeField]
		private bool m_UpscaleRT;

		[SerializeField]
		private bool m_PixelSnapping;

		[SerializeField]
		private bool m_CropFrameX;

		[SerializeField]
		private bool m_CropFrameY;

		[SerializeField]
		private bool m_StretchFill;

		private Camera m_Camera;

		private PixelPerfectCameraInternal m_Internal;

		private bool m_CinemachineCompatibilityMode;

		public int assetsPPU
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int refResolutionX
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int refResolutionY
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool upscaleRT
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool pixelSnapping
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool cropFrameX
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool cropFrameY
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool stretchFill
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int pixelRatio => 0;

		internal bool isRunning => false;

		internal FilterMode finalBlitFilterMode => default(FilterMode);

		internal Vector2Int offscreenRTSize => default(Vector2Int);

		private Vector2Int cameraRTSize => default(Vector2Int);

		public Vector3 RoundToPixel(Vector3 position)
		{
			return default(Vector3);
		}

		public float CorrectCinemachineOrthoSize(float targetOrthoSize)
		{
			return 0f;
		}

		private void PixelSnap()
		{
		}

		private void Awake()
		{
		}

		private void OnBeginFrameRendering(ScriptableRenderContext context, Camera[] cameras)
		{
		}

		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		private void OnEndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		private void OnEnable()
		{
		}

		internal void OnDisable()
		{
		}
	}
}
