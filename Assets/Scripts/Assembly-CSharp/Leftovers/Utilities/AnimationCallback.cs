using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Utilities
{
	public class AnimationCallback : MonoBehaviour
	{
		[SerializeField]
		private List<UnityEvent> onAnimationEvent;

		public void InvokeAnimationEvent(int index)
		{
		}
	}
}
