namespace TMPro
{
	public struct TMP_Offset
	{
		private float m_Left;

		private float m_Right;

		private float m_Top;

		private float m_Bottom;

		private static readonly TMP_Offset k_ZeroOffset;

		public float left
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float right
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float top
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float bottom
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float horizontal
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float vertical
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static TMP_Offset zero => default(TMP_Offset);

		public TMP_Offset(float left, float right, float top, float bottom)
		{
			m_Left = 0f;
			m_Right = 0f;
			m_Top = 0f;
			m_Bottom = 0f;
		}

		public TMP_Offset(float horizontal, float vertical)
		{
			m_Left = 0f;
			m_Right = 0f;
			m_Top = 0f;
			m_Bottom = 0f;
		}

		public static bool operator ==(TMP_Offset lhs, TMP_Offset rhs)
		{
			return false;
		}

		public static bool operator !=(TMP_Offset lhs, TMP_Offset rhs)
		{
			return false;
		}

		public static TMP_Offset operator *(TMP_Offset a, float b)
		{
			return default(TMP_Offset);
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(TMP_Offset other)
		{
			return false;
		}
	}
}
