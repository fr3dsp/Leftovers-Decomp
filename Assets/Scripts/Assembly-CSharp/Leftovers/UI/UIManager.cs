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

        [SerializeField] private float fadeInDuration;
        [SerializeField] private float fadeOutDuration;
        [SerializeField] private float fadeInAndOutDelay;
        [SerializeField] private Color originalColor;
        [SerializeField] private Color fadedColor;
        [SerializeField] private TMP_Text messageText;
        [SerializeField] private TMP_Text innerMessageText;
        [SerializeField] private TMP_Text tooltipText;
        [SerializeField] private Image transitionImage;
        [SerializeField] private GameObject dialogueClickPrompt;

        private Coroutine clearMessageCoroutine;
        private Coroutine clearInnerMessageCoroutine;

        public static UIManager Instance
        {
            get => instance;
            private set => instance = value;
        }

        public GameObject promptGameObject => dialogueClickPrompt;

        private void Awake()
        {
            instance = this;
        }

        private void OnDestroy()
        {
            if (instance == this)
                instance = null;
        }

        public void SetMessage(string message, float duration = -1f) { }
        public void SetMessage(string message) => SetMessage(message, -1f);
        public void ClearMessage(float delay) { }
        public void SetInnerMessage(string message, float duration = -1f) { }
        public void SetInnerMessage(string message) => SetInnerMessage(message, -1f);
        public void ClearInnerMessage(float delay) { }
        public void SetDialogueClickPromptVisibility(bool visibility)
        {
            if (dialogueClickPrompt != null)
                dialogueClickPrompt.SetActive(visibility);
        }
        public void SetTooltip(string message) { }
        public void FadeIn(UnityAction callback) { }
        public void FadeIn() { }
        public void FadeOut(UnityAction callback) { }
        public void FadeOut() { }
        public void FadeInAndOut(UnityAction callbackIn, UnityAction callbackOut) { }

        private IEnumerator FadingIn(UnityAction callback) => null;
        public IEnumerator FadingOut(UnityAction callback) => null;
        private IEnumerator FadingInAndOut(UnityAction callbackIn, UnityAction callbackOut) => null;
        private IEnumerator ShowAndClearMessage(TMP_Text textComponent, string message, float duration) => null;
        private IEnumerator DelayedClearMessage(TMP_Text textComponent, float delay) => null;
        private IEnumerator DelayedClearInnerMessage(TMP_Text textComponent, float delay) => null;
    }
}