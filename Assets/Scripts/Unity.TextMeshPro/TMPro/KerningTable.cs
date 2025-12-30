using System;
using System.Collections.Generic;

namespace TMPro
{
	[Serializable]
	public class KerningTable
	{
		public List<KerningPair> kerningPairs;

		public void AddKerningPair()
		{
		}

		public int AddKerningPair(uint first, uint second, float offset)
		{
			return 0;
		}

		public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments)
		{
			return 0;
		}

		public void RemoveKerningPair(int left, int right)
		{
		}

		public void RemoveKerningPair(int index)
		{
		}

		public void SortKerningPairs()
		{
		}
	}
}
