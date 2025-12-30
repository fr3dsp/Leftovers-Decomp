using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[ExecuteAlways]
	public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		public enum FitMode
		{
			Unconstrained = 0,
			MinSize = 1,
			PreferredSize = 2
		}

		[SerializeField]
		protected FitMode m_HorizontalFit;

		[SerializeField]
		protected FitMode m_VerticalFit;

		[NonSerialized]
		private RectTransform m_Rect;

		private DrivenRectTransformTracker m_Tracker;

		public FitMode horizontalFit
		{
			get
			{
				return default(FitMode);
			}
			set
			{
			}
		}

		public FitMode verticalFit
		{
			get
			{
				return default(FitMode);
			}
			set
			{
			}
		}

		private RectTransform rectTransform => null;

		protected ContentSizeFitter()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		private void HandleSelfFittingAlongAxis(int axis)
		{
		}

		public virtual void SetLayoutHorizontal()
		{
		}

		public virtual void SetLayoutVertical()
		{
		}

		protected void SetDirty()
		{
		}
	}
}
