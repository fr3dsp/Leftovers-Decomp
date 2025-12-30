using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[ExecuteAlways]
	public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer
	{
		[SerializeField]
		private bool m_IgnoreLayout;

		[SerializeField]
		private float m_MinWidth;

		[SerializeField]
		private float m_MinHeight;

		[SerializeField]
		private float m_PreferredWidth;

		[SerializeField]
		private float m_PreferredHeight;

		[SerializeField]
		private float m_FlexibleWidth;

		[SerializeField]
		private float m_FlexibleHeight;

		[SerializeField]
		private int m_LayoutPriority;

		public virtual bool ignoreLayout
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual float minWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual float minHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual float preferredWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual float preferredHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual float flexibleWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual float flexibleHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual int layoutPriority
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		public virtual void CalculateLayoutInputVertical()
		{
		}

		protected LayoutElement()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnTransformParentChanged()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}

		protected override void OnBeforeTransformParentChanged()
		{
		}

		protected void SetDirty()
		{
		}
	}
}
