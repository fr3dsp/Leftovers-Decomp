using UnityEngine;

namespace Leftovers.Neighbour
{
    public class NeighbourLineRenderers : MonoBehaviour
    {
        [SerializeField] private LineRenderer upperToFaceLine;
        [SerializeField] private Transform upperTop;
        [SerializeField] private Transform faceBottom;

        private void Start()
        {
            if (upperToFaceLine == null)
                return;

            upperToFaceLine.positionCount = 2;
        }

        private void Update()
        {
            if (upperToFaceLine == null || upperTop == null || faceBottom == null)
                return;

            upperToFaceLine.SetPosition(0, upperTop.position);
            upperToFaceLine.SetPosition(1, faceBottom.position);
        }
    }
}