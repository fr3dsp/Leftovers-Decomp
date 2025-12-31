using System.Collections;
using TMPro;
using UnityEngine;

namespace Leftovers.UI
{
    public class CreditsMenu : MonoBehaviour
    {
        [SerializeField] private float delay = 10f;
        [SerializeField] private float fadeDuration = 0.5f;
        [SerializeField] private TMP_Text textComponent;

        private void OnEnable()
        {
            if (textComponent != null)
            {
                var c = textComponent.color;
                c.a = 0f;
                textComponent.color = c;
            }

            StartCoroutine(DelayMessage());
        }

        private IEnumerator DelayMessage()
        {
            yield return new WaitForSeconds(delay);

            if (textComponent == null)
                yield break;

            float timer = 0f;
            Color color = textComponent.color;

            while (timer < fadeDuration)
            {
                color.a = Mathf.Lerp(0f, 1f, timer / fadeDuration);
                textComponent.color = color;
                timer += Time.deltaTime;
                yield return null;
            }

            color.a = 1f;
            textComponent.color = color;
        }
    }
}