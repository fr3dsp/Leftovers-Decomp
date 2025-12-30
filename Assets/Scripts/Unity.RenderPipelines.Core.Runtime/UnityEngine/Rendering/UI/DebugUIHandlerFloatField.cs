using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerFloatField : DebugUIHandlerWidget
	{
		public Text nameLabel;

		public Text valueLabel;

		private DebugUI.FloatField m_Field;

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

		public override void OnIncrement(bool fast)
		{
		}

		public override void OnDecrement(bool fast)
		{
		}

		private void ChangeValue(bool fast, float multiplier)
		{
		}

		private void UpdateValueLabel()
		{
		}
	}
}
