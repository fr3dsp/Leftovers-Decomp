namespace UnityEngine.EventSystems
{
	public class BaseEventData : AbstractEventData
	{
		private readonly EventSystem m_EventSystem;

		public BaseInputModule currentInputModule => null;

		public GameObject selectedObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BaseEventData(EventSystem eventSystem)
		{
		}
	}
}
