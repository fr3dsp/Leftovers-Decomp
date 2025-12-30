using System;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	[ExecuteAlways]
	public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
	{
		public enum Direction
		{
			LeftToRight = 0,
			RightToLeft = 1,
			BottomToTop = 2,
			TopToBottom = 3
		}

		[Serializable]
		public class SliderEvent : UnityEvent<float>
		{
		}

		private enum Axis
		{
			Horizontal = 0,
			Vertical = 1
		}

		[SerializeField]
		private RectTransform m_FillRect;

		[SerializeField]
		private RectTransform m_HandleRect;

		[Space]
		[SerializeField]
		private Direction m_Direction;

		[SerializeField]
		private float m_MinValue;

		[SerializeField]
		private float m_MaxValue;

		[SerializeField]
		private bool m_WholeNumbers;

		[SerializeField]
		protected float m_Value;

		[Space]
		[SerializeField]
		private SliderEvent m_OnValueChanged;

		private Image m_FillImage;

		private Transform m_FillTransform;

		private RectTransform m_FillContainerRect;

		private Transform m_HandleTransform;

		private RectTransform m_HandleContainerRect;

		private Vector2 m_Offset;

		private DrivenRectTransformTracker m_Tracker;

		private bool m_DelayedUpdateVisuals;

		public RectTransform fillRect
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public float minValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float maxValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool wholeNumbers
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual float value
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float normalizedValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public SliderEvent onValueChanged
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

		public virtual void SetValueWithoutNotify(float input)
		{
		}

		protected Slider()
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

		protected override void OnDidApplyAnimationProperties()
		{
		}

		private void UpdateCachedReferences()
		{
		}

		private float ClampValue(float input)
		{
			return 0f;
		}

		protected virtual void Set(float input, bool sendCallback = true)
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		private void UpdateVisuals()
		{
		}

		private void UpdateDrag(PointerEventData eventData, Camera cam)
		{
		}

		private bool MayDrag(PointerEventData eventData)
		{
			return false;
		}

		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		public virtual void OnDrag(PointerEventData eventData)
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
