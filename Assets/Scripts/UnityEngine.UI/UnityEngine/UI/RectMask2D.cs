using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter
	{
		[NonSerialized]
		private readonly RectangularVertexClipper m_VertexClipper;

		[NonSerialized]
		private RectTransform m_RectTransform;

		[NonSerialized]
		private HashSet<MaskableGraphic> m_MaskableTargets;

		[NonSerialized]
		private HashSet<IClippable> m_ClipTargets;

		[NonSerialized]
		private bool m_ShouldRecalculateClipRects;

		[NonSerialized]
		private List<RectMask2D> m_Clippers;

		[NonSerialized]
		private Rect m_LastClipRectCanvasSpace;

		[NonSerialized]
		private bool m_ForceClip;

		[SerializeField]
		private Vector4 m_Padding;

		[SerializeField]
		private Vector2Int m_Softness;

		[NonSerialized]
		private Canvas m_Canvas;

		private Vector3[] m_Corners;

		public Vector4 padding
		{
			get
			{
				return default(Vector4);
			}
			set
			{
			}
		}

		public Vector2Int softness
		{
			get
			{
				return default(Vector2Int);
			}
			set
			{
			}
		}

		private Canvas Canvas => null;

		public Rect canvasRect => default(Rect);

		public RectTransform rectTransform => null;

		private Rect rootCanvasRect => default(Rect);

		protected RectMask2D()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return false;
		}

		public virtual void PerformClipping()
		{
		}

		public virtual void UpdateClipSoftness()
		{
		}

		public void AddClippable(IClippable clippable)
		{
		}

		public void RemoveClippable(IClippable clippable)
		{
		}

		protected override void OnTransformParentChanged()
		{
		}

		protected override void OnCanvasHierarchyChanged()
		{
		}
	}
}
