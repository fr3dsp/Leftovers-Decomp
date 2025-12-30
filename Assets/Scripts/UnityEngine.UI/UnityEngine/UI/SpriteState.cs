using System;

namespace UnityEngine.UI
{
	[Serializable]
	public struct SpriteState : IEquatable<SpriteState>
	{
		[SerializeField]
		private Sprite m_HighlightedSprite;

		[SerializeField]
		private Sprite m_PressedSprite;

		[SerializeField]
		private Sprite m_SelectedSprite;

		[SerializeField]
		private Sprite m_DisabledSprite;

		public Sprite highlightedSprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Sprite pressedSprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Sprite selectedSprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Sprite disabledSprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Equals(SpriteState other)
		{
			return false;
		}
	}
}
