using UnityEngine;
using UnityEngine.UI;

namespace Leftovers.UI
{
    public class SettingsMenu : MonoBehaviour
    {
        [SerializeField] private Slider sliderVolume;
        [SerializeField] private Slider sliderMouseSensitivity;

        private void OnEnable()
        {
            if (sliderVolume != null)
                sliderVolume.value = AudioListener.volume;

            if (sliderMouseSensitivity != null)
                sliderMouseSensitivity.value = Leftovers.Player.PlayerController.MouseSensitivity;
        }
    }
}