using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Utilities
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private float duration = 1f;
        [SerializeField] private UnityEvent onTimerStart;
        [SerializeField] private UnityEvent onTimerEnd;

        public void StartTimer()
        {
            onTimerStart?.Invoke();
            StartCoroutine(UpdateTimer());
        }

        private IEnumerator UpdateTimer()
        {
            yield return new WaitForSeconds(duration);
            onTimerEnd?.Invoke();
        }
    }
}