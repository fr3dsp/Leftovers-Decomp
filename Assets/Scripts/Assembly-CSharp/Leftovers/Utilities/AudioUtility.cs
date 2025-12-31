using System.Collections;
using UnityEngine;

namespace Leftovers.Utilities
{
    public class AudioUtility : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;
        [SerializeField] private float volume = 1.0f;

        public void StartFadeIn(float duration)
        {
            if (audioSource == null) return;

            audioSource.volume = 0f;
            audioSource.Play();
            StartCoroutine(FadeIn(duration));
        }

        private IEnumerator FadeIn(float duration)
        {
            float timer = 0f;
            while (timer < duration)
            {
                timer += Time.deltaTime;
                if (audioSource != null)
                    audioSource.volume = Mathf.Lerp(0f, volume, timer / duration);
                yield return null;
            }
            if (audioSource != null)
                audioSource.volume = volume;
        }

        public void StartFadeOut(float duration)
        {
            if (audioSource == null) return;

            StartCoroutine(FadeOut(duration));
        }

        private IEnumerator FadeOut(float duration)
        {
            if (audioSource == null) yield break;

            float startVolume = audioSource.volume;
            float timer = 0f;

            while (timer < duration)
            {
                timer += Time.deltaTime;
                audioSource.volume = Mathf.Lerp(startVolume, 0f, timer / duration);
                yield return null;
            }

            if (audioSource != null)
            {
                audioSource.volume = 0f;
                audioSource.Stop();
            }
        }

        public void PlayIfNotPlaying()
        {
            if (audioSource != null && !audioSource.isPlaying)
                audioSource.Play();
        }
    }
}