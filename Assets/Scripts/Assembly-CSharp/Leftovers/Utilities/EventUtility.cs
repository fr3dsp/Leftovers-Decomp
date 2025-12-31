using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Leftovers.Utilities
{
	public class EventUtility : MonoBehaviour
	{
		public void EnablePlayerControls()
		{
            var instance = Leftovers.Player.PlayerController.Instance;
            if (instance == null)
                return;

            instance.handleKeyboardInput = true;
            Cursor.lockState = CursorLockMode.Locked;
        }

		public void DisablePlayerControls()
		{
            var instance = Leftovers.Player.PlayerController.Instance;
            if (instance == null)
                return;

            instance.handleKeyboardInput = false;
            Cursor.lockState = CursorLockMode.None;
        }

		public void EnablePlayerMovement()
		{
            var instance = Leftovers.Player.PlayerController.Instance;
            if (instance == null)
                return;

            instance.handleKeyboardInput = true;
        }

		public void DisablePlayerMovement()
		{
            var instance = Leftovers.Player.PlayerController.Instance;
            if (instance == null)
                return;

            instance.handleKeyboardInput = false;
        }

		public void SetPlayerLookAt(Transform lookAt)
		{
            var instance = Leftovers.Player.PlayerController.Instance;
            if (instance == null)
                return;

            instance.lookAt = lookAt;
        }

		public void StartPlayerZoomIn(float duration)
		{
            var instance = Leftovers.Player.PlayerController.Instance;
            if (instance == null)
                return;

            float zoomAmount = instance.zoomAmount;
            instance.zoomDuration = duration;
            instance.zoomStartAmount = zoomAmount;
            instance.zoomTimer = 0f;
            instance.zoomPhase = 1;
        }

		public void StartPlayerZoomOut(float duration)
		{
            var instance = Leftovers.Player.PlayerController.Instance;
            if (instance == null)
                return;

            Debug.Log("Starting player zoom out");

            float zoomAmount = instance.zoomAmount;
            instance.zoomDuration = duration;
            instance.zoomStartAmount = zoomAmount;
            instance.zoomTimer = 0f;
            instance.zoomPhase = 2;
        }

		public void ClearPlayerLookAt()
		{
            var instance = Leftovers.Player.PlayerController.Instance;
            if (instance == null)
                return;

            instance.lookAt = null;
        }

		public void CopyCameraTransform(Transform copier)
		{
            var instance = Leftovers.Player.PlayerController.Instance;
            if (instance == null || instance.cameraContainer == null || copier == null)
                return;

            copier.position = instance.cameraContainer.position;
            copier.rotation = instance.cameraContainer.rotation;
        }

		public void ResumeGame()
		{
            var instance = Leftovers.Player.PlayerController.Instance;
            if (instance == null || instance.pauseMenu == null)
                return;

            if (instance.pausedMouse)
            {
                instance.handleMouseInput = true;
                Cursor.lockState = CursorLockMode.Locked;
            }

            if (instance.pausedKeyboard)
            {
                instance.handleKeyboardInput = true;
            }

            Time.timeScale = 1f;
            instance.pauseMenu.SetActive(false);
        }

		public void QuitGame()
		{
            Application.Quit();
        }

		public void RestartGame()
		{
            SceneManager.LoadScene(0);
        }

		public void SetMouseSensitivity(float value)
		{
            Leftovers.Player.PlayerController.MouseSensitivity = value;
        }

		public void SetVolume(float value)
		{
            AudioListener.volume = value;
        }

		public EventUtility()
		{
		}
	}
}
