using UnityEngine;

namespace Leftovers.Utilities
{
	public class Teleportation : MonoBehaviour
	{
		[SerializeField]
		private TransitionType type;

		[SerializeField]
		private Transform teleportationPoint;

		[SerializeField]
		private AudioClip startTeleportSound;

		[SerializeField]
		private AudioClip finishTeleportSound;

		[SerializeField]
		private AudioSource audioSource;

		public void Teleport()
		{
		}
	}
}
