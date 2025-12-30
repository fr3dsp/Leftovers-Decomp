using System;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	[Serializable]
	public struct TMP_GlyphAdjustmentRecord
	{
		[SerializeField]
		internal uint m_GlyphIndex;

		[SerializeField]
		internal TMP_GlyphValueRecord m_GlyphValueRecord;

		public uint glyphIndex
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public TMP_GlyphValueRecord glyphValueRecord
		{
			get
			{
				return default(TMP_GlyphValueRecord);
			}
			set
			{
			}
		}

		public TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord)
		{
			m_GlyphIndex = 0u;
			m_GlyphValueRecord = default(TMP_GlyphValueRecord);
		}

		internal TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord)
		{
			m_GlyphIndex = 0u;
			m_GlyphValueRecord = default(TMP_GlyphValueRecord);
		}
	}
}
