using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	public class VertexHelper : IDisposable
	{
		private List<Vector3> m_Positions;

		private List<Color32> m_Colors;

		private List<Vector4> m_Uv0S;

		private List<Vector4> m_Uv1S;

		private List<Vector4> m_Uv2S;

		private List<Vector4> m_Uv3S;

		private List<Vector3> m_Normals;

		private List<Vector4> m_Tangents;

		private List<int> m_Indices;

		private static readonly Vector4 s_DefaultTangent;

		private static readonly Vector3 s_DefaultNormal;

		private bool m_ListsInitalized;

		public int currentVertCount => 0;

		public int currentIndexCount => 0;

		public VertexHelper()
		{
		}

		public VertexHelper(Mesh m)
		{
		}

		private void InitializeListIfRequired()
		{
		}

		public void Dispose()
		{
		}

		public void Clear()
		{
		}

		public void PopulateUIVertex(ref UIVertex vertex, int i)
		{
		}

		public void SetUIVertex(UIVertex vertex, int i)
		{
		}

		public void FillMesh(Mesh mesh)
		{
		}

		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent)
		{
		}

		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent)
		{
		}

		public void AddVert(Vector3 position, Color32 color, Vector4 uv0)
		{
		}

		public void AddVert(UIVertex v)
		{
		}

		public void AddTriangle(int idx0, int idx1, int idx2)
		{
		}

		public void AddUIVertexQuad(UIVertex[] verts)
		{
		}

		public void AddUIVertexStream(List<UIVertex> verts, List<int> indices)
		{
		}

		public void AddUIVertexTriangleStream(List<UIVertex> verts)
		{
		}

		public void GetUIVertexStream(List<UIVertex> stream)
		{
		}
	}
}
