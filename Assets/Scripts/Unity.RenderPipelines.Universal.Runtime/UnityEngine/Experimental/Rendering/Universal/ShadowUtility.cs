using System;
using System.Collections.Generic;
using UnityEngine.Experimental.Rendering.Universal.LibTessDotNet;

namespace UnityEngine.Experimental.Rendering.Universal
{
	internal class ShadowUtility
	{
		internal struct Edge : IComparable<Edge>
		{
			public int vertexIndex0;

			public int vertexIndex1;

			public Vector4 tangent;

			private bool compareReversed;

			public void AssignVertexIndices(int vi0, int vi1)
			{
			}

			public int Compare(Edge a, Edge b)
			{
				return 0;
			}

			public int CompareTo(Edge edgeToCompare)
			{
				return 0;
			}
		}

		private static Edge CreateEdge(int triangleIndexA, int triangleIndexB, List<Vector3> vertices, List<int> triangles)
		{
			return default(Edge);
		}

		private static void PopulateEdgeArray(List<Vector3> vertices, List<int> triangles, List<Edge> edges)
		{
		}

		private static bool IsOutsideEdge(int edgeIndex, List<Edge> edgesToProcess)
		{
			return false;
		}

		private static void SortEdges(List<Edge> edgesToProcess)
		{
		}

		private static void CreateShadowTriangles(List<Vector3> vertices, List<Color> colors, List<int> triangles, List<Vector4> tangents, List<Edge> edges)
		{
		}

		private static object InterpCustomVertexData(Vec3 position, object[] data, float[] weights)
		{
			return null;
		}

		private static void InitializeTangents(int tangentsToAdd, List<Vector4> tangents)
		{
		}

		public static void GenerateShadowMesh(Mesh mesh, Vector3[] shapePath)
		{
		}
	}
}
