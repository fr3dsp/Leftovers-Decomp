using System.Collections;
using UnityEngine;

namespace Leftovers.General
{
    public class Interactor : MonoBehaviour
    {
        public static Interactor Instance { get; private set; }

        [SerializeField] private float raycastDistance = 3f;
        [SerializeField] private LayerMask raycastMask;
        [SerializeField] private Animator animator;
        [SerializeField] private Camera cameraRaycast;
        [SerializeField] private GameObject cursor;

        private Vector3 screenCenter;
        private bool lockedInteraction;
        private Hoverable currentDetectedObject;

        private static readonly int HashTriggerKnock = Animator.StringToHash("Knock");

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            screenCenter = new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0f);
        }

        private void OnDestroy()
        {
            if (Instance == this)
                Instance = null;
        }

        private void Update()
        {
            if (cursor != null)
                cursor.SetActive(!lockedInteraction);

            if (lockedInteraction || cameraRaycast == null)
                return;

            Hoverable hoverable = null;
            Ray ray = cameraRaycast.ScreenPointToRay(screenCenter);

            if (Physics.Raycast(ray, out RaycastHit hit, raycastDistance, raycastMask))
            {
                if (hit.collider != null)
                    hoverable = hit.collider.GetComponent<Hoverable>();
            }

            HandleHoverable(hoverable);

            if (Input.GetMouseButtonDown(0))
                HandleInteractable();
        }

        private void HandleHoverable(Hoverable hoverable)
        {
            if (currentDetectedObject == hoverable)
                return;

            if (currentDetectedObject != null)
                currentDetectedObject.StopHover();

            currentDetectedObject = hoverable;

            if (currentDetectedObject != null)
                currentDetectedObject.StartHover();
        }

        private void HandleInteractable()
        {
            if (currentDetectedObject == null)
                return;

            Interactable interactable = currentDetectedObject as Interactable;
            if (interactable == null)
                return;

            LockInteraction();
            interactable.StartInteract();

            if (animator != null && interactable.AnimationType != InteractionAnimationType.None)
            {
                var player = Player.PlayerController.Instance;
                if (player != null)
                {
                    player.handleKeyboardInput = false;
                    Cursor.lockState = CursorLockMode.None;
                }

                animator.SetTrigger(HashTriggerKnock);
                StartCoroutine(FinishAnimation(interactable.animationDuration));
            }
        }

        private IEnumerator FinishAnimation(float duration)
        {
            yield return new WaitForSeconds(duration);

            var player = Player.PlayerController.Instance;
            if (player != null)
            {
                player.handleKeyboardInput = true;
                Cursor.lockState = CursorLockMode.Locked;
            }

            UnlockInteraction();
        }

        public void LockInteraction()
        {
            lockedInteraction = true;

            if (currentDetectedObject != null)
            {
                currentDetectedObject.StopHover();
                currentDetectedObject = null;
            }
        }

        public void UnlockInteraction()
        {
            lockedInteraction = false;
        }
    }
}