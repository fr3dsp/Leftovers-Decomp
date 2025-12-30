using System.Collections;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerToggleHistory : DebugUIHandlerToggle
	{
		private Toggle[] historyToggles;

		private const float xDecal = 60f;

		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		protected internal override void UpdateValueLabel()
		{
		}

		private IEnumerator RefreshAfterSanitization()
		{
			return null;
		}
	}
}
