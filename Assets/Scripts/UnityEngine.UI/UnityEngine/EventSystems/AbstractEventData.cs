namespace UnityEngine.EventSystems
{
	public abstract class AbstractEventData
	{
		protected bool m_Used;

		public virtual bool used => false;

		public virtual void Reset()
		{
		}

		public virtual void Use()
		{
		}
	}
}
