namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerWidget : MonoBehaviour
	{
		[HideInInspector]
		public Color colorDefault;

		[HideInInspector]
		public Color colorSelected;

		protected DebugUI.Widget m_Widget;

		public DebugUIHandlerWidget parentUIHandler { get; set; }

		public DebugUIHandlerWidget previousUIHandler { get; set; }

		public DebugUIHandlerWidget nextUIHandler { get; set; }

		protected virtual void OnEnable()
		{
		}

		internal virtual void SetWidget(DebugUI.Widget widget)
		{
		}

		internal DebugUI.Widget GetWidget()
		{
			return null;
		}

		protected T CastWidget<T>() where T : DebugUI.Widget
		{
			return null;
		}

		public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return false;
		}

		public virtual void OnDeselection()
		{
		}

		public virtual void OnAction()
		{
		}

		public virtual void OnIncrement(bool fast)
		{
		}

		public virtual void OnDecrement(bool fast)
		{
		}

		public virtual DebugUIHandlerWidget Previous()
		{
			return null;
		}

		public virtual DebugUIHandlerWidget Next()
		{
			return null;
		}
	}
}
