using System;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	[Serializable]
	public struct GlyphValueRecord_Legacy
	{
		public float xPlacement;

		public float yPlacement;

		public float xAdvance;

		public float yAdvance;

		internal GlyphValueRecord_Legacy(GlyphValueRecord valueRecord)
		{
			xPlacement = 0f;
			yPlacement = 0f;
			xAdvance = 0f;
			yAdvance = 0f;
		}

		public static GlyphValueRecord_Legacy operator +(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b)
		{
			return default(GlyphValueRecord_Legacy);
		}
	}
}
