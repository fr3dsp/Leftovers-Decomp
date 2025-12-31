using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Utilities
{
	public class AnimationCallback : MonoBehaviour
	{
		public void InvokeAnimationEvent(int index)
		{
            if (index < 0)
                return;

            if (onAnimationEvent == null)
                return;

            if (index < onAnimationEvent.Count)
            {
                UnityEvent evt = onAnimationEvent[index];
                if (evt != null)
                    evt.Invoke();
            }
        }

		public AnimationCallback()
		{
            onAnimationEvent = new List<UnityEvent>();
        }

		[SerializeField]
		private List<UnityEvent> onAnimationEvent;
	}
}
