using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
	public class Physics2DRaycaster : PhysicsRaycaster
	{
		private RaycastHit2D[] m_Hits;

		protected Physics2DRaycaster()
		{
		}

		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}
	}
}
