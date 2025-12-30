namespace UnityEngine.Rendering
{
	public static class ComponentSingleton<TType> where TType : Component
	{
		private static TType s_Instance;

		public static TType instance => null;

		public static void Release()
		{
		}
	}
}
