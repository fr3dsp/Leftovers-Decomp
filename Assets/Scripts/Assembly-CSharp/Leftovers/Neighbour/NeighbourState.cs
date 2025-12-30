using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Neighbour
{
	public class NeighbourState : MonoBehaviour
	{
		private static readonly int HashBoolPartial;

		private static readonly int HashBoolFull;

		private static readonly int HashBoolAlways;

		private static readonly int HashBoolOpened;

		private static readonly int HashBoolForward;

		private static NeighbourState DebuggedNeighbour;

		[SerializeField]
		private KeyCode debugKeyCode;

		[SerializeField]
		private NeighbourAnimatorControllers animatorControllers;

		[SerializeField]
		private NeighbourDoorAnimationType doorAnimationType;

		[SerializeField]
		private bool isAvailable;

		[SerializeField]
		private float availabilityDelay;

		[SerializeField]
		private string unavailableMessage;

		[SerializeField]
		private float unavailableMessageDuration;

		[SerializeField]
		private Animator animatorDoor;

		[SerializeField]
		private Animator animatorNeighbour;

		[SerializeField]
		private Animator animatorNeighbourFace;

		[SerializeField]
		private AudioSource audioSourceNeighbour;

		[SerializeField]
		private Transform lookAtFace;

		[SerializeField]
		private UnityEvent onReset;

		[SerializeField]
		private UnityEvent onUnavailable;

		[SerializeField]
		private UnityEvent onSpokenTo;

		[SerializeField]
		private UnityEvent onCompleted;

		[SerializeField]
		private UnityEvent onEndConversation;

		[SerializeField]
		private List<DialogueSegment> segments;

		[SerializeField]
		private List<DialoguePrompt> prompts;

		[SerializeField]
		private int indexOpeningSegment;

		[SerializeField]
		private int indexSubsequentSegment;

		private bool spokenTo;

		private int currentSegment;

		private int currentPrompt;

		private void Update()
		{
		}

		public void StartInteract()
		{
		}

		private IEnumerator CheckAvailability()
		{
			return null;
		}

		public void ResetState()
		{
		}

		public void SpokenTo()
		{
		}

		public void Complete()
		{
		}

		public void PrepareConversation()
		{
		}

		public void StartConversation()
		{
		}

		public void GoToSegment(int index)
		{
		}

		private IEnumerator PlaySegment()
		{
			return null;
		}

		private void PlayBodyAnimation(string animation)
		{
		}

		private void PlayFaceAnimation(string animation)
		{
		}

		private void PlayNeighbourSfx(AudioClip clip)
		{
		}

		public void GoToPrompt(int index)
		{
		}

		private void OnNod()
		{
		}

		private void OnShake()
		{
		}

		private void OnShowFood()
		{
		}

		public void TakeFoodFromPlayer()
		{
		}

		public void MakePlayerPutAwayFood()
		{
		}

		public void EndConversation()
		{
		}

		public void SetDoorOpenedState(bool state)
		{
		}

		public void SetNeighbourForwardState(bool state)
		{
		}

		public void SetAvailability(bool state)
		{
		}

		public void SetOpeningSegmentIndex(int index)
		{
		}

		public void SetSubsequentSegmentIndex(int index)
		{
		}

		private void ResetAnimation()
		{
		}
	}
}
