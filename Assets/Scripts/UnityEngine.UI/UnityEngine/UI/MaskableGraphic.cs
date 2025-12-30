using System;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier
	{
		[Serializable]
		public class CullStateChangedEvent : UnityEvent<bool>
		{
		}

		[NonSerialized]
		protected bool m_ShouldRecalculateStencil;

		[NonSerialized]
		protected Material m_MaskMaterial;

		[NonSerialized]
		private RectMask2D m_ParentMask;

		[SerializeField]
		private bool m_Maskable;

		private bool m_IsMaskingGraphic;

		[NonSerialized]
		[Obsolete]
		protected bool m_IncludeForMasking;

		[SerializeField]
		private CullStateChangedEvent m_OnCullStateChanged;

		[NonSerialized]
		[Obsolete]
		protected bool m_ShouldRecalculate;

		[NonSerialized]
		protected int m_StencilValue;

		private readonly Vector3[] m_Corners;

		public CullStateChangedEvent onCullStateChanged
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool maskable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isMaskingGraphic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private Rect rootCanvasRect => default(Rect);

		GameObject IClippable.gameObject => null;

		public virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		public virtual void Cull(Rect clipRect, bool validRect)
		{
		}

		private void UpdateCull(bool cull)
		{
		}

		public virtual void SetClipRect(Rect clipRect, bool validRect)
		{
		}

		public virtual void SetClipSoftness(Vector2 clipSoftness)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnTransformParentChanged()
		{
		}

		[Obsolete]
		public virtual void ParentMaskStateChanged()
		{
		}

		protected override void OnCanvasHierarchyChanged()
		{
		}

		private void UpdateClipParent()
		{
		}

		public virtual void RecalculateClipping()
		{
		}

		public virtual void RecalculateMasking()
		{
		}
	}
}
