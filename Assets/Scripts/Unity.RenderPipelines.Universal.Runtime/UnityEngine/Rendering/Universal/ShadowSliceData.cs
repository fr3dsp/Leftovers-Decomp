namespace UnityEngine.Rendering.Universal
{
	public struct ShadowSliceData
	{
		public Matrix4x4 viewMatrix;

		public Matrix4x4 projectionMatrix;

		public Matrix4x4 shadowTransform;

		public int offsetX;

		public int offsetY;

		public int resolution;

		public void Clear()
		{
		}
	}
}
