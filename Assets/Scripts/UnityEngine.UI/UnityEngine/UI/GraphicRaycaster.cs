using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	public class GraphicRaycaster : BaseRaycaster
	{
		public enum BlockingObjects
		{
			None = 0,
			TwoD = 1,
			ThreeD = 2,
			All = 3
		}

		protected const int kNoEventMaskSet = -1;

		[SerializeField]
		private bool m_IgnoreReversedGraphics;

		[SerializeField]
		private BlockingObjects m_BlockingObjects;

		[SerializeField]
		protected LayerMask m_BlockingMask;

		private Canvas m_Canvas;

		[NonSerialized]
		private List<Graphic> m_RaycastResults;

		[NonSerialized]
		private static readonly List<Graphic> s_SortedGraphics;

		public override int sortOrderPriority => 0;

		public override int renderOrderPriority => 0;

		public bool ignoreReversedGraphics
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public BlockingObjects blockingObjects
		{
			get
			{
				return default(BlockingObjects);
			}
			set
			{
			}
		}

		public LayerMask blockingMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		private Canvas canvas => null;

		public override Camera eventCamera => null;

		protected GraphicRaycaster()
		{
		}

		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
		}
	}
}
