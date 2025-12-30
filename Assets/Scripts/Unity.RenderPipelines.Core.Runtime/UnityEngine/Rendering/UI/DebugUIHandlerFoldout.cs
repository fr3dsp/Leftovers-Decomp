using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerFoldout : DebugUIHandlerWidget
	{
		public Text nameLabel;

		public UIFoldout valueToggle;

		private DebugUI.Foldout m_Field;

		private DebugUIHandlerContainer m_Container;

		private const float xDecal = 60f;

		private const float xDecalInit = 230f;

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

		public override void OnAction()
		{
		}

		private void UpdateValue()
		{
		}

		public override DebugUIHandlerWidget Next()
		{
			return null;
		}
	}
}
