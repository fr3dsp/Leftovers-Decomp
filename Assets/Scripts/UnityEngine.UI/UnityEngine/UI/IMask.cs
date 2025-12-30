using System;

namespace UnityEngine.UI
{
	[Obsolete]
	public interface IMask
	{
		RectTransform rectTransform { get; }

		bool Enabled();
	}
}
