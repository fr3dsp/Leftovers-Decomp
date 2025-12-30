using System;
using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
	[DisallowMultipleComponent]
	public class EventSystem : UIBehaviour
	{
		private List<BaseInputModule> m_SystemInputModules;

		private BaseInputModule m_CurrentInputModule;

		private static List<EventSystem> m_EventSystems;

		[SerializeField]
		private GameObject m_FirstSelected;

		[SerializeField]
		private bool m_sendNavigationEvents;

		[SerializeField]
		private int m_DragThreshold;

		private GameObject m_CurrentSelected;

		private bool m_HasFocus;

		private bool m_SelectionGuard;

		private BaseEventData m_DummyData;

		private static readonly Comparison<RaycastResult> s_RaycastComparer;

		public static EventSystem current
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool sendNavigationEvents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int pixelDragThreshold
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public BaseInputModule currentInputModule => null;

		public GameObject firstSelectedGameObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject currentSelectedGameObject => null;

		[Obsolete]
		public GameObject lastSelectedGameObject => null;

		public bool isFocused => false;

		public bool alreadySelecting => false;

		private BaseEventData baseEventDataCache => null;

		protected EventSystem()
		{
		}

		public void UpdateModules()
		{
		}

		public void SetSelectedGameObject(GameObject selected, BaseEventData pointer)
		{
		}

		public void SetSelectedGameObject(GameObject selected)
		{
		}

		private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs)
		{
			return 0;
		}

		public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults)
		{
		}

		public bool IsPointerOverGameObject()
		{
			return false;
		}

		public bool IsPointerOverGameObject(int pointerId)
		{
			return false;
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void TickModules()
		{
		}

		protected virtual void OnApplicationFocus(bool hasFocus)
		{
		}

		protected virtual void Update()
		{
		}

		private void ChangeEventModule(BaseInputModule module)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
