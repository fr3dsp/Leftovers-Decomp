using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.General
{
	public class Hoverable : MonoBehaviour
	{
		[SerializeField]
		private string tooltip;

		[SerializeField]
		private UnityEvent onStartHover;

		[SerializeField]
		private UnityEvent onStopHover;

		public void StartHover()
		{
		}

		public void StopHover()
		{
		}
	}
}
