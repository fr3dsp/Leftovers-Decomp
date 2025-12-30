using System;

namespace UnityEngine.UI
{
	public class Text : MaskableGraphic, ILayoutElement
	{
		[SerializeField]
		private FontData m_FontData;

		[TextArea]
		[SerializeField]
		protected string m_Text;

		private TextGenerator m_TextCache;

		private TextGenerator m_TextCacheForLayout;

		protected static Material s_DefaultText;

		[NonSerialized]
		protected bool m_DisableFontTextureRebuiltCallback;

		private readonly UIVertex[] m_TempVerts;

		public TextGenerator cachedTextGenerator => null;

		public TextGenerator cachedTextGeneratorForLayout => null;

		public override Texture mainTexture => null;

		public Font font
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool supportRichText
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool resizeTextForBestFit
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int resizeTextMinSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int resizeTextMaxSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public TextAnchor alignment
		{
			get
			{
				return default(TextAnchor);
			}
			set
			{
			}
		}

		public bool alignByGeometry
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int fontSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public HorizontalWrapMode horizontalOverflow
		{
			get
			{
				return default(HorizontalWrapMode);
			}
			set
			{
			}
		}

		public VerticalWrapMode verticalOverflow
		{
			get
			{
				return default(VerticalWrapMode);
			}
			set
			{
			}
		}

		public float lineSpacing
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public FontStyle fontStyle
		{
			get
			{
				return default(FontStyle);
			}
			set
			{
			}
		}

		public float pixelsPerUnit => 0f;

		public virtual float minWidth => 0f;

		public virtual float preferredWidth => 0f;

		public virtual float flexibleWidth => 0f;

		public virtual float minHeight => 0f;

		public virtual float preferredHeight => 0f;

		public virtual float flexibleHeight => 0f;

		public virtual int layoutPriority => 0;

		protected Text()
		{
		}

		public void FontTextureChanged()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void UpdateGeometry()
		{
		}

		internal void AssignDefaultFont()
		{
		}

		public TextGenerationSettings GetGenerationSettings(Vector2 extents)
		{
			return default(TextGenerationSettings);
		}

		public static Vector2 GetTextAnchorPivot(TextAnchor anchor)
		{
			return default(Vector2);
		}

		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		public virtual void CalculateLayoutInputVertical()
		{
		}
	}
}
