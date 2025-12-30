using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerColor : DebugUIHandlerWidget
	{
		public Text nameLabel;

		public UIFoldout valueToggle;

		public Image colorImage;

		public DebugUIHandlerIndirectFloatField fieldR;

		public DebugUIHandlerIndirectFloatField fieldG;

		public DebugUIHandlerIndirectFloatField fieldB;

		public DebugUIHandlerIndirectFloatField fieldA;

		private DebugUI.ColorField m_Field;

		private DebugUIHandlerContainer m_Container;

		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		private void SetValue(float x, bool r = false, bool g = false, bool b = false, bool a = false)
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

		internal void UpdateColor()
		{
		}

		public override DebugUIHandlerWidget Next()
		{
			return null;
		}
	}
}
