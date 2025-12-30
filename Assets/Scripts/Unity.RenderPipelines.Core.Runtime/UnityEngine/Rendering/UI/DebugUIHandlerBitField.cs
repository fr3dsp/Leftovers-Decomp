using System.Collections.Generic;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerBitField : DebugUIHandlerWidget
	{
		public Text nameLabel;

		public UIFoldout valueToggle;

		public List<DebugUIHandlerIndirectToggle> toggles;

		private DebugUI.BitField m_Field;

		private DebugUIHandlerContainer m_Container;

		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		private bool GetValue(int index)
		{
			return false;
		}

		private void SetValue(int index, bool value)
		{
		}

		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return false;
		}

		public override void OnDeselection()
		{
		}

		public override void OnIncrement(bool fast)
		{
		}

		public override void OnDecrement(bool fast)
		{
		}

		public override void OnAction()
		{
		}

		public override DebugUIHandlerWidget Next()
		{
			return null;
		}
	}
}
