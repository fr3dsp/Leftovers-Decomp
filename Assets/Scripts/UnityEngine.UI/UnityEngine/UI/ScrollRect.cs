using System;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	[SelectionBase]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController
	{
		public enum MovementType
		{
			Unrestricted = 0,
			Elastic = 1,
			Clamped = 2
		}

		public enum ScrollbarVisibility
		{
			Permanent = 0,
			AutoHide = 1,
			AutoHideAndExpandViewport = 2
		}

		[Serializable]
		public class ScrollRectEvent : UnityEvent<Vector2>
		{
		}

		[SerializeField]
		private RectTransform m_Content;

		[SerializeField]
		private bool m_Horizontal;

		[SerializeField]
		private bool m_Vertical;

		[SerializeField]
		private MovementType m_MovementType;

		[SerializeField]
		private float m_Elasticity;

		[SerializeField]
		private bool m_Inertia;

		[SerializeField]
		private float m_DecelerationRate;

		[SerializeField]
		private float m_ScrollSensitivity;

		[SerializeField]
		private RectTransform m_Viewport;

		[SerializeField]
		private Scrollbar m_HorizontalScrollbar;

		[SerializeField]
		private Scrollbar m_VerticalScrollbar;

		[SerializeField]
		private ScrollbarVisibility m_HorizontalScrollbarVisibility;

		[SerializeField]
		private ScrollbarVisibility m_VerticalScrollbarVisibility;

		[SerializeField]
		private float m_HorizontalScrollbarSpacing;

		[SerializeField]
		private float m_VerticalScrollbarSpacing;

		[SerializeField]
		private ScrollRectEvent m_OnValueChanged;

		private Vector2 m_PointerStartLocalCursor;

		protected Vector2 m_ContentStartPosition;

		private RectTransform m_ViewRect;

		protected Bounds m_ContentBounds;

		private Bounds m_ViewBounds;

		private Vector2 m_Velocity;

		private bool m_Dragging;

		private bool m_Scrolling;

		private Vector2 m_PrevPosition;

		private Bounds m_PrevContentBounds;

		private Bounds m_PrevViewBounds;

		[NonSerialized]
		private bool m_HasRebuiltLayout;

		private bool m_HSliderExpand;

		private bool m_VSliderExpand;

		private float m_HSliderHeight;

		private float m_VSliderWidth;

		[NonSerialized]
		private RectTransform m_Rect;

		private RectTransform m_HorizontalScrollbarRect;

		private RectTransform m_VerticalScrollbarRect;

		private DrivenRectTransformTracker m_Tracker;

		private readonly Vector3[] m_Corners;

		public RectTransform content
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool horizontal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool vertical
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MovementType movementType
		{
			get
			{
				return default(MovementType);
			}
			set
			{
			}
		}

		public float elasticity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool inertia
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float decelerationRate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float scrollSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public RectTransform viewport
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Scrollbar horizontalScrollbar
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Scrollbar verticalScrollbar
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ScrollbarVisibility horizontalScrollbarVisibility
		{
			get
			{
				return default(ScrollbarVisibility);
			}
			set
			{
			}
		}

		public ScrollbarVisibility verticalScrollbarVisibility
		{
			get
			{
				return default(ScrollbarVisibility);
			}
			set
			{
			}
		}

		public float horizontalScrollbarSpacing
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float verticalScrollbarSpacing
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public ScrollRectEvent onValueChanged
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected RectTransform viewRect => null;

		public Vector2 velocity
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		private RectTransform rectTransform => null;

		public Vector2 normalizedPosition
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float horizontalNormalizedPosition
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float verticalNormalizedPosition
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private bool hScrollingNeeded => false;

		private bool vScrollingNeeded => false;

		public virtual float minWidth => 0f;

		public virtual float preferredWidth => 0f;

		public virtual float flexibleWidth => 0f;

		public virtual float minHeight => 0f;

		public virtual float preferredHeight => 0f;

		public virtual float flexibleHeight => 0f;

		public virtual int layoutPriority => 0;

		Transform ICanvasElement.transform => null;

		protected ScrollRect()
		{
		}

		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		public virtual void LayoutComplete()
		{
		}

		public virtual void GraphicUpdateComplete()
		{
		}

		private void UpdateCachedData()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public override bool IsActive()
		{
			return false;
		}

		private void EnsureLayoutHasRebuilt()
		{
		}

		public virtual void StopMovement()
		{
		}

		public virtual void OnScroll(PointerEventData data)
		{
		}

		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		protected virtual void SetContentAnchoredPosition(Vector2 position)
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected void UpdatePrevData()
		{
		}

		private void UpdateScrollbars(Vector2 offset)
		{
		}

		private void SetHorizontalNormalizedPosition(float value)
		{
		}

		private void SetVerticalNormalizedPosition(float value)
		{
		}

		protected virtual void SetNormalizedPosition(float value, int axis)
		{
		}

		private static float RubberDelta(float overStretching, float viewSize)
		{
			return 0f;
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		public virtual void CalculateLayoutInputVertical()
		{
		}

		public virtual void SetLayoutHorizontal()
		{
		}

		public virtual void SetLayoutVertical()
		{
		}

		private void UpdateScrollbarVisibility()
		{
		}

		private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar)
		{
		}

		private void UpdateScrollbarLayout()
		{
		}

		protected void UpdateBounds()
		{
		}

		internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos)
		{
		}

		private Bounds GetBounds()
		{
			return default(Bounds);
		}

		internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix)
		{
			return default(Bounds);
		}

		private Vector2 CalculateOffset(Vector2 delta)
		{
			return default(Vector2);
		}

		internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, MovementType movementType, ref Vector2 delta)
		{
			return default(Vector2);
		}

		protected void SetDirty()
		{
		}

		protected void SetDirtyCaching()
		{
		}
	}
}
