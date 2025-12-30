using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Neighbour
{
	public class NeighbourDialoguePlayer : MonoBehaviour
	{
		[SerializeField]
		private float lookAtDelay;

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
		private UnityEvent onCompleted;

		[SerializeField]
		private UnityEvent onEndConversation;

		[SerializeField]
		private List<DialogueSegment> segments;

		[SerializeField]
		private List<DialoguePrompt> prompts;

		[SerializeField]
		private int indexOpeningSegment;

		private int originalOpeningSegment;

		private int currentSegment;

		private int currentPrompt;

		private void Start()
		{
		}

		public void StartInteract()
		{
		}

		public void ResetState()
		{
		}

		public void Complete()
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

		public void EndConversation()
		{
		}

		public void SetOpeningSegmentIndex(int index)
		{
		}

		private IEnumerator DelayLookAt()
		{
			return null;
		}
	}
}
