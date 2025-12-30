using System.Collections.Generic;

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerContainer : MonoBehaviour
	{
		[SerializeField]
		public RectTransform contentHolder;

		internal DebugUIHandlerWidget GetFirstItem()
		{
			return null;
		}

		internal DebugUIHandlerWidget GetLastItem()
		{
			return null;
		}

		internal bool IsDirectChild(DebugUIHandlerWidget widget)
		{
			return false;
		}

		private List<DebugUIHandlerWidget> GetActiveChildren()
		{
			return null;
		}
	}
}
