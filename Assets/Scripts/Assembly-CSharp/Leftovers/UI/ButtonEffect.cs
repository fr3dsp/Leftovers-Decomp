using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Leftovers.UI
{
    public class ButtonEffect : MonoBehaviour
    {
        [SerializeField] private float hoveredScale = 1.1f;
        [SerializeField] private Color hoveredColor = Color.red;
        [SerializeField] private float effectDuration = 0.15f;

        private TMP_Text textComponent;
        private Color originalColor;
        private float originalScale;
        private Coroutine coroutine;

        private void Awake()
        {
            textComponent = GetComponentInChildren<TMP_Text>();
            if (textComponent != null)
                originalColor = textComponent.color;

            originalScale = transform.localScale.x;

            var trigger = gameObject.AddComponent<EventTrigger>();

            var enter = new EventTrigger.Entry
            {
                eventID = EventTriggerType.PointerEnter
            };
            enter.callback.AddListener(OnPointerEnter);
            trigger.triggers.Add(enter);

            var exit = new EventTrigger.Entry
            {
                eventID = EventTriggerType.PointerExit
            };
            exit.callback.AddListener(OnPointerExit);
            trigger.triggers.Add(exit);
        }

        private void OnEnable()
        {
            ResetVisuals();
        }

        private void OnDisable()
        {
            if (coroutine != null)
            {
                StopCoroutine(coroutine);
                coroutine = null;
            }
        }

        private void OnPointerEnter(BaseEventData data)
        {
            StartEffect(true);
        }

        private void OnPointerExit(BaseEventData data)
        {
            StartEffect(false);
        }

        private void StartEffect(bool hover)
        {
            if (coroutine != null)
                StopCoroutine(coroutine);

            coroutine = StartCoroutine(Animate(hover));
        }

        private IEnumerator Animate(bool hover)
        {
            float time = 0f;

            float startScale = transform.localScale.x;
            float targetScale = hover ? hoveredScale : originalScale;

            Color startColor = textComponent != null ? textComponent.color : Color.white;
            Color targetColor = hover ? hoveredColor : originalColor;

            while (time < effectDuration)
            {
                float t = time / effectDuration;
                float scale = Mathf.Lerp(startScale, targetScale, t);
                transform.localScale = Vector3.one * scale;

                if (textComponent != null)
                    textComponent.color = Color.Lerp(startColor, targetColor, t);

                time += Time.unscaledDeltaTime;
                yield return null;
            }

            transform.localScale = Vector3.one * targetScale;
            if (textComponent != null)
                textComponent.color = targetColor;

            coroutine = null;
        }

        private void ResetVisuals()
        {
            transform.localScale = Vector3.one * originalScale;
            if (textComponent != null)
                textComponent.color = originalColor;
        }
    }
}