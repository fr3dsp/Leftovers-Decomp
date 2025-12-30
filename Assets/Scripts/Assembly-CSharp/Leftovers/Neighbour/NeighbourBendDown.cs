using System.Collections;
using UnityEngine;

namespace Leftovers.Neighbour
{
	public class NeighbourBendDown : MonoBehaviour
	{
		[SerializeField]
		private bool toBendDown;

		[SerializeField]
		private float bendDownDuration;

		[SerializeField]
		private float straightenDuration;

		[SerializeField]
		private float offsetDistance;

		[SerializeField]
		private Transform face;

		[SerializeField]
		private Transform offsetReference;

		[SerializeField]
		private Transform upperBodyBottom;

		[SerializeField]
		private Transform upperBodyTop;

		[SerializeField]
		private Transform upperBody;

		private Vector3 originalPosition;

		private Vector3 offsetPosition;

		private Transform neighbourHeadPosition;

		private Vector3 facePosition;

		private float offsetAmount;

		private float timer;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void StartBendDown()
		{
		}

		public void StartStraigten()
		{
		}

		private IEnumerator BendDown()
		{
			return null;
		}

		private IEnumerator Straighten()
		{
			return null;
		}

		private void UpdateUpperBody()
		{
		}

		public void MoveFace(float duration)
		{
		}

		public void MoveFaceBack(float duration)
		{
		}

		private IEnumerator MovingFace(float duration, float amount)
		{
			return null;
		}
	}
}
