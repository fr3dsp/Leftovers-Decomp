namespace UnityEngine.Rendering
{
	public class RTHandle
	{
		internal RTHandleSystem m_Owner;

		internal RenderTexture m_RT;

		internal Texture m_ExternalTexture;

		internal RenderTargetIdentifier m_NameID;

		internal bool m_EnableMSAA;

		internal bool m_EnableRandomWrite;

		internal bool m_EnableHWDynamicScale;

		internal string m_Name;

		internal ScaleFunc scaleFunc;

		public Vector2 scaleFactor { get; internal set; }

		public bool useScaling { get; internal set; }

		public Vector2Int referenceSize { get; internal set; }

		public RTHandleProperties rtHandleProperties => default(RTHandleProperties);

		public RenderTexture rt => null;

		public RenderTargetIdentifier nameID => default(RenderTargetIdentifier);

		public string name => null;

		public bool isMSAAEnabled => false;

		internal RTHandle(RTHandleSystem owner)
		{
		}

		public static implicit operator RenderTexture(RTHandle handle)
		{
			return null;
		}

		public static implicit operator Texture(RTHandle handle)
		{
			return null;
		}

		public static implicit operator RenderTargetIdentifier(RTHandle handle)
		{
			return default(RenderTargetIdentifier);
		}

		internal void SetRenderTexture(RenderTexture rt)
		{
		}

		internal void SetTexture(Texture tex)
		{
		}

		internal void SetTexture(RenderTargetIdentifier tex)
		{
		}

		public void Release()
		{
		}

		public Vector2Int GetScaledSize(Vector2Int refSize)
		{
			return default(Vector2Int);
		}

		public void SwitchToFastMemory(CommandBuffer cmd, float residencyFraction = 1f, FastMemoryFlags flags = FastMemoryFlags.SpillTop, bool copyContents = false)
		{
		}

		public void CopyToFastMemory(CommandBuffer cmd, float residencyFraction = 1f, FastMemoryFlags flags = FastMemoryFlags.SpillTop)
		{
		}

		public void SwitchOutFastMemory(CommandBuffer cmd, bool copyContents = true)
		{
		}
	}
}
