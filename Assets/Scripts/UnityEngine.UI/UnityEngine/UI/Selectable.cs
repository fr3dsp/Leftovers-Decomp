using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[ExecuteAlways]
	[SelectionBase]
	[DisallowMultipleComponent]
	public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
	{
		public enum Transition
		{
			None = 0,
			ColorTint = 1,
			SpriteSwap = 2,
			Animation = 3
		}

		protected enum SelectionState
		{
			Normal = 0,
			Highlighted = 1,
			Pressed = 2,
			Selected = 3,
			Disabled = 4
		}

		protected static Selectable[] s_Selectables;

		protected static int s_SelectableCount;

		private bool m_EnableCalled;

		[SerializeField]
		private Navigation m_Navigation;

		[SerializeField]
		private Transition m_Transition;

		[SerializeField]
		private ColorBlock m_Colors;

		[SerializeField]
		private SpriteState m_SpriteState;

		[SerializeField]
		private AnimationTriggers m_AnimationTriggers;

		[SerializeField]
		private bool m_Interactable;

		[SerializeField]
		private Graphic m_TargetGraphic;

		private bool m_GroupsAllowInteraction;

		protected int m_CurrentIndex;

		private readonly List<CanvasGroup> m_CanvasGroupCache;

		public static Selectable[] allSelectablesArray => null;

		public static int allSelectableCount => 0;

		[Obsolete]
		public static List<Selectable> allSelectables => null;

		public Navigation navigation
		{
			get
			{
				return default(Navigation);
			}
			set
			{
			}
		}

		public Transition transition
		{
			get
			{
				return default(Transition);
			}
			set
			{
			}
		}

		public ColorBlock colors
		{
			get
			{
				return default(ColorBlock);
			}
			set
			{
			}
		}

		public SpriteState spriteState
		{
			get
			{
				return default(SpriteState);
			}
			set
			{
			}
		}

		public AnimationTriggers animationTriggers
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Graphic targetGraphic
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool interactable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool isPointerInside { get; set; }

		private bool isPointerDown { get; set; }

		private bool hasSelection { get; set; }

		public Image image
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Animator animator => null;

		protected SelectionState currentSelectionState => default(SelectionState);

		public static int AllSelectablesNoAlloc(Selectable[] selectables)
		{
			return 0;
		}

		protected Selectable()
		{
		}

		protected override void Awake()
		{
		}

		protected override void OnCanvasGroupChanged()
		{
		}

		public virtual bool IsInteractable()
		{
			return false;
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnTransformParentChanged()
		{
		}

		private void OnSetProperty()
		{
		}

		protected override void OnDisable()
		{
		}

		protected virtual void InstantClearState()
		{
		}

		protected virtual void DoStateTransition(SelectionState state, bool instant)
		{
		}

		public Selectable FindSelectable(Vector3 dir)
		{
			return null;
		}

		private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir)
		{
			return default(Vector3);
		}

		private void Navigate(AxisEventData eventData, Selectable sel)
		{
		}

		public virtual Selectable FindSelectableOnLeft()
		{
			return null;
		}

		public virtual Selectable FindSelectableOnRight()
		{
			return null;
		}

		public virtual Selectable FindSelectableOnUp()
		{
			return null;
		}

		public virtual Selectable FindSelectableOnDown()
		{
			return null;
		}

		public virtual void OnMove(AxisEventData eventData)
		{
		}

		private void StartColorTween(Color targetColor, bool instant)
		{
		}

		private void DoSpriteSwap(Sprite newSprite)
		{
		}

		private void TriggerAnimation(string triggername)
		{
		}

		protected bool IsHighlighted()
		{
			return false;
		}

		protected bool IsPressed()
		{
			return false;
		}

		private void EvaluateAndTransitionToSelectionState()
		{
		}

		public virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		public virtual void OnPointerUp(PointerEventData eventData)
		{
		}

		public virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		public virtual void OnPointerExit(PointerEventData eventData)
		{
		}

		public virtual void OnSelect(BaseEventData eventData)
		{
		}

		public virtual void OnDeselect(BaseEventData eventData)
		{
		}

		public virtual void Select()
		{
		}
	}
}
