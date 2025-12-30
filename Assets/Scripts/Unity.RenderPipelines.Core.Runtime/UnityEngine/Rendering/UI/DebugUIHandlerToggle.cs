using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerToggle : DebugUIHandlerWidget
	{
		public Text nameLabel;

		public Toggle valueToggle;

		public Image checkmarkImage;

		protected internal DebugUI.BoolField m_Field;

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

		protected internal virtual void UpdateValueLabel()
		{
		}
	}
}
