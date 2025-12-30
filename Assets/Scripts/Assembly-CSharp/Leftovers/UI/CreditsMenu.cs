using System.Collections;
using TMPro;
using UnityEngine;

namespace Leftovers.UI
{
	public class CreditsMenu : MonoBehaviour
	{
		[SerializeField]
		private float delay;

		[SerializeField]
		private float fadeDuration;

		[SerializeField]
		private TMP_Text textComponent;

		private void OnEnable()
		{
		}

		private IEnumerator DelayMessage()
		{
			return null;
		}
	}
}
