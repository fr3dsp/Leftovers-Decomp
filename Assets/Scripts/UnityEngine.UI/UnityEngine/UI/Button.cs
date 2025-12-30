using System;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler
	{
		[Serializable]
		public class ButtonClickedEvent : UnityEvent
		{
		}

		[SerializeField]
		private ButtonClickedEvent m_OnClick;

		public ButtonClickedEvent onClick
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected Button()
		{
		}

		private void Press()
		{
		}

		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		private IEnumerator OnFinishSubmit()
		{
			return null;
		}
	}
}
