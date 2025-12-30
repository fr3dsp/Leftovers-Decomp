using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerPanel : MonoBehaviour
	{
		public Text nameLabel;

		public ScrollRect scrollRect;

		public RectTransform viewport;

		private RectTransform m_ScrollTransform;

		private RectTransform m_ContentTransform;

		private RectTransform m_MaskTransform;

		protected internal DebugUI.Panel m_Panel;

		private void OnEnable()
		{
		}

		internal void SetPanel(DebugUI.Panel panel)
		{
		}

		internal DebugUI.Panel GetPanel()
		{
			return null;
		}

		internal void ScrollTo(DebugUIHandlerWidget target)
		{
		}

		private float GetYPosInScroll(RectTransform target)
		{
			return 0f;
		}

		internal DebugUIHandlerWidget GetFirstItem()
		{
			return null;
		}
	}
}
