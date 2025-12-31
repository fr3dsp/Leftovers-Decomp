using System;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.General
{
    public class Hoverable : MonoBehaviour
    {
        [SerializeField] private string tooltip = string.Empty;
        [SerializeField] private UnityEvent onStartHover = new UnityEvent();
        [SerializeField] private UnityEvent onStopHover = new UnityEvent();

        public void StartHover()
        {
            var uiManager = Leftovers.UI.UIManager.Instance;
            if (uiManager == null) return;

            uiManager.SetMessage(tooltip, 0f);
            onStartHover?.Invoke();
        }

        public void StopHover()
        {
            var uiManager = Leftovers.UI.UIManager.Instance;
            if (uiManager == null) return;

            uiManager.SetMessage(string.Empty, 0f);
            onStopHover?.Invoke();
        }
    }
}