namespace UnityEngine.UI
{
	internal class ReflectionMethodsCache
	{
		public delegate bool Raycast3DCallback(Ray r, out RaycastHit hit, float f, int i);

		public delegate RaycastHit[] RaycastAllCallback(Ray r, float f, int i);

		public delegate int GetRaycastNonAllocCallback(Ray r, RaycastHit[] results, float f, int i);

		public delegate RaycastHit2D Raycast2DCallback(Vector2 p1, Vector2 p2, float f, int i);

		public delegate RaycastHit2D[] GetRayIntersectionAllCallback(Ray r, float f, int i);

		public delegate int GetRayIntersectionAllNonAllocCallback(Ray r, RaycastHit2D[] results, float f, int i);

		public Raycast3DCallback raycast3D;

		public RaycastAllCallback raycast3DAll;

		public GetRaycastNonAllocCallback getRaycastNonAlloc;

		public Raycast2DCallback raycast2D;

		public GetRayIntersectionAllCallback getRayIntersectionAll;

		public GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc;

		private static ReflectionMethodsCache s_ReflectionMethodsCache;

		public static ReflectionMethodsCache Singleton => null;
	}
}
