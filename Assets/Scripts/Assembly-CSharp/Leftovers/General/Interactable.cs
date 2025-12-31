using System;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.General
{
    public class Interactable : Hoverable
    {
        [SerializeField] private InteractionAnimationType animationType = InteractionAnimationType.None;
        [SerializeField] private bool lockInteraction;
        public float animationDuration = 1f;

        [SerializeField] private UnityEvent onStartInteract = new UnityEvent();
        [SerializeField] private UnityEvent onStopInteract = new UnityEvent();

        public InteractionAnimationType AnimationType => animationType;
        public float AnimationDuration => animationDuration;

        public void StartInteract()
        {
            if (lockInteraction)
            {
                var interactor = Interactor.Instance;
                if (interactor != null)
                {
                    interactor.LockInteraction();
                }
            }

            onStartInteract?.Invoke();
        }

        public void StopInteract()
        {
            if (lockInteraction)
            {
                var interactor = Interactor.Instance;
                if (interactor != null)
                {
                    interactor.UnlockInteraction();
                }
            }

            onStopInteract?.Invoke();
        }
    }
}