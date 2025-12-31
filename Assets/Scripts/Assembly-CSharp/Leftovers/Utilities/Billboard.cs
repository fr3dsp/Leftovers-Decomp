using System;
using UnityEngine;

namespace Leftovers.Utilities
{
	public class Billboard : MonoBehaviour
	{
		private void LateUpdate()
		{
            Camera cam = Camera.main;
            if (cam == null)
                return;

            Transform camTransform = cam.transform;
            if (camTransform == null)
                return;

            Vector3 targetPosition = camTransform.position;

            if (onlyXZ)
            {
                Transform selfTransform = transform;
                if (selfTransform == null)
                    return;

                targetPosition.y = selfTransform.position.y;
            }

            Transform t = transform;
            if (t == null)
                return;

            t.LookAt(targetPosition);
        }

		public Billboard()
		{
            this.onlyXZ = true;
            this.overTimeSpeed = 1.0f;
        }

		[SerializeField]
		private bool onlyXZ;

		[SerializeField]
		private bool overTime;

		[SerializeField]
		private float overTimeSpeed;
	}
}
