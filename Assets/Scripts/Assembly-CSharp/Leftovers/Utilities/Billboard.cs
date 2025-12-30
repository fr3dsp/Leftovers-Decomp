using UnityEngine;

namespace Leftovers.Utilities
{
	public class Billboard : MonoBehaviour
	{
		[SerializeField]
		private bool onlyXZ;

		[SerializeField]
		private bool overTime;

		[SerializeField]
		private float overTimeSpeed;

		private void LateUpdate()
		{
		}
	}
}
