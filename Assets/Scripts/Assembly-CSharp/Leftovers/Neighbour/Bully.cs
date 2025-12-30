using UnityEngine;

namespace Leftovers.Neighbour
{
	public class Bully : MonoBehaviour
	{
		[SerializeField]
		private float pushForce;

		[SerializeField]
		private float decaySpeed;

		[SerializeField]
		private Vector3 direction;

		private CharacterController playerController;

		private float currentForce;

		private void OnTriggerEnter(Collider other)
		{
		}

		private void Update()
		{
		}
	}
}
