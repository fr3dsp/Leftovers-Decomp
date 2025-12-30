using System;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	[ExecuteAlways]
	public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement
	{
		public enum Direction
		{
			LeftToRight = 0,
			RightToLeft = 1,
			BottomToTop = 2,
			TopToBottom = 3
		}

		[Serializable]
		public class ScrollEvent : UnityEvent<float>
		{
		}

		private enum Axis
		{
			Horizontal = 0,
			Vertical = 1
		}

		[SerializeField]
		private RectTransform m_HandleRect;

		[SerializeField]
		private Direction m_Direction;

		[SerializeField]
		private float m_Value;

		[SerializeField]
		private float m_Size;

		[SerializeField]
		private int m_NumberOfSteps;

		[Space]
		[SerializeField]
		private ScrollEvent m_OnValueChanged;

		private RectTransform m_ContainerRect;

		private Vector2 m_Offset;

		private DrivenRectTransformTracker m_Tracker;

		private Coroutine m_PointerDownRepeat;

		private bool isPointerDownAndNotDragging;

		private bool m_DelayedUpdateVisuals;

		public RectTransform handleRect
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Direction direction
		{
			get
			{
				return default(Direction);
			}
			set
			{
			}
		}

		public float value
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float size
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int numberOfSteps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ScrollEvent onValueChanged
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private float stepSize => 0f;

		private Axis axis => default(Axis);

		private bool reverseValue => false;

		Transform ICanvasElement.transform => null;

		protected Scrollbar()
		{
		}

		public virtual void SetValueWithoutNotify(float input)
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

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		private void UpdateCachedReferences()
		{
		}

		private void Set(float input, bool sendCallback = true)
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		private void UpdateVisuals()
		{
		}

		private void UpdateDrag(PointerEventData eventData)
		{
		}

		private void DoUpdateDrag(Vector2 handleCorner, float remainingSize)
		{
		}

		private bool MayDrag(PointerEventData eventData)
		{
			return false;
		}

		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		protected IEnumerator ClickRepeat(PointerEventData eventData)
		{
			return null;
		}

		protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera)
		{
			return null;
		}

		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		public override void OnMove(AxisEventData eventData)
		{
		}

		public override Selectable FindSelectableOnLeft()
		{
			return null;
		}

		public override Selectable FindSelectableOnRight()
		{
			return null;
		}

		public override Selectable FindSelectableOnUp()
		{
			return null;
		}

		public override Selectable FindSelectableOnDown()
		{
			return null;
		}

		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		public void SetDirection(Direction direction, bool includeRectLayouts)
		{
		}
	}
}
