using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerEnumField : DebugUIHandlerWidget
	{
		public Text nameLabel;

		public Text valueLabel;

		protected internal DebugUI.EnumField m_Field;

		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return false;
		}

		public override void OnDeselection()
		{
		}

		public override void OnAction()
		{
		}

		public override void OnIncrement(bool fast)
		{
		}

		public override void OnDecrement(bool fast)
		{
		}

		protected virtual void UpdateValueLabel()
		{
		}
	}
}
