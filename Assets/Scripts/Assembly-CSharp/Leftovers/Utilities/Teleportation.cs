using System;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.Utilities
{
    public class Teleportation : MonoBehaviour
    {
        [SerializeField] private TransitionType type;
        [SerializeField] private Transform teleportationPoint;
        [SerializeField] private AudioClip startTeleportSound;
        [SerializeField] private AudioClip finishTeleportSound;
        [SerializeField] private AudioSource audioSource;

        public void Teleport()
        {
            var playerGO = GameObject.FindGameObjectWithTag("Player");
            var player = Leftovers.Player.PlayerController.Instance;

            if (player == null || playerGO == null)
                throw new NullReferenceException("Player or Player GameObject not found.");

            player.handleKeyboardInput = false;
            player.handleMouseInput = false;
            Cursor.lockState = CursorLockMode.None;

            switch (type)
            {
                case TransitionType.Fade: // 0
                    {
                        var ui = Leftovers.UI.UIManager.Instance;
                        if (ui == null) throw new NullReferenceException();

                        ui.FadeInAndOut(
                            () => PerformTeleport(playerGO),
                            () => FinishTeleport(player)
                        );
                        break;
                    }
                case TransitionType.FadeOutInstant: // 1
                    {
                        PerformTeleport(playerGO);

                        var ui = Leftovers.UI.UIManager.Instance;
                        if (ui == null) throw new NullReferenceException();

                        ui.StartCoroutine(ui.FadingOut(() => FinishTeleport(player)));

                        if (audioSource && startTeleportSound)
                            audioSource.PlayOneShot(startTeleportSound);
                        break;
                    }
                case TransitionType.Instant: // 2
                    {
                        PerformTeleport(playerGO);
                        break;
                    }
            }
        }

        private void PerformTeleport(GameObject playerGO)
        {
            var cc = playerGO.GetComponent<CharacterController>();
            if (cc == null) throw new NullReferenceException();

            cc.enabled = false;

            playerGO.transform.position = teleportationPoint.position;
            playerGO.transform.eulerAngles = teleportationPoint.eulerAngles;

            cc.enabled = true;

            var pc = Leftovers.Player.PlayerController.Instance;
            pc?.ResetRotationValues();

            if (audioSource && startTeleportSound)
                audioSource.PlayOneShot(startTeleportSound);
        }

        private void FinishTeleport(Leftovers.Player.PlayerController player)
        {
            if (player == null) return;

            player.handleKeyboardInput = true;
            player.handleMouseInput = true;
            Cursor.lockState = CursorLockMode.Locked;

            if (audioSource && finishTeleportSound)
                audioSource.PlayOneShot(finishTeleportSound);
        }
    }

    public enum TransitionType
    {
        Fade = 0,
        FadeOutInstant = 1,
        Instant = 2
    }
}