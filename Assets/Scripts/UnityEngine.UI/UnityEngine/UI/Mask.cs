using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier
	{
		[NonSerialized]
		private RectTransform m_RectTransform;

		[SerializeField]
		private bool m_ShowMaskGraphic;

		[NonSerialized]
		private Graphic m_Graphic;

		[NonSerialized]
		private Material m_MaskMaterial;

		[NonSerialized]
		private Material m_UnmaskMaterial;

		public RectTransform rectTransform => null;

		public bool showMaskGraphic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Graphic graphic => null;

		protected Mask()
		{
		}

		public virtual bool MaskEnabled()
		{
			return false;
		}

		[Obsolete]
		public virtual void OnSiblingGraphicEnabledDisabled()
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

		public virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}
	}
}
