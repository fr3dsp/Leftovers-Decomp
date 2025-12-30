using System;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	[Serializable]
	public struct TMP_GlyphValueRecord
	{
		[SerializeField]
		internal float m_XPlacement;

		[SerializeField]
		internal float m_YPlacement;

		[SerializeField]
		internal float m_XAdvance;

		[SerializeField]
		internal float m_YAdvance;

		public float xPlacement
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float yPlacement
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float xAdvance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float yAdvance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance)
		{
			m_XPlacement = 0f;
			m_YPlacement = 0f;
			m_XAdvance = 0f;
			m_YAdvance = 0f;
		}

		internal TMP_GlyphValueRecord(GlyphValueRecord_Legacy valueRecord)
		{
			m_XPlacement = 0f;
			m_YPlacement = 0f;
			m_XAdvance = 0f;
			m_YAdvance = 0f;
		}

		internal TMP_GlyphValueRecord(GlyphValueRecord valueRecord)
		{
			m_XPlacement = 0f;
			m_YPlacement = 0f;
			m_XAdvance = 0f;
			m_YAdvance = 0f;
		}

		public static TMP_GlyphValueRecord operator +(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b)
		{
			return default(TMP_GlyphValueRecord);
		}
	}
}
