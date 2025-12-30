using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
	public class PhysicsRaycaster : BaseRaycaster
	{
		private class RaycastHitComparer : IComparer<RaycastHit>
		{
			public static RaycastHitComparer instance;

			public int Compare(RaycastHit x, RaycastHit y)
			{
				return 0;
			}
		}

		protected const int kNoEventMaskSet = -1;

		protected Camera m_EventCamera;

		[SerializeField]
		protected LayerMask m_EventMask;

		[SerializeField]
		protected int m_MaxRayIntersections;

		protected int m_LastMaxRayIntersections;

		private RaycastHit[] m_Hits;

		public override Camera eventCamera => null;

		public virtual int depth => 0;

		public int finalEventMask => 0;

		public LayerMask eventMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public int maxRayIntersections
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected PhysicsRaycaster()
		{
		}

		protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane)
		{
			return false;
		}

		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}
	}
}
