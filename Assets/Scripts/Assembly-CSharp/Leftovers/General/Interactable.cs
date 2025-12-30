using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.General
{
	public class Interactable : Hoverable
	{
		[SerializeField]
		private UnityEvent onStartInteract;

		[SerializeField]
		private UnityEvent onStopInteract;

		[SerializeField]
		private InteractionAnimationType animationType;

		[SerializeField]
		private bool lockInteraction;

		public InteractionAnimationType AnimationType => default(InteractionAnimationType);

		public void StartInteract()
		{
		}

		public void StopInteract()
		{
		}
	}
}
