using System;
using System.Collections.Generic;
using UnityEngine.U2D;

namespace UnityEngine.UI
{
	public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter
	{
		public enum Type
		{
			Simple = 0,
			Sliced = 1,
			Tiled = 2,
			Filled = 3
		}

		public enum FillMethod
		{
			Horizontal = 0,
			Vertical = 1,
			Radial90 = 2,
			Radial180 = 3,
			Radial360 = 4
		}

		public enum OriginHorizontal
		{
			Left = 0,
			Right = 1
		}

		public enum OriginVertical
		{
			Bottom = 0,
			Top = 1
		}

		public enum Origin90
		{
			BottomLeft = 0,
			TopLeft = 1,
			TopRight = 2,
			BottomRight = 3
		}

		public enum Origin180
		{
			Bottom = 0,
			Left = 1,
			Top = 2,
			Right = 3
		}

		public enum Origin360
		{
			Bottom = 0,
			Right = 1,
			Top = 2,
			Left = 3
		}

		protected static Material s_ETC1DefaultUI;

		[SerializeField]
		private Sprite m_Sprite;

		[NonSerialized]
		private Sprite m_OverrideSprite;

		[SerializeField]
		private Type m_Type;

		[SerializeField]
		private bool m_PreserveAspect;

		[SerializeField]
		private bool m_FillCenter;

		[SerializeField]
		private FillMethod m_FillMethod;

		[SerializeField]
		private float m_FillAmount;

		[SerializeField]
		private bool m_FillClockwise;

		[SerializeField]
		private int m_FillOrigin;

		private float m_AlphaHitTestMinimumThreshold;

		private bool m_Tracked;

		[SerializeField]
		private bool m_UseSpriteMesh;

		[SerializeField]
		private float m_PixelsPerUnitMultiplier;

		private float m_CachedReferencePixelsPerUnit;

		private static readonly Vector2[] s_VertScratch;

		private static readonly Vector2[] s_UVScratch;

		private static readonly Vector3[] s_Xy;

		private static readonly Vector3[] s_Uv;

		private static List<Image> m_TrackedTexturelessImages;

		private static bool s_Initialized;

		public Sprite sprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Sprite overrideSprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private Sprite activeSprite => null;

		public Type type
		{
			get
			{
				return default(Type);
			}
			set
			{
			}
		}

		public bool preserveAspect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool fillCenter
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public FillMethod fillMethod
		{
			get
			{
				return default(FillMethod);
			}
			set
			{
			}
		}

		public float fillAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool fillClockwise
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int fillOrigin
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[Obsolete]
		public float eventAlphaThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float alphaHitTestMinimumThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useSpriteMesh
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static Material defaultETC1GraphicMaterial => null;

		public override Texture mainTexture => null;

		public bool hasBorder => false;

		public float pixelsPerUnitMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float pixelsPerUnit => 0f;

		protected float multipliedPixelsPerUnit => 0f;

		public override Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual float minWidth => 0f;

		public virtual float preferredWidth => 0f;

		public virtual float flexibleWidth => 0f;

		public virtual float minHeight => 0f;

		public virtual float preferredHeight => 0f;

		public virtual float flexibleHeight => 0f;

		public virtual int layoutPriority => 0;

		public void DisableSpriteOptimizations()
		{
		}

		protected Image()
		{
		}

		public virtual void OnBeforeSerialize()
		{
		}

		public virtual void OnAfterDeserialize()
		{
		}

		private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize)
		{
		}

		private Vector4 GetDrawingDimensions(bool shouldPreserveAspect)
		{
			return default(Vector4);
		}

		public override void SetNativeSize()
		{
		}

		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		private void TrackSprite()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void UpdateMaterial()
		{
		}

		protected override void OnCanvasHierarchyChanged()
		{
		}

		private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect)
		{
		}

		private void GenerateSprite(VertexHelper vh, bool lPreserveAspect)
		{
		}

		private void GenerateSlicedSprite(VertexHelper toFill)
		{
		}

		private void GenerateTiledSprite(VertexHelper toFill)
		{
		}

		private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs)
		{
		}

		private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax)
		{
		}

		private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect)
		{
			return default(Vector4);
		}

		private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect)
		{
		}

		private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner)
		{
			return false;
		}

		private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner)
		{
		}

		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		public virtual void CalculateLayoutInputVertical()
		{
		}

		public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
		{
			return false;
		}

		private Vector2 MapCoordinate(Vector2 local, Rect rect)
		{
			return default(Vector2);
		}

		private static void RebuildImage(SpriteAtlas spriteAtlas)
		{
		}

		private static void TrackImage(Image g)
		{
		}

		private static void UnTrackImage(Image g)
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}
	}
}
