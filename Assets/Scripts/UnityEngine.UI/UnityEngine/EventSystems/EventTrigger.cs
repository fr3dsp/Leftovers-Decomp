using System;
using System.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine.EventSystems
{
	public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler
	{
		[Serializable]
		public class TriggerEvent : UnityEvent<BaseEventData>
		{
		}

		[Serializable]
		public class Entry
		{
			public EventTriggerType eventID;

			public TriggerEvent callback;
		}

		[SerializeField]
		private List<Entry> m_Delegates;

		[Obsolete]
		public List<Entry> delegates
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<Entry> triggers
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected EventTrigger()
		{
		}

		private void Execute(EventTriggerType id, BaseEventData eventData)
		{
		}

		public virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		public virtual void OnPointerExit(PointerEventData eventData)
		{
		}

		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		public virtual void OnDrop(PointerEventData eventData)
		{
		}

		public virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		public virtual void OnPointerUp(PointerEventData eventData)
		{
		}

		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		public virtual void OnSelect(BaseEventData eventData)
		{
		}

		public virtual void OnDeselect(BaseEventData eventData)
		{
		}

		public virtual void OnScroll(PointerEventData eventData)
		{
		}

		public virtual void OnMove(AxisEventData eventData)
		{
		}

		public virtual void OnUpdateSelected(BaseEventData eventData)
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

		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		public virtual void OnCancel(BaseEventData eventData)
		{
		}
	}
}
