using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Utilities
{
	public class Tween : MonoBehaviour
	{
		[SerializeField]
		private float tweenDuration;

		[SerializeField]
		private bool enableOnStart;

		[SerializeField]
		private bool disableOnEnd;

		[SerializeField]
		private Transform objectToTween;

		[SerializeField]
		private Transform positionFrom;

		[SerializeField]
		private Transform positionTo;

		[SerializeField]
		private UnityEvent onTweenStart;

		[SerializeField]
		private UnityEvent onTweenEnd;

		public void StartTween()
		{
		}

		private IEnumerator Tweening()
		{
			return null;
		}
	}
}
