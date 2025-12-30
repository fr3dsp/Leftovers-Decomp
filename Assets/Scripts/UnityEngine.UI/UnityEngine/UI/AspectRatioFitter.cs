using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		public enum AspectMode
		{
			None = 0,
			WidthControlsHeight = 1,
			HeightControlsWidth = 2,
			FitInParent = 3,
			EnvelopeParent = 4
		}

		[SerializeField]
		private AspectMode m_AspectMode;

		[SerializeField]
		private float m_AspectRatio;

		[NonSerialized]
		private RectTransform m_Rect;

		private bool m_DelayedSetDirty;

		private bool m_DoesParentExist;

		private DrivenRectTransformTracker m_Tracker;

		public AspectMode aspectMode
		{
			get
			{
				return default(AspectMode);
			}
			set
			{
			}
		}

		public float aspectRatio
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private RectTransform rectTransform => null;

		protected AspectRatioFitter()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnTransformParentChanged()
		{
		}

		protected virtual void Update()
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		private void UpdateRect()
		{
		}

		private float GetSizeDeltaToProduceSize(float size, int axis)
		{
			return 0f;
		}

		private Vector2 GetParentSize()
		{
			return default(Vector2);
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

		public bool IsComponentValidOnObject()
		{
			return false;
		}

		public bool IsAspectModeValid()
		{
			return false;
		}

		private bool DoesParentExists()
		{
			return false;
		}
	}
}
