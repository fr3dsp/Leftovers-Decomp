using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController
	{
		[SerializeField]
		protected RectOffset m_Padding;

		[SerializeField]
		protected TextAnchor m_ChildAlignment;

		[NonSerialized]
		private RectTransform m_Rect;

		protected DrivenRectTransformTracker m_Tracker;

		private Vector2 m_TotalMinSize;

		private Vector2 m_TotalPreferredSize;

		private Vector2 m_TotalFlexibleSize;

		[NonSerialized]
		private List<RectTransform> m_RectChildren;

		public RectOffset padding
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TextAnchor childAlignment
		{
			get
			{
				return default(TextAnchor);
			}
			set
			{
			}
		}

		protected RectTransform rectTransform => null;

		protected List<RectTransform> rectChildren => null;

		public virtual float minWidth => 0f;

		public virtual float preferredWidth => 0f;

		public virtual float flexibleWidth => 0f;

		public virtual float minHeight => 0f;

		public virtual float preferredHeight => 0f;

		public virtual float flexibleHeight => 0f;

		public virtual int layoutPriority => 0;

		private bool isRootLayoutGroup => false;

		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		public abstract void CalculateLayoutInputVertical();

		public abstract void SetLayoutHorizontal();

		public abstract void SetLayoutVertical();

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}

		protected float GetTotalMinSize(int axis)
		{
			return 0f;
		}

		protected float GetTotalPreferredSize(int axis)
		{
			return 0f;
		}

		protected float GetTotalFlexibleSize(int axis)
		{
			return 0f;
		}

		protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding)
		{
			return 0f;
		}

		protected float GetAlignmentOnAxis(int axis)
		{
			return 0f;
		}

		protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis)
		{
		}

		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos)
		{
		}

		protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor)
		{
		}

		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size)
		{
		}

		protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor)
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		protected virtual void OnTransformChildrenChanged()
		{
		}

		protected void SetProperty<T>(ref T currentValue, T newValue)
		{
		}

		protected void SetDirty()
		{
		}

		private IEnumerator DelayedSetDirty(RectTransform rectTransform)
		{
			return null;
		}
	}
}
