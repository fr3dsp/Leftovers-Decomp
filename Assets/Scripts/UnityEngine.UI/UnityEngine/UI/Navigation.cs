using System;

namespace UnityEngine.UI
{
	[Serializable]
	public struct Navigation : IEquatable<Navigation>
	{
		[Flags]
		public enum Mode
		{
			None = 0,
			Horizontal = 1,
			Vertical = 2,
			Automatic = 3,
			Explicit = 4
		}

		[SerializeField]
		private Mode m_Mode;

		[SerializeField]
		private bool m_WrapAround;

		[SerializeField]
		private Selectable m_SelectOnUp;

		[SerializeField]
		private Selectable m_SelectOnDown;

		[SerializeField]
		private Selectable m_SelectOnLeft;

		[SerializeField]
		private Selectable m_SelectOnRight;

		public Mode mode
		{
			get
			{
				return default(Mode);
			}
			set
			{
			}
		}

		public bool wrapAround
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Selectable selectOnUp
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Selectable selectOnDown
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Selectable selectOnLeft
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Selectable selectOnRight
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static Navigation defaultNavigation => default(Navigation);

		public bool Equals(Navigation other)
		{
			return false;
		}
	}
}
