using System;

namespace UnityEngine.UI
{
	[Serializable]
	public struct ColorBlock : IEquatable<ColorBlock>
	{
		[SerializeField]
		private Color m_NormalColor;

		[SerializeField]
		private Color m_HighlightedColor;

		[SerializeField]
		private Color m_PressedColor;

		[SerializeField]
		private Color m_SelectedColor;

		[SerializeField]
		private Color m_DisabledColor;

		[SerializeField]
		private float m_ColorMultiplier;

		[SerializeField]
		private float m_FadeDuration;

		public static ColorBlock defaultColorBlock;

		public Color normalColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color highlightedColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color pressedColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color selectedColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color disabledColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float colorMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float fadeDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		static ColorBlock()
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ColorBlock other)
		{
			return false;
		}

		public static bool operator ==(ColorBlock point1, ColorBlock point2)
		{
			return false;
		}

		public static bool operator !=(ColorBlock point1, ColorBlock point2)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
