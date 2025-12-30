namespace UnityEngine.UI
{
	[ExecuteAlways]
	public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup
	{
		[SerializeField]
		protected float m_Spacing;

		[SerializeField]
		protected bool m_ChildForceExpandWidth;

		[SerializeField]
		protected bool m_ChildForceExpandHeight;

		[SerializeField]
		protected bool m_ChildControlWidth;

		[SerializeField]
		protected bool m_ChildControlHeight;

		[SerializeField]
		protected bool m_ChildScaleWidth;

		[SerializeField]
		protected bool m_ChildScaleHeight;

		[SerializeField]
		protected bool m_ReverseArrangement;

		public float spacing
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool childForceExpandWidth
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool childForceExpandHeight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool childControlWidth
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool childControlHeight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool childScaleWidth
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool childScaleHeight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool reverseArrangement
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected void CalcAlongAxis(int axis, bool isVertical)
		{
		}

		protected void SetChildrenAlongAxis(int axis, bool isVertical)
		{
		}

		private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible)
		{
			min = default(float);
			preferred = default(float);
			flexible = default(float);
		}
	}
}
