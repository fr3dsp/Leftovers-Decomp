namespace UnityEngine.Rendering.Universal
{
	public struct RenderTargetHandle
	{
		public static readonly RenderTargetHandle CameraTarget;

		public int id { get; set; }

		private RenderTargetIdentifier rtid { get; set; }

		public RenderTargetHandle(RenderTargetIdentifier renderTargetIdentifier)
		{
			id = 0;
			rtid = default(RenderTargetIdentifier);
		}

		internal static RenderTargetHandle GetCameraTarget(XRPass xr)
		{
			return default(RenderTargetHandle);
		}

		public void Init(string shaderProperty)
		{
		}

		public void Init(RenderTargetIdentifier renderTargetIdentifier)
		{
		}

		public RenderTargetIdentifier Identifier()
		{
			return default(RenderTargetIdentifier);
		}

		public bool HasInternalRenderTargetId()
		{
			return false;
		}

		public bool Equals(RenderTargetHandle other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(RenderTargetHandle c1, RenderTargetHandle c2)
		{
			return false;
		}

		public static bool operator !=(RenderTargetHandle c1, RenderTargetHandle c2)
		{
			return false;
		}
	}
}
