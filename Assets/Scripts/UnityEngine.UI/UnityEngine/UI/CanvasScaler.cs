using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class CanvasScaler : UIBehaviour
	{
		public enum ScaleMode
		{
			ConstantPixelSize = 0,
			ScaleWithScreenSize = 1,
			ConstantPhysicalSize = 2
		}

		public enum ScreenMatchMode
		{
			MatchWidthOrHeight = 0,
			Expand = 1,
			Shrink = 2
		}

		public enum Unit
		{
			Centimeters = 0,
			Millimeters = 1,
			Inches = 2,
			Points = 3,
			Picas = 4
		}

		[SerializeField]
		private ScaleMode m_UiScaleMode;

		[SerializeField]
		protected float m_ReferencePixelsPerUnit;

		[SerializeField]
		protected float m_ScaleFactor;

		[SerializeField]
		protected Vector2 m_ReferenceResolution;

		[SerializeField]
		protected ScreenMatchMode m_ScreenMatchMode;

		[SerializeField]
		protected float m_MatchWidthOrHeight;

		private const float kLogBase = 2f;

		[SerializeField]
		protected Unit m_PhysicalUnit;

		[SerializeField]
		protected float m_FallbackScreenDPI;

		[SerializeField]
		protected float m_DefaultSpriteDPI;

		[SerializeField]
		protected float m_DynamicPixelsPerUnit;

		private Canvas m_Canvas;

		[NonSerialized]
		private float m_PrevScaleFactor;

		[NonSerialized]
		private float m_PrevReferencePixelsPerUnit;

		[SerializeField]
		protected bool m_PresetInfoIsWorld;

		public ScaleMode uiScaleMode
		{
			get
			{
				return default(ScaleMode);
			}
			set
			{
			}
		}

		public float referencePixelsPerUnit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float scaleFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 referenceResolution
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public ScreenMatchMode screenMatchMode
		{
			get
			{
				return default(ScreenMatchMode);
			}
			set
			{
			}
		}

		public float matchWidthOrHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Unit physicalUnit
		{
			get
			{
				return default(Unit);
			}
			set
			{
			}
		}

		public float fallbackScreenDPI
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float defaultSpriteDPI
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float dynamicPixelsPerUnit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected CanvasScaler()
		{
		}

		protected override void OnEnable()
		{
		}

		private void Canvas_preWillRenderCanvases()
		{
		}

		protected override void OnDisable()
		{
		}

		protected virtual void Handle()
		{
		}

		protected virtual void HandleWorldCanvas()
		{
		}

		protected virtual void HandleConstantPixelSize()
		{
		}

		protected virtual void HandleScaleWithScreenSize()
		{
		}

		protected virtual void HandleConstantPhysicalSize()
		{
		}

		protected void SetScaleFactor(float scaleFactor)
		{
		}

		protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit)
		{
		}
	}
}
