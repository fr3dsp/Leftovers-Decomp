using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Utilities
{
    public class Tween : MonoBehaviour
    {
        [SerializeField] private float tweenDuration = 1f;
        [SerializeField] private bool enableOnStart = true;
        [SerializeField] private bool disableOnEnd = false;
        [SerializeField] private Transform objectToTween;
        [SerializeField] private Transform positionFrom;
        [SerializeField] private Transform positionTo;
        [SerializeField] private UnityEvent onTweenStart;
        [SerializeField] private UnityEvent onTweenEnd;

        /// <summary>
        /// Starts the tween coroutine.
        /// </summary>
        public void StartTween()
        {
            StartCoroutine(Tweening());
        }

        private IEnumerator Tweening()
        {
            if (objectToTween == null)
                yield break;

            Debug.Log(name + " Tween start");
            onTweenStart?.Invoke();

            if (enableOnStart)
                objectToTween.gameObject.SetActive(true);

            float timer = 0f;
            Vector3 startPos = positionFrom?.position ?? objectToTween.position;
            Vector3 endPos = positionTo?.position ?? startPos;

            while (timer < tweenDuration)
            {
                timer += Time.deltaTime;
                float t = Mathf.Clamp01(timer / tweenDuration);
                objectToTween.position = Vector3.Lerp(startPos, endPos, t);
                yield return null;
            }

            // Ensure final position
            objectToTween.position = endPos;

            if (disableOnEnd)
                objectToTween.gameObject.SetActive(false);

            onTweenEnd?.Invoke();
            Debug.Log(name + " Tween end");
        }
    }
}
