using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Player
{
    public class PlayerController : MonoBehaviour
    {
        public static PlayerController Instance { get; private set; }

        public static float MouseSensitivity = 1f;

        private static readonly int HashBoolShowFood = Animator.StringToHash("ShowFood");

        public bool handleKeyboardInput = true;
        public bool handleMouseInput = true;
        [SerializeField] private float moveSpeed = 3f;
        [SerializeField] private float gravity = -9.81f;
        [SerializeField] private float groundCheckRadius = 0.3f;
        [SerializeField] private LayerMask groundCheckLayerMask;
        [SerializeField] private float footstepsInterval = 0.5f;
        [SerializeField] private AudioSource footstepsAudioSource;
        [SerializeField] private AudioClip footstepsAudioClip;
        [SerializeField] private float cameraSpeed = 1f;
        [SerializeField] private Vector2 cameraRotationXLimits = new Vector2(-80f, 80f);
        public float lookAtSpeed = 5f;
        [SerializeField] private float zoomOriginal = 0f;
        [SerializeField] private float zoomIn = 0.3f;
        [SerializeField] private float promptLookSpeed = 5f;
        [SerializeField] private Vector2 promptRotationXLimits = new Vector2(-45f, 45f);
        [SerializeField] private Vector2 promptRotationYLimits = new Vector2(-60f, 60f);
        [SerializeField] private Vector2 noddingThreshold = new Vector2(-15f, 15f);
        [SerializeField] private Vector2 shakingThreshold = new Vector2(-15f, 15f);
        [SerializeField] private CharacterController characterController;
        [SerializeField] private Camera controlledCamera;
        public Transform cameraContainer;
        [SerializeField] private Animator animator;
        [SerializeField] private Transform neighbourLookAt;
        [SerializeField] private GameObject promptIndicator;
        public GameObject pauseMenu;

        private bool listenPrompt;
        public Transform lookAt;
        private float promptRotationX;
        private float promptRotationY;
        private int numberOfShakes;
        private int numberOfNods;
        private Vector3 fallingVelocity;
        private float rotationX;
        private float rotationY;
        public float zoomDuration;
        public float zoomTimer;
        public float zoomStartAmount;
        public float zoomAmount;
        public int zoomPhase;
        private bool paused;
        public bool pausedMouse;
        public bool pausedKeyboard;
        private bool canOpenEscape;
        private Coroutine footstepsCoroutine;

        private UnityEvent OnNod = new UnityEvent();
        private UnityEvent OnShake = new UnityEvent();
        private UnityEvent OnShowFood = new UnityEvent();

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            if (controlledCamera == null || cameraContainer == null)
                return;

            controlledCamera.transform.SetParent(cameraContainer, false);
            controlledCamera.transform.localPosition = Vector3.zero;
            controlledCamera.transform.localRotation = Quaternion.identity;

            rotationY = transform.eulerAngles.y;
            zoomAmount = zoomOriginal;
        }

        private void OnDestroy()
        {
            Cursor.lockState = CursorLockMode.None;
            Instance = null;
        }

        private void Update()
        {
            if (promptIndicator != null)
                promptIndicator.SetActive(listenPrompt);

            float dt = Time.deltaTime;

            HandleMovement(dt);
            HandleLook(dt);
            HandleGravity(dt);
            HandleZoom(dt);
            HandlePause();
        }

        private void HandleMovement(float dt)
        {
            if (!handleKeyboardInput || characterController == null)
                return;

            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 move = (transform.right * h + transform.forward * v) * moveSpeed;
            characterController.Move(move * dt);

            if (move.magnitude > 0.01f && footstepsCoroutine == null)
                footstepsCoroutine = StartCoroutine(PlayFootsteps());
            else if (move.magnitude < 0.01f && footstepsCoroutine != null)
            {
                StopCoroutine(footstepsCoroutine);
                footstepsCoroutine = null;
            }
        }

        private void HandleLook(float dt)
        {
            if (!handleMouseInput)
                return;

            float mouseX = Input.GetAxis("Mouse X") * MouseSensitivity * cameraSpeed;
            float mouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * cameraSpeed;

            rotationX = Mathf.Clamp(rotationX - mouseY, cameraRotationXLimits.x, cameraRotationXLimits.y);
            rotationY += mouseX;

            cameraContainer.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
            transform.rotation = Quaternion.Euler(0f, rotationY, 0f);
        }

        private void HandleGravity(float dt)
        {
            bool grounded = Physics.CheckSphere(transform.position, groundCheckRadius, groundCheckLayerMask);
            if (grounded && fallingVelocity.y < 0)
                fallingVelocity.y = 0;

            fallingVelocity.y += gravity * dt;
            if (characterController != null)
                characterController.Move(fallingVelocity * dt);
        }

        private void HandleZoom(float dt)
        {
            if (zoomPhase == 0 || controlledCamera == null)
                return;

            zoomTimer += dt;
            float t = Mathf.Clamp01(zoomTimer / zoomDuration);

            if (zoomPhase == 1)
                zoomAmount = Mathf.Lerp(zoomStartAmount, zoomIn, t);
            else
                zoomAmount = Mathf.Lerp(zoomStartAmount, zoomOriginal, t);

            if (t >= 1f)
                zoomPhase = 0;

            controlledCamera.transform.localPosition = Vector3.forward * zoomAmount;
        }

        private void HandlePause()
        {
            if (!canOpenEscape || !Input.GetKeyDown(KeyCode.Escape))
                return;

            paused = !paused;
            if (paused)
                PauseGame();
            else
                ResumeGame();
        }

        public void StartZoomIn(float duration)
        {
            zoomStartAmount = zoomAmount;
            zoomDuration = duration;
            zoomTimer = 0f;
            zoomPhase = 1;
        }

        public void StartZoomOut(float duration)
        {
            zoomStartAmount = zoomAmount;
            zoomDuration = duration;
            zoomTimer = 0f;
            zoomPhase = 2;
        }

        public void PauseGame()
        {
            pausedMouse = handleMouseInput;
            pausedKeyboard = handleKeyboardInput;

            handleMouseInput = false;
            handleKeyboardInput = false;

            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;

            if (pauseMenu != null)
                pauseMenu.SetActive(true);
        }

        public void ResumeGame()
        {
            Time.timeScale = 1f;

            handleMouseInput = pausedMouse;
            handleKeyboardInput = pausedKeyboard;

            Cursor.lockState = handleMouseInput ? CursorLockMode.Locked : CursorLockMode.None;

            if (pauseMenu != null)
                pauseMenu.SetActive(false);
        }

        public void CanOpenEscapeMenu()
        {
            canOpenEscape = true;
        }

        public void ResetRotationValues()
        {
            rotationX = 0f;
            rotationY = transform.eulerAngles.y;
        }

        private IEnumerator PlayFootsteps()
        {
            while (true)
            {
                footstepsAudioSource?.PlayOneShot(footstepsAudioClip);
                yield return new WaitForSeconds(footstepsInterval);
            }
        }
    }
}