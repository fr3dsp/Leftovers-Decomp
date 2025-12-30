using System.Collections;
using UnityEngine;

namespace Leftovers.General
{
	public class Interactor : MonoBehaviour
	{
		private static readonly int HashTriggerKnock;

		private static Interactor instance;

		[SerializeField]
		private float raycastDistance;

		[SerializeField]
		private LayerMask raycastMask;

		[SerializeField]
		private Animator animator;

		[SerializeField]
		private Camera cameraRaycast;

		[SerializeField]
		private GameObject cursor;

		private Vector3 screenCenter;

		private RaycastHit hitInfo;

		private bool lockedInteraction;

		private Hoverable currentDetectedObject;

		public static Interactor Instance
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

		private void HandleHoverable(Hoverable hoverable)
		{
		}

		private void HandleInteractable()
		{
		}

		private void PlayAnimation(InteractionAnimationType animationType)
		{
		}

		private IEnumerator FinishAnimation(float duration)
		{
			return null;
		}

		public void LockInteraction()
		{
		}

		public void UnlockInteraction()
		{
		}
	}
}
