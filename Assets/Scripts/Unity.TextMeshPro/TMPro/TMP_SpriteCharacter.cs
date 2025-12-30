using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public class TMP_SpriteCharacter : TMP_TextElement
	{
		[SerializeField]
		private string m_Name;

		[SerializeField]
		private int m_HashCode;

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int hashCode => 0;

		public TMP_SpriteCharacter()
		{
		}

		public TMP_SpriteCharacter(uint unicode, TMP_SpriteGlyph glyph)
		{
		}

		public TMP_SpriteCharacter(uint unicode, TMP_SpriteAsset spriteAsset, TMP_SpriteGlyph glyph)
		{
		}

		internal TMP_SpriteCharacter(uint unicode, uint glyphIndex)
		{
		}
	}
}
