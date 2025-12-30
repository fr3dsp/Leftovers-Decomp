using System.Collections;
using TMPro;
using UnityEngine;

namespace Leftovers.UI
{
	public class LeftoverCounter : MonoBehaviour
	{
		[SerializeField]
		private Color originalColor;

		[SerializeField]
		private Color flashColor;

		[SerializeField]
		private Color endColor;

		[SerializeField]
		private float originalSize;

		[SerializeField]
		private float flashSize;

		[SerializeField]
		private float flashDuration;

		[SerializeField]
		private float returnDuration;

		[SerializeField]
		private string endCounter;

		[SerializeField]
		private string startCounter;

		[SerializeField]
		private TMP_Text textCounter;

		private Coroutine flashCoroutine;

		public void SetCounter(string text)
		{
		}

		private IEnumerator FlashText(Color startColor, Color endColor)
		{
			return null;
		}
	}
}
