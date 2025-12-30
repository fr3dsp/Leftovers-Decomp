namespace UnityEngine.Rendering
{
	public class MousePositionDebug
	{
		private static MousePositionDebug s_Instance;

		public static MousePositionDebug instance => null;

		public void Build()
		{
		}

		public void Cleanup()
		{
		}

		public Vector2 GetMousePosition(float ScreenHeight, bool sceneView)
		{
			return default(Vector2);
		}

		private Vector2 GetInputMousePosition()
		{
			return default(Vector2);
		}

		public Vector2 GetMouseClickPosition(float ScreenHeight)
		{
			return default(Vector2);
		}
	}
}
