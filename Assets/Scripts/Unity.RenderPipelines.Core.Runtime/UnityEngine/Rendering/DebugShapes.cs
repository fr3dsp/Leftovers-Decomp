namespace UnityEngine.Rendering
{
	public class DebugShapes
	{
		private static DebugShapes s_Instance;

		private Mesh m_sphereMesh;

		private Mesh m_boxMesh;

		private Mesh m_coneMesh;

		private Mesh m_pyramidMesh;

		public static DebugShapes instance => null;

		private void BuildSphere(ref Mesh outputMesh, float radius, uint longSubdiv, uint latSubdiv)
		{
		}

		private void BuildBox(ref Mesh outputMesh, float length, float width, float height)
		{
		}

		private void BuildCone(ref Mesh outputMesh, float height, float topRadius, float bottomRadius, int nbSides)
		{
		}

		private void BuildPyramid(ref Mesh outputMesh, float width, float height, float depth)
		{
		}

		private void BuildShapes()
		{
		}

		private void RebuildResources()
		{
		}

		public Mesh RequestSphereMesh()
		{
			return null;
		}

		public Mesh RequestBoxMesh()
		{
			return null;
		}

		public Mesh RequestConeMesh()
		{
			return null;
		}

		public Mesh RequestPyramidMesh()
		{
			return null;
		}
	}
}
