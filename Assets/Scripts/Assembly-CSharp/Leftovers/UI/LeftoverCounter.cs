using System.Collections;
using TMPro;
using UnityEngine;

namespace Leftovers.UI
{
    public class LeftoverCounter : MonoBehaviour
    {
        [SerializeField] private Color originalColor = Color.white;
        [SerializeField] private Color flashColor = Color.yellow;
        [SerializeField] private Color endColor = Color.gray;

        [SerializeField] private float originalSize = 36f;
        [SerializeField] private float flashSize = 42f;
        [SerializeField] private float flashDuration = 0.25f;
        [SerializeField] private float returnDuration = 0.25f;

        [SerializeField] private string endCounter = "End";
        [SerializeField] private string startCounter = "Start";

        [SerializeField] private TMP_Text textCounter;

        private Coroutine flashCoroutine;

        public void SetCounter(string text)
        {
            if (textCounter == null)
                return;

            textCounter.text = text;

            if (flashCoroutine != null)
            {
                StopCoroutine(flashCoroutine);
                flashCoroutine = null;
            }

            if (text == endCounter)
            {
                flashCoroutine = StartCoroutine(FlashText(flashColor, endColor));
            }
            else if (text != startCounter)
            {
                flashCoroutine = StartCoroutine(FlashText(flashColor, originalColor));
            }
        }

        private IEnumerator FlashText(Color startColor, Color targetColor)
        {
            float timer = 0f;

            textCounter.fontSize = flashSize;
            textCounter.color = startColor;

            while (timer < flashDuration)
            {
                timer += Time.deltaTime;
                yield return null;
            }

            timer = 0f;

            while (timer < returnDuration)
            {
                float t = timer / returnDuration;
                textCounter.fontSize = Mathf.Lerp(flashSize, originalSize, t);
                textCounter.color = Color.Lerp(startColor, targetColor, t);
                timer += Time.deltaTime;
                yield return null;
            }

            textCounter.fontSize = originalSize;
            textCounter.color = targetColor;
            flashCoroutine = null;
        }
    }
}