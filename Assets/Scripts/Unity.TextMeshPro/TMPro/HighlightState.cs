using UnityEngine;

namespace TMPro
{
	public struct HighlightState
	{
		public Color32 color;

		public TMP_Offset padding;

		public HighlightState(Color32 color, TMP_Offset padding)
		{
			this.color = default(Color32);
			this.padding = default(TMP_Offset);
		}

		public static bool operator ==(HighlightState lhs, HighlightState rhs)
		{
			return false;
		}

		public static bool operator !=(HighlightState lhs, HighlightState rhs)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(HighlightState other)
		{
			return false;
		}
	}
}
