using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI.CoroutineTween;

namespace UnityEngine.UI
{
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public abstract class Graphic : UIBehaviour, ICanvasElement
	{
		protected static Material s_DefaultUI;

		protected static Texture2D s_WhiteTexture;

		[SerializeField]
		protected Material m_Material;

		[SerializeField]
		private Color m_Color;

		[NonSerialized]
		protected bool m_SkipLayoutUpdate;

		[NonSerialized]
		protected bool m_SkipMaterialUpdate;

		[SerializeField]
		private bool m_RaycastTarget;

		[SerializeField]
		private Vector4 m_RaycastPadding;

		[NonSerialized]
		private RectTransform m_RectTransform;

		[NonSerialized]
		private CanvasRenderer m_CanvasRenderer;

		[NonSerialized]
		private Canvas m_Canvas;

		[NonSerialized]
		private bool m_VertsDirty;

		[NonSerialized]
		private bool m_MaterialDirty;

		[NonSerialized]
		protected UnityAction m_OnDirtyLayoutCallback;

		[NonSerialized]
		protected UnityAction m_OnDirtyVertsCallback;

		[NonSerialized]
		protected UnityAction m_OnDirtyMaterialCallback;

		[NonSerialized]
		protected static Mesh s_Mesh;

		[NonSerialized]
		private static readonly VertexHelper s_VertexHelper;

		[NonSerialized]
		protected Mesh m_CachedMesh;

		[NonSerialized]
		protected Vector2[] m_CachedUvs;

		[NonSerialized]
		private readonly TweenRunner<ColorTween> m_ColorTweenRunner;

		public static Material defaultGraphicMaterial => null;

		public virtual Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public virtual bool raycastTarget
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector4 raycastPadding
		{
			get
			{
				return default(Vector4);
			}
			set
			{
			}
		}

		protected bool useLegacyMeshGeneration { get; set; }

		public int depth => 0;

		public RectTransform rectTransform => null;

		public Canvas canvas => null;

		public CanvasRenderer canvasRenderer => null;

		public virtual Material defaultMaterial => null;

		public virtual Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual Material materialForRendering => null;

		public virtual Texture mainTexture => null;

		protected static Mesh workerMesh => null;

		Transform ICanvasElement.transform => null;

		public virtual void SetAllDirty()
		{
		}

		public virtual void SetLayoutDirty()
		{
		}

		public virtual void SetVerticesDirty()
		{
		}

		public virtual void SetMaterialDirty()
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		protected override void OnBeforeTransformParentChanged()
		{
		}

		protected override void OnTransformParentChanged()
		{
		}

		private void CacheCanvas()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void OnCanvasHierarchyChanged()
		{
		}

		public virtual void OnCullingChanged()
		{
		}

		public virtual void Rebuild(CanvasUpdate update)
		{
		}

		public virtual void LayoutComplete()
		{
		}

		public virtual void GraphicUpdateComplete()
		{
		}

		protected virtual void UpdateMaterial()
		{
		}

		protected virtual void UpdateGeometry()
		{
		}

		private void DoMeshGeneration()
		{
		}

		private void DoLegacyMeshGeneration()
		{
		}

		[Obsolete]
		protected virtual void OnFillVBO(List<UIVertex> vbo)
		{
		}

		[Obsolete]
		protected virtual void OnPopulateMesh(Mesh m)
		{
		}

		protected virtual void OnPopulateMesh(VertexHelper vh)
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}

		public virtual void SetNativeSize()
		{
		}

		public virtual bool Raycast(Vector2 sp, Camera eventCamera)
		{
			return false;
		}

		public Vector2 PixelAdjustPoint(Vector2 point)
		{
			return default(Vector2);
		}

		public Rect GetPixelAdjustedRect()
		{
			return default(Rect);
		}

		public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
		}

		public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB)
		{
		}

		private static Color CreateColorFromAlpha(float alpha)
		{
			return default(Color);
		}

		public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
		}

		public void RegisterDirtyLayoutCallback(UnityAction action)
		{
		}

		public void UnregisterDirtyLayoutCallback(UnityAction action)
		{
		}

		public void RegisterDirtyVerticesCallback(UnityAction action)
		{
		}

		public void UnregisterDirtyVerticesCallback(UnityAction action)
		{
		}

		public void RegisterDirtyMaterialCallback(UnityAction action)
		{
		}

		public void UnregisterDirtyMaterialCallback(UnityAction action)
		{
		}
	}
}
