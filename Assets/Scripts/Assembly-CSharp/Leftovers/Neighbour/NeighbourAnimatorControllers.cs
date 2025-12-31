using UnityEngine;

namespace Leftovers.Neighbour
{
    [CreateAssetMenu(fileName = "NeighbourAnimatorControllers", menuName = "Leftovers/Neighbour Animator Controllers")]
    public class NeighbourAnimatorControllers : ScriptableObject
    {
        public RuntimeAnimatorController controllerFullyOpened;
        public RuntimeAnimatorController controllerPartiallyOpened;
        public RuntimeAnimatorController controllerLegless;
        public RuntimeAnimatorController controllerNine;
    }
}