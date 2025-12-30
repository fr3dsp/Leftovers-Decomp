using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Player
{
	public class PlayerController : MonoBehaviour
	{
		private enum ZoomPhase
		{
			None = 0,
			In = 1,
			Out = 2
		}

		private static readonly int HashBoolShowFood;

		private static PlayerController instance;

		public static float MouseSensitivity;

		private const float PlatformSensitivity = 1f;

		[SerializeField]
		private bool handleKeyboardInput;

		[SerializeField]
		private bool handleMouseInput;

		[SerializeField]
		private float moveSpeed;

		[SerializeField]
		private float gravity;

		[SerializeField]
		private float groundCheckRadius;

		[SerializeField]
		private LayerMask groundCheckLayerMask;

		[SerializeField]
		private float footstepsInterval;

		[SerializeField]
		private AudioSource footstepsAudioSource;

		[SerializeField]
		private AudioClip footstepsAudioClip;

		[SerializeField]
		private float cameraSpeed;

		[SerializeField]
		private Vector2 cameraRotationXLimits;

		[SerializeField]
		private float lookAtSpeed;

		[SerializeField]
		private float neighbourLookAtOffsetHeight;

		[SerializeField]
		private float neighbourLookAtOffsetDistance;

		[SerializeField]
		private float zoomOriginal;

		[SerializeField]
		private float zoomIn;

		[SerializeField]
		private float promptLookSpeed;

		[SerializeField]
		private Vector2 promptRotationXLimits;

		[SerializeField]
		private Vector2 promptRotationYLimits;

		[SerializeField]
		private Vector2 noddingThreshold;

		[SerializeField]
		private Vector2 shakingThreshold;

		[SerializeField]
		private CharacterController characterController;

		[SerializeField]
		private Camera controlledCamera;

		[SerializeField]
		private Transform cameraContainer;

		[SerializeField]
		private Animator animator;

		[SerializeField]
		private Transform neighbourLookAt;

		[SerializeField]
		private GameObject promptIndicator;

		[SerializeField]
		private GameObject pauseMenu;

		[SerializeField]
		private Transform[] shortcutTeleportations;

		private bool listenPrompt;

		private Transform lookAt;

		private float promptRotationX;

		private float promptRotationY;

		private int checkShake;

		private int checkNod;

		private int numberOfShakes;

		private int numberOfNods;

		private UnityEvent OnNod;

		private UnityEvent OnShake;

		private UnityEvent OnShowFood;

		private Vector3 fallingVelocity;

		private float rotationX;

		private float rotationY;

		private ZoomPhase zoomPhase;

		private float zoomDuration;

		private float zoomTimer;

		private float zoomStartAmount;

		private float zoomAmount;

		private bool paused;

		private bool pausedMouse;

		private bool pausedKeyboard;

		private bool canOpenEscape;

		private Coroutine footstepsCoroutine;

		public static PlayerController Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public void ResetRotationValues()
		{
		}

		private float GetLimitedRotationX(float rotation)
		{
			return 0f;
		}

		private void CheckPrompt()
		{
		}

		public void ShowFood()
		{
		}

		public void PutAwayFood()
		{
		}

		public void RemoveFood()
		{
		}

		public void SetLookAt(Transform lookAtTransform)
		{
		}

		public void StartZoomIn(float duration)
		{
		}

		public void StartZoomOut(float duration)
		{
		}

		public void StartHandlingKeyboardInput()
		{
		}

		public void StopHandlingKeyboardInput()
		{
		}

		public void StartHandlingMouseInput()
		{
		}

		public void StopHandlingMouseInput()
		{
		}

		public void StartListeningToPrompt(UnityAction nodListener, UnityAction shakeListener, UnityAction showFoodListener)
		{
		}

		public void StopListeningToPrompt(UnityAction nodListener, UnityAction shakeListener, UnityAction showFoodListener)
		{
		}

		public void CopyCameraTransform(Transform copier)
		{
		}

		public void PauseGame()
		{
		}

		public void ResumeGame()
		{
		}

		public void CanOpenEscapeMenu()
		{
		}

		private IEnumerator PlayFootsteps()
		{
			return null;
		}
	}
}
