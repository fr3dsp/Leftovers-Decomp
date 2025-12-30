using System;
using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
	public abstract class BaseRaycaster : UIBehaviour
	{
		private BaseRaycaster m_RootRaycaster;

		public abstract Camera eventCamera { get; }

		[Obsolete]
		public virtual int priority => 0;

		public virtual int sortOrderPriority => 0;

		public virtual int renderOrderPriority => 0;

		public BaseRaycaster rootRaycaster => null;

		public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);

		public override string ToString()
		{
			return null;
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnCanvasHierarchyChanged()
		{
		}

		protected override void OnTransformParentChanged()
		{
		}
	}
}
