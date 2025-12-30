using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Utilities
{
	public class Timer : MonoBehaviour
	{
		[SerializeField]
		private float duration;

		[SerializeField]
		private UnityEvent onTimerStart;

		[SerializeField]
		private UnityEvent onTimerEnd;

		public void StartTimer()
		{
		}

		private IEnumerator UpdateTimer()
		{
			return null;
		}
	}
}
