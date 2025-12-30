using UnityEngine;

namespace Leftovers.Neighbour
{
	[CreateAssetMenu]
	public class NeighbourAnimatorControllers : ScriptableObject
	{
		public RuntimeAnimatorController controllerFullyOpened;

		public RuntimeAnimatorController controllerPartiallyOpened;

		public RuntimeAnimatorController controllerLegless;

		public RuntimeAnimatorController controllerNine;
	}
}
