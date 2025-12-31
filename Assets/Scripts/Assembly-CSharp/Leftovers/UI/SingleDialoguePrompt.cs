using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.UI
{
    public class SingleDialoguePrompt : MonoBehaviour
    {
        [SerializeField] private string message;
        [SerializeField] private float delayMessage;
        [SerializeField] private UnityEvent onStartDialogue;
        [SerializeField] private UnityEvent onCloseDialogue;

        public void ShowDialogue()
        {
            var player = Leftovers.Player.PlayerController.Instance;
            if (player != null)
                player.handleKeyboardInput = false;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            onStartDialogue?.Invoke();
            StartCoroutine(ListenToPrompt());
        }

        private IEnumerator ListenToPrompt()
        {
            yield return new WaitForSeconds(delayMessage);

            var uiManager = UIManager.Instance;
            if (uiManager == null)
                yield break;

            uiManager.SetMessage(message, 0f);
            yield return new WaitForSeconds(1.25f);

            var promptGO = uiManager.promptGameObject;
            if (promptGO != null)
                promptGO.SetActive(true);

            while (!Input.GetMouseButtonDown(0))
                yield return null;

            if (promptGO != null)
                promptGO.SetActive(false);

            uiManager.SetMessage(string.Empty, 0f);

            var player = Player.PlayerController.Instance;
            if (player != null)
            {
                player.pausedKeyboard = true;
                player.pausedMouse = true;
            }

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            onCloseDialogue?.Invoke();
        }

        private void Reset()
        {
            if (onStartDialogue == null)
                onStartDialogue = new UnityEvent();

            if (onCloseDialogue == null)
                onCloseDialogue = new UnityEvent();
        }
    }
}