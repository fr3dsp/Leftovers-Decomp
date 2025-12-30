using System.Collections;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerEnumHistory : DebugUIHandlerEnumField
	{
		private Text[] historyValues;

		private const float xDecal = 60f;

		internal override void SetWidget(DebugUI.Widget widget)
		{
		}

		protected override void UpdateValueLabel()
		{
		}

		private IEnumerator RefreshAfterSanitization()
		{
			return null;
		}
	}
}
