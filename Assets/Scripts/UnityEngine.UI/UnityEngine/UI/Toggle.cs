using System;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement
	{
		public enum ToggleTransition
		{
			None = 0,
			Fade = 1
		}

		[Serializable]
		public class ToggleEvent : UnityEvent<bool>
		{
		}

		public ToggleTransition toggleTransition;

		public Graphic graphic;

		[SerializeField]
		private ToggleGroup m_Group;

		public ToggleEvent onValueChanged;

		[SerializeField]
		private bool m_IsOn;

		public ToggleGroup group
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isOn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		Transform ICanvasElement.transform => null;

		protected Toggle()
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

		protected override void OnDestroy()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}

		private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue)
		{
		}

		public void SetIsOnWithoutNotify(bool value)
		{
		}

		private void Set(bool value, bool sendCallback = true)
		{
		}

		private void PlayEffect(bool instant)
		{
		}

		protected override void Start()
		{
		}

		private void InternalToggle()
		{
		}

		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		public virtual void OnSubmit(BaseEventData eventData)
		{
		}
	}
}
