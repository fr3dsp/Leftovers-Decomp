using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerValue : DebugUIHandlerWidget
	{
		public Text nameLabel;

		public Text valueLabel;

		private DebugUI.Value m_Field;

		private float m_Timer;

		protected override void OnEnable()
		{
		}

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

		private void Update()
		{
		}
	}
}
