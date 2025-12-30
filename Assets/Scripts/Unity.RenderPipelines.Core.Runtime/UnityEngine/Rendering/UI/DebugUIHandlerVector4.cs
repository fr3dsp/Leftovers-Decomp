using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerVector4 : DebugUIHandlerWidget
	{
		public Text nameLabel;

		public UIFoldout valueToggle;

		public DebugUIHandlerIndirectFloatField fieldX;

		public DebugUIHandlerIndirectFloatField fieldY;

		public DebugUIHandlerIndirectFloatField fieldZ;

		public DebugUIHandlerIndirectFloatField fieldW;

		private DebugUI.Vector4Field m_Field;

		private DebugUIHandlerContainer m_Container;

		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		private void SetValue(float v, bool x = false, bool y = false, bool z = false, bool w = false)
		{
		}

		private void SetupSettings(DebugUIHandlerIndirectFloatField field)
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
