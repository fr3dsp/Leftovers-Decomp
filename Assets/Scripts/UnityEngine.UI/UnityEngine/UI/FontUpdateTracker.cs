using System.Collections.Generic;

namespace UnityEngine.UI
{
	public static class FontUpdateTracker
	{
		private static Dictionary<Font, HashSet<Text>> m_Tracked;

		public static void TrackText(Text t)
		{
		}

		private static void RebuildForFont(Font f)
		{
		}

		public static void UntrackText(Text t)
		{
		}
	}
}
