namespace TMPro
{
	public struct GlyphPairKey
	{
		public uint firstGlyphIndex;

		public uint secondGlyphIndex;

		public uint key;

		public GlyphPairKey(uint firstGlyphIndex, uint secondGlyphIndex)
		{
			this.firstGlyphIndex = 0u;
			this.secondGlyphIndex = 0u;
			key = 0u;
		}

		internal GlyphPairKey(TMP_GlyphPairAdjustmentRecord record)
		{
			firstGlyphIndex = 0u;
			secondGlyphIndex = 0u;
			key = 0u;
		}
	}
}
