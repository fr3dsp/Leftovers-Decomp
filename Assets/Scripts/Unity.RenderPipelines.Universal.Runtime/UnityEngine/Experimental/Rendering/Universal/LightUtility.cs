using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.Universal
{
	internal static class LightUtility
	{
		private struct ParametricLightMeshVertex
		{
			public float3 position;

			public Color color;

			public static readonly VertexAttributeDescriptor[] VertexLayout;
		}

		private struct SpriteLightMeshVertex
		{
			public Vector3 position;

			public Color color;

			public Vector2 uv;

			public static readonly VertexAttributeDescriptor[] VertexLayout;
		}

		public static bool CheckForChange(int a, ref int b)
		{
			return false;
		}

		public static bool CheckForChange(float a, ref float b)
		{
			return false;
		}

		public static bool CheckForChange(bool a, ref bool b)
		{
			return false;
		}

		public static Bounds GenerateParametricMesh(Mesh mesh, float radius, float falloffDistance, float angle, int sides)
		{
			return default(Bounds);
		}

		public static Bounds GenerateSpriteMesh(Mesh mesh, Sprite sprite)
		{
			return default(Bounds);
		}

		public static List<Vector2> GetFalloffShape(Vector3[] shapePath)
		{
			return null;
		}

		public static Bounds GenerateShapeMesh(Mesh mesh, Vector3[] shapePath, float falloffDistance)
		{
			return default(Bounds);
		}
	}
}
