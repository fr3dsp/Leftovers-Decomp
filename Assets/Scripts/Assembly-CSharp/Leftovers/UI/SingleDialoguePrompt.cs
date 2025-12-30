using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.UI
{
	public class SingleDialoguePrompt : MonoBehaviour
	{
		[SerializeField]
		private string message;

		[SerializeField]
		private float delayMessage;

		[SerializeField]
		private UnityEvent onStartDialogue;

		[SerializeField]
		private UnityEvent onCloseDialogue;

		public void ShowDialogue()
		{
		}

		private IEnumerator ListenToPrompt()
		{
			return null;
		}
	}
}
