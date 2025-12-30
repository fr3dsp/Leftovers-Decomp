using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Leftovers.UI
{
	public class UIManager : MonoBehaviour
	{
		private static UIManager instance;

		[SerializeField]
		private float fadeInDuration;

		[SerializeField]
		private float fadeOutDuration;

		[SerializeField]
		private float fadeInAndOutDelay;

		[SerializeField]
		private Color originalColor;

		[SerializeField]
		private Color fadedColor;

		[SerializeField]
		private TMP_Text messageText;

		[SerializeField]
		private TMP_Text innerMessageText;

		[SerializeField]
		private TMP_Text tooltipText;

		[SerializeField]
		private Image transitionImage;

		[SerializeField]
		private GameObject dialogueClickPrompt;

		private Coroutine clearMessageCoroutine;

		private Coroutine clearInnerMessageCoroutine;

		public static UIManager Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetMessage(string message, float duration = -1f)
		{
		}

		public void SetMessage(string message)
		{
		}

		public void ClearMessage(float delay)
		{
		}

		public void SetInnerMessage(string message, float duration = -1f)
		{
		}

		public void SetInnerMessage(string message)
		{
		}

		public void ClearInnerMessage(float delay)
		{
		}

		public void SetDialogueClickPromptVisibility(bool visibility)
		{
		}

		public void SetTooltip(string message)
		{
		}

		public void FadeIn(UnityAction callback)
		{
		}

		public void FadeIn()
		{
		}

		public void FadeOut(UnityAction callback)
		{
		}

		public void FadeOut()
		{
		}

		public void FadeInAndOut(UnityAction callbackIn, UnityAction callbackOut)
		{
		}

		private IEnumerator FadingIn(UnityAction callback)
		{
			return null;
		}

		private IEnumerator FadingOut(UnityAction callback)
		{
			return null;
		}

		private IEnumerator FadingInAndOut(UnityAction callbackIn, UnityAction callbackOut)
		{
			return null;
		}

		private IEnumerator ShowAndClearMessage(TMP_Text textComponent, string message, float duration)
		{
			return null;
		}

		private IEnumerator DelayedClearMessage(TMP_Text textComponent, float delay)
		{
			return null;
		}

		private IEnumerator DelayedClearInnerMessage(TMP_Text textComponent, float delay)
		{
			return null;
		}
	}
}
