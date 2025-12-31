using UnityEngine;

namespace Leftovers.Neighbour
{
    public class Bully : MonoBehaviour
    {
        [SerializeField] private float pushForce = 5f;
        [SerializeField] private float decaySpeed = 5f;
        [SerializeField] private Vector3 direction = Vector3.forward;

        private CharacterController playerController;
        private float currentForce;

        private void OnTriggerEnter(Collider other)
        {
            if (other == null)
                return;

            var controller = other.GetComponent<CharacterController>();
            if (controller == null)
                return;

            playerController = controller;
            currentForce = pushForce;
        }

        private void Update()
        {
            if (playerController == null)
                return;

            if (currentForce > 0f)
            {
                Vector3 move = direction.normalized * currentForce * Time.deltaTime;
                playerController.Move(move);
            }
            else
            {
                playerController = null;
                return;
            }

            currentForce = Mathf.Lerp(currentForce, 0f, Time.deltaTime * decaySpeed);
        }
    }
}