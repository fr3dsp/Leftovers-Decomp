using UnityEngine;
using UnityEngine.UI;

namespace Leftovers.UI
{
	public class SettingsMenu : MonoBehaviour
	{
		[SerializeField]
		private Slider sliderVolume;

		[SerializeField]
		private Slider sliderMouseSensitivity;

		private void OnEnable()
		{
		}
	}
}
