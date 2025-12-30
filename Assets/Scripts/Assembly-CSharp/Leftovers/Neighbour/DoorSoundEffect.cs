using UnityEngine;

namespace Leftovers.Neighbour
{
	public class DoorSoundEffect : MonoBehaviour
	{
		[SerializeField]
		private AudioSource audioSource;

		[SerializeField]
		private AudioClip sfxDoorOpen;

		[SerializeField]
		private AudioClip sfxDoorClose;

		[SerializeField]
		private AudioClip sfxGrunt;

		public void PlayDoorOpen()
		{
		}

		public void PlayDoorClose()
		{
		}

		public void PlayGrunt()
		{
		}
	}
}
