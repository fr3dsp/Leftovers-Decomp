using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Utilities
{
	public class TriggerBox : MonoBehaviour
	{
		[SerializeField]
		private UnityEvent onTriggerEnter;

		[SerializeField]
		private UnityEvent onTriggerExit;

		[SerializeField]
		private UnityEvent ifInContact;

		private int inContact;

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		public void TriggerIfInContact()
		{
		}
	}
}
