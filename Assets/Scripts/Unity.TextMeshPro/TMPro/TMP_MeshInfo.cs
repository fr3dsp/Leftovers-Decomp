using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	public struct TMP_MeshInfo
	{
		private static readonly Color32 s_DefaultColor;

		private static readonly Vector3 s_DefaultNormal;

		private static readonly Vector4 s_DefaultTangent;

		private static readonly Bounds s_DefaultBounds;

		public Mesh mesh;

		public int vertexCount;

		public Vector3[] vertices;

		public Vector3[] normals;

		public Vector4[] tangents;

		public Vector2[] uvs0;

		public Vector2[] uvs2;

		public Color32[] colors32;

		public int[] triangles;

		public Material material;

		public TMP_MeshInfo(Mesh mesh, int size)
		{
			this.mesh = null;
			vertexCount = 0;
			vertices = null;
			normals = null;
			tangents = null;
			uvs0 = null;
			uvs2 = null;
			colors32 = null;
			triangles = null;
			material = null;
		}

		public TMP_MeshInfo(Mesh mesh, int size, bool isVolumetric)
		{
			this.mesh = null;
			vertexCount = 0;
			vertices = null;
			normals = null;
			tangents = null;
			uvs0 = null;
			uvs2 = null;
			colors32 = null;
			triangles = null;
			material = null;
		}

		public void ResizeMeshInfo(int size)
		{
		}

		public void ResizeMeshInfo(int size, bool isVolumetric)
		{
		}

		public void Clear()
		{
		}

		public void Clear(bool uploadChanges)
		{
		}

		public void ClearUnusedVertices()
		{
		}

		public void ClearUnusedVertices(int startIndex)
		{
		}

		public void ClearUnusedVertices(int startIndex, bool updateMesh)
		{
		}

		public void SortGeometry(VertexSortingOrder order)
		{
		}

		public void SortGeometry(IList<int> sortingOrder)
		{
		}

		public void SwapVertexData(int src, int dst)
		{
		}
	}
}
