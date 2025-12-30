using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerGroup : DebugUIHandlerWidget
	{
		public Text nameLabel;

		public Transform header;

		private DebugUI.Container m_Field;

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
