using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public class KerningPair
	{
		[SerializeField]
		private uint m_FirstGlyph;

		[SerializeField]
		private GlyphValueRecord_Legacy m_FirstGlyphAdjustments;

		[SerializeField]
		private uint m_SecondGlyph;

		[SerializeField]
		private GlyphValueRecord_Legacy m_SecondGlyphAdjustments;

		public float xOffset;

		internal static KerningPair empty;

		[SerializeField]
		private bool m_IgnoreSpacingAdjustments;

		public uint firstGlyph
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public GlyphValueRecord_Legacy firstGlyphAdjustments => default(GlyphValueRecord_Legacy);

		public uint secondGlyph
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public GlyphValueRecord_Legacy secondGlyphAdjustments => default(GlyphValueRecord_Legacy);

		public bool ignoreSpacingAdjustments => false;

		public KerningPair()
		{
		}

		public KerningPair(uint left, uint right, float offset)
		{
		}

		public KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments)
		{
		}

		internal void ConvertLegacyKerningData()
		{
		}
	}
}
