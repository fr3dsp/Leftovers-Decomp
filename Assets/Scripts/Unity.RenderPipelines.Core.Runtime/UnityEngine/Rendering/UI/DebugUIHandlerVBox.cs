namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerVBox : DebugUIHandlerWidget
	{
		private DebugUIHandlerContainer m_Container;

		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return false;
		}

		public override DebugUIHandlerWidget Next()
		{
			return null;
		}
	}
}
