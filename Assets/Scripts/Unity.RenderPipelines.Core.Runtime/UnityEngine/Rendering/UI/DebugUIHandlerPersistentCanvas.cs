using System.Collections.Generic;

namespace UnityEngine.Rendering.UI
{
	internal class DebugUIHandlerPersistentCanvas : MonoBehaviour
	{
		public RectTransform panel;

		public RectTransform valuePrefab;

		private List<DebugUIHandlerValue> m_Items;

		internal void Toggle(DebugUI.Value widget)
		{
		}

		internal void Clear()
		{
		}
	}
}
