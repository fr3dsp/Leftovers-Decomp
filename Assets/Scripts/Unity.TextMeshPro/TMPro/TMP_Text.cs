using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	public abstract class TMP_Text : MaskableGraphic
	{
		protected struct CharacterSubstitution
		{
			public int index;

			public uint unicode;

			public CharacterSubstitution(int index, uint unicode)
			{
				this.index = 0;
				this.unicode = 0u;
			}
		}

		internal enum TextInputSources
		{
			TextInputBox = 0,
			SetText = 1,
			SetTextArray = 2,
			TextString = 3
		}

		internal struct UnicodeChar
		{
			public int unicode;

			public int stringIndex;

			public int length;
		}

		protected struct SpecialCharacter
		{
			public TMP_Character character;

			public TMP_FontAsset fontAsset;

			public Material material;

			public int materialIndex;

			public SpecialCharacter(TMP_Character character, int materialIndex)
			{
				this.character = null;
				fontAsset = null;
				material = null;
				this.materialIndex = 0;
			}
		}

		private struct TextBackingContainer
		{
			private uint[] m_Array;

			private int m_Count;

			public int Capacity => 0;

			public int Count
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public uint Item
			{
				get
				{
					return 0u;
				}
				set
				{
				}
			}

			public TextBackingContainer(int size)
			{
				m_Array = null;
				m_Count = 0;
			}

			public void Resize(int size)
			{
			}
		}

		[SerializeField]
		[TextArea]
		protected string m_text;

		private bool m_IsTextBackingStringDirty;

		[SerializeField]
		protected ITextPreprocessor m_TextPreprocessor;

		[SerializeField]
		protected bool m_isRightToLeft;

		[SerializeField]
		protected TMP_FontAsset m_fontAsset;

		protected TMP_FontAsset m_currentFontAsset;

		protected bool m_isSDFShader;

		[SerializeField]
		protected Material m_sharedMaterial;

		protected Material m_currentMaterial;

		protected static MaterialReference[] m_materialReferences;

		protected static Dictionary<int, int> m_materialReferenceIndexLookup;

		protected static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack;

		protected int m_currentMaterialIndex;

		[SerializeField]
		protected Material[] m_fontSharedMaterials;

		[SerializeField]
		protected Material m_fontMaterial;

		[SerializeField]
		protected Material[] m_fontMaterials;

		protected bool m_isMaterialDirty;

		[SerializeField]
		protected Color32 m_fontColor32;

		[SerializeField]
		protected Color m_fontColor;

		protected static Color32 s_colorWhite;

		protected Color32 m_underlineColor;

		protected Color32 m_strikethroughColor;

		[SerializeField]
		protected bool m_enableVertexGradient;

		[SerializeField]
		protected ColorMode m_colorMode;

		[SerializeField]
		protected VertexGradient m_fontColorGradient;

		[SerializeField]
		protected TMP_ColorGradient m_fontColorGradientPreset;

		[SerializeField]
		protected TMP_SpriteAsset m_spriteAsset;

		[SerializeField]
		protected bool m_tintAllSprites;

		protected bool m_tintSprite;

		protected Color32 m_spriteColor;

		[SerializeField]
		protected TMP_StyleSheet m_StyleSheet;

		internal TMP_Style m_TextStyle;

		[SerializeField]
		protected int m_TextStyleHashCode;

		[SerializeField]
		protected bool m_overrideHtmlColors;

		[SerializeField]
		protected Color32 m_faceColor;

		protected Color32 m_outlineColor;

		protected float m_outlineWidth;

		[SerializeField]
		protected float m_fontSize;

		protected float m_currentFontSize;

		[SerializeField]
		protected float m_fontSizeBase;

		protected TMP_TextProcessingStack<float> m_sizeStack;

		[SerializeField]
		protected FontWeight m_fontWeight;

		protected FontWeight m_FontWeightInternal;

		protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack;

		[SerializeField]
		protected bool m_enableAutoSizing;

		protected float m_maxFontSize;

		protected float m_minFontSize;

		protected int m_AutoSizeIterationCount;

		protected int m_AutoSizeMaxIterationCount;

		protected bool m_IsAutoSizePointSizeSet;

		[SerializeField]
		protected float m_fontSizeMin;

		[SerializeField]
		protected float m_fontSizeMax;

		[SerializeField]
		protected FontStyles m_fontStyle;

		protected FontStyles m_FontStyleInternal;

		protected TMP_FontStyleStack m_fontStyleStack;

		protected bool m_isUsingBold;

		[SerializeField]
		protected HorizontalAlignmentOptions m_HorizontalAlignment;

		[SerializeField]
		protected VerticalAlignmentOptions m_VerticalAlignment;

		[SerializeField]
		protected TextAlignmentOptions m_textAlignment;

		protected HorizontalAlignmentOptions m_lineJustification;

		protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack;

		protected Vector3[] m_textContainerLocalCorners;

		[SerializeField]
		protected float m_characterSpacing;

		protected float m_cSpacing;

		protected float m_monoSpacing;

		[SerializeField]
		protected float m_wordSpacing;

		[SerializeField]
		protected float m_lineSpacing;

		protected float m_lineSpacingDelta;

		protected float m_lineHeight;

		protected bool m_IsDrivenLineSpacing;

		[SerializeField]
		protected float m_lineSpacingMax;

		[SerializeField]
		protected float m_paragraphSpacing;

		[SerializeField]
		protected float m_charWidthMaxAdj;

		protected float m_charWidthAdjDelta;

		[SerializeField]
		protected bool m_enableWordWrapping;

		protected bool m_isCharacterWrappingEnabled;

		protected bool m_isNonBreakingSpace;

		protected bool m_isIgnoringAlignment;

		[SerializeField]
		protected float m_wordWrappingRatios;

		[SerializeField]
		protected TextOverflowModes m_overflowMode;

		protected int m_firstOverflowCharacterIndex;

		[SerializeField]
		protected TMP_Text m_linkedTextComponent;

		[SerializeField]
		internal TMP_Text parentLinkedComponent;

		protected bool m_isTextTruncated;

		[SerializeField]
		protected bool m_enableKerning;

		protected float m_GlyphHorizontalAdvanceAdjustment;

		[SerializeField]
		protected bool m_enableExtraPadding;

		[SerializeField]
		protected bool checkPaddingRequired;

		[SerializeField]
		protected bool m_isRichText;

		[SerializeField]
		protected bool m_parseCtrlCharacters;

		protected bool m_isOverlay;

		[SerializeField]
		protected bool m_isOrthographic;

		[SerializeField]
		protected bool m_isCullingEnabled;

		protected bool m_isMaskingEnabled;

		protected bool isMaskUpdateRequired;

		protected bool m_ignoreCulling;

		[SerializeField]
		protected TextureMappingOptions m_horizontalMapping;

		[SerializeField]
		protected TextureMappingOptions m_verticalMapping;

		[SerializeField]
		protected float m_uvLineOffset;

		protected TextRenderFlags m_renderMode;

		[SerializeField]
		protected VertexSortingOrder m_geometrySortingOrder;

		[SerializeField]
		protected bool m_IsTextObjectScaleStatic;

		[SerializeField]
		protected bool m_VertexBufferAutoSizeReduction;

		protected int m_firstVisibleCharacter;

		protected int m_maxVisibleCharacters;

		protected int m_maxVisibleWords;

		protected int m_maxVisibleLines;

		[SerializeField]
		protected bool m_useMaxVisibleDescender;

		[SerializeField]
		protected int m_pageToDisplay;

		protected bool m_isNewPage;

		[SerializeField]
		protected Vector4 m_margin;

		protected float m_marginLeft;

		protected float m_marginRight;

		protected float m_marginWidth;

		protected float m_marginHeight;

		protected float m_width;

		protected TMP_TextInfo m_textInfo;

		protected bool m_havePropertiesChanged;

		[SerializeField]
		protected bool m_isUsingLegacyAnimationComponent;

		protected Transform m_transform;

		protected RectTransform m_rectTransform;

		protected Vector2 m_PreviousRectTransformSize;

		protected Vector2 m_PreviousPivotPosition;

		protected bool m_autoSizeTextContainer;

		protected Mesh m_mesh;

		[SerializeField]
		protected bool m_isVolumetricText;

		protected TMP_SpriteAnimator m_spriteAnimator;

		protected float m_flexibleHeight;

		protected float m_flexibleWidth;

		protected float m_minWidth;

		protected float m_minHeight;

		protected float m_maxWidth;

		protected float m_maxHeight;

		protected LayoutElement m_LayoutElement;

		protected float m_preferredWidth;

		protected float m_renderedWidth;

		protected bool m_isPreferredWidthDirty;

		protected float m_preferredHeight;

		protected float m_renderedHeight;

		protected bool m_isPreferredHeightDirty;

		protected bool m_isCalculatingPreferredValues;

		protected int m_layoutPriority;

		protected bool m_isLayoutDirty;

		protected bool m_isAwake;

		internal bool m_isWaitingOnResourceLoad;

		internal TextInputSources m_inputSource;

		protected float m_fontScaleMultiplier;

		private static char[] m_htmlTag;

		private static RichTextTagAttribute[] m_xmlAttribute;

		private static float[] m_attributeParameterValues;

		protected float tag_LineIndent;

		protected float tag_Indent;

		protected TMP_TextProcessingStack<float> m_indentStack;

		protected bool tag_NoParsing;

		protected bool m_isParsingText;

		protected Matrix4x4 m_FXMatrix;

		protected bool m_isFXMatrixSet;

		internal UnicodeChar[] m_TextProcessingArray;

		internal int m_InternalTextProcessingArraySize;

		private TMP_CharacterInfo[] m_internalCharacterInfo;

		protected int m_totalCharacterCount;

		protected static WordWrapState m_SavedWordWrapState;

		protected static WordWrapState m_SavedLineState;

		protected static WordWrapState m_SavedEllipsisState;

		protected static WordWrapState m_SavedLastValidState;

		protected static WordWrapState m_SavedSoftLineBreakState;

		internal static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack;

		protected int m_characterCount;

		protected int m_firstCharacterOfLine;

		protected int m_firstVisibleCharacterOfLine;

		protected int m_lastCharacterOfLine;

		protected int m_lastVisibleCharacterOfLine;

		protected int m_lineNumber;

		protected int m_lineVisibleCharacterCount;

		protected int m_pageNumber;

		protected float m_PageAscender;

		protected float m_maxTextAscender;

		protected float m_maxCapHeight;

		protected float m_ElementAscender;

		protected float m_ElementDescender;

		protected float m_maxLineAscender;

		protected float m_maxLineDescender;

		protected float m_startOfLineAscender;

		protected float m_startOfLineDescender;

		protected float m_lineOffset;

		protected Extents m_meshExtents;

		protected Color32 m_htmlColor;

		protected TMP_TextProcessingStack<Color32> m_colorStack;

		protected TMP_TextProcessingStack<Color32> m_underlineColorStack;

		protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack;

		protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack;

		protected TMP_ColorGradient m_colorGradientPreset;

		protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack;

		protected bool m_colorGradientPresetIsTinted;

		protected float m_tabSpacing;

		protected float m_spacing;

		protected TMP_TextProcessingStack<int>[] m_TextStyleStacks;

		protected int m_TextStyleStackDepth;

		protected TMP_TextProcessingStack<int> m_ItalicAngleStack;

		protected int m_ItalicAngle;

		protected TMP_TextProcessingStack<int> m_actionStack;

		protected float m_padding;

		protected float m_baselineOffset;

		protected TMP_TextProcessingStack<float> m_baselineOffsetStack;

		protected float m_xAdvance;

		protected TMP_TextElementType m_textElementType;

		protected TMP_TextElement m_cached_TextElement;

		protected SpecialCharacter m_Ellipsis;

		protected SpecialCharacter m_Underline;

		protected TMP_SpriteAsset m_defaultSpriteAsset;

		protected TMP_SpriteAsset m_currentSpriteAsset;

		protected int m_spriteCount;

		protected int m_spriteIndex;

		protected int m_spriteAnimationID;

		private static ProfilerMarker k_ParseTextMarker;

		private static ProfilerMarker k_InsertNewLineMarker;

		protected bool m_ignoreActiveState;

		private TextBackingContainer m_TextBackingArray;

		private readonly decimal[] k_Power;

		protected static Vector2 k_LargePositiveVector2;

		protected static Vector2 k_LargeNegativeVector2;

		protected static float k_LargePositiveFloat;

		protected static float k_LargeNegativeFloat;

		protected static int k_LargePositiveInt;

		protected static int k_LargeNegativeInt;

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

		public ITextPreprocessor textPreprocessor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isRightToLeftText
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public TMP_FontAsset font
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual Material fontSharedMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual Material[] fontSharedMaterials
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material fontMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual Material[] fontMaterials
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float alpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool enableVertexGradient
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public VertexGradient colorGradient
		{
			get
			{
				return default(VertexGradient);
			}
			set
			{
			}
		}

		public TMP_ColorGradient colorGradientPreset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TMP_SpriteAsset spriteAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool tintAllSprites
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public TMP_StyleSheet styleSheet
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TMP_Style textStyle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool overrideColorTags
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Color32 faceColor
		{
			get
			{
				return default(Color32);
			}
			set
			{
			}
		}

		public Color32 outlineColor
		{
			get
			{
				return default(Color32);
			}
			set
			{
			}
		}

		public float outlineWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float fontSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public FontWeight fontWeight
		{
			get
			{
				return default(FontWeight);
			}
			set
			{
			}
		}

		public float pixelsPerUnit => 0f;

		public bool enableAutoSizing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float fontSizeMin
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float fontSizeMax
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public FontStyles fontStyle
		{
			get
			{
				return default(FontStyles);
			}
			set
			{
			}
		}

		public bool isUsingBold => false;

		public HorizontalAlignmentOptions horizontalAlignment
		{
			get
			{
				return default(HorizontalAlignmentOptions);
			}
			set
			{
			}
		}

		public VerticalAlignmentOptions verticalAlignment
		{
			get
			{
				return default(VerticalAlignmentOptions);
			}
			set
			{
			}
		}

		public TextAlignmentOptions alignment
		{
			get
			{
				return default(TextAlignmentOptions);
			}
			set
			{
			}
		}

		public float characterSpacing
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float wordSpacing
		{
			get
			{
				return 0f;
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

		public float lineSpacingAdjustment
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float paragraphSpacing
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float characterWidthAdjustment
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool enableWordWrapping
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float wordWrappingRatios
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public TextOverflowModes overflowMode
		{
			get
			{
				return default(TextOverflowModes);
			}
			set
			{
			}
		}

		public bool isTextOverflowing => false;

		public int firstOverflowCharacterIndex => 0;

		public TMP_Text linkedTextComponent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isTextTruncated => false;

		public bool enableKerning
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool extraPadding
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool richText
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool parseCtrlCharacters
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isOverlay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isOrthographic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableCulling
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ignoreVisibility
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public TextureMappingOptions horizontalMapping
		{
			get
			{
				return default(TextureMappingOptions);
			}
			set
			{
			}
		}

		public TextureMappingOptions verticalMapping
		{
			get
			{
				return default(TextureMappingOptions);
			}
			set
			{
			}
		}

		public float mappingUvLineOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public TextRenderFlags renderMode
		{
			get
			{
				return default(TextRenderFlags);
			}
			set
			{
			}
		}

		public VertexSortingOrder geometrySortingOrder
		{
			get
			{
				return default(VertexSortingOrder);
			}
			set
			{
			}
		}

		public bool isTextObjectScaleStatic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool vertexBufferAutoSizeReduction
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int firstVisibleCharacter
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int maxVisibleCharacters
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int maxVisibleWords
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int maxVisibleLines
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool useMaxVisibleDescender
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int pageToDisplay
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual Vector4 margin
		{
			get
			{
				return default(Vector4);
			}
			set
			{
			}
		}

		public TMP_TextInfo textInfo => null;

		public bool havePropertiesChanged
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isUsingLegacyAnimationComponent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public new Transform transform => null;

		public new RectTransform rectTransform => null;

		public virtual bool autoSizeTextContainer { get; set; }

		public virtual Mesh mesh => null;

		public bool isVolumetricText
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Bounds bounds => default(Bounds);

		public Bounds textBounds => default(Bounds);

		protected TMP_SpriteAnimator spriteAnimator => null;

		public float flexibleHeight => 0f;

		public float flexibleWidth => 0f;

		public float minWidth => 0f;

		public float minHeight => 0f;

		public float maxWidth => 0f;

		public float maxHeight => 0f;

		protected LayoutElement layoutElement => null;

		public virtual float preferredWidth => 0f;

		public virtual float preferredHeight => 0f;

		public virtual float renderedWidth => 0f;

		public virtual float renderedHeight => 0f;

		public int layoutPriority => 0;

		public static event Func<int, string, TMP_FontAsset> OnFontAssetRequest
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public virtual event Action<TMP_TextInfo> OnPreRenderText
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected virtual void LoadFontAsset()
		{
		}

		protected virtual void SetSharedMaterial(Material mat)
		{
		}

		protected virtual Material GetMaterial(Material mat)
		{
			return null;
		}

		protected virtual void SetFontBaseMaterial(Material mat)
		{
		}

		protected virtual Material[] GetSharedMaterials()
		{
			return null;
		}

		protected virtual void SetSharedMaterials(Material[] materials)
		{
		}

		protected virtual Material[] GetMaterials(Material[] mats)
		{
			return null;
		}

		protected virtual Material CreateMaterialInstance(Material source)
		{
			return null;
		}

		protected void SetVertexColorGradient(TMP_ColorGradient gradient)
		{
		}

		protected void SetTextSortingOrder(VertexSortingOrder order)
		{
		}

		protected void SetTextSortingOrder(int[] order)
		{
		}

		protected virtual void SetFaceColor(Color32 color)
		{
		}

		protected virtual void SetOutlineColor(Color32 color)
		{
		}

		protected virtual void SetOutlineThickness(float thickness)
		{
		}

		protected virtual void SetShaderDepth()
		{
		}

		protected virtual void SetCulling()
		{
		}

		internal virtual void UpdateCulling()
		{
		}

		protected virtual float GetPaddingForMaterial()
		{
			return 0f;
		}

		protected virtual float GetPaddingForMaterial(Material mat)
		{
			return 0f;
		}

		protected virtual Vector3[] GetTextContainerLocalCorners()
		{
			return null;
		}

		public virtual void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false)
		{
		}

		public virtual void UpdateGeometry(Mesh mesh, int index)
		{
		}

		public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags)
		{
		}

		public virtual void UpdateVertexData()
		{
		}

		public virtual void SetVertices(Vector3[] vertices)
		{
		}

		public virtual void UpdateMeshPadding()
		{
		}

		public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
		}

		public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
		}

		protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
		}

		protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
		}

		protected void ParseInputText()
		{
		}

		private void PopulateTextBackingArray(string sourceText)
		{
		}

		private void PopulateTextBackingArray(string sourceText, int start, int length)
		{
		}

		private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length)
		{
		}

		private void PopulateTextBackingArray(char[] sourceText, int start, int length)
		{
		}

		private void PopulateTextProcessingArray()
		{
		}

		private void SetTextInternal(string sourceText)
		{
		}

		public void SetText(string sourceText, bool syncTextInputBox = true)
		{
		}

		public void SetText(string sourceText, float arg0)
		{
		}

		public void SetText(string sourceText, float arg0, float arg1)
		{
		}

		public void SetText(string sourceText, float arg0, float arg1, float arg2)
		{
		}

		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3)
		{
		}

		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4)
		{
		}

		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
		}

		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6)
		{
		}

		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7)
		{
		}

		public void SetText(StringBuilder sourceText)
		{
		}

		private void SetText(StringBuilder sourceText, int start, int length)
		{
		}

		public void SetText(char[] sourceText)
		{
		}

		public void SetText(char[] sourceText, int start, int length)
		{
		}

		public void SetCharArray(char[] sourceText)
		{
		}

		public void SetCharArray(char[] sourceText, int start, int length)
		{
		}

		private TMP_Style GetStyle(int hashCode)
		{
			return null;
		}

		private bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex)
		{
			srcOffset = default(int);
			return false;
		}

		private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex)
		{
			srcOffset = default(int);
			return false;
		}

		private void ReplaceClosingStyleTag(ref TextBackingContainer sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex)
		{
		}

		private void ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex)
		{
		}

		private bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex)
		{
			return false;
		}

		private void InsertClosingStyleTag(ref UnicodeChar[] charBuffer, ref int writeIndex)
		{
		}

		private int GetMarkupTagHashCode(int[] tagDefinition, int readIndex)
		{
			return 0;
		}

		private int GetMarkupTagHashCode(TextBackingContainer tagDefinition, int readIndex)
		{
			return 0;
		}

		private int GetStyleHashCode(ref int[] text, int index, out int closeIndex)
		{
			closeIndex = default(int);
			return 0;
		}

		private int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex)
		{
			closeIndex = default(int);
			return 0;
		}

		private void ResizeInternalArray<T>(ref T[] array)
		{
		}

		private void ResizeInternalArray<T>(ref T[] array, int size)
		{
		}

		private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex)
		{
		}

		private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex)
		{
		}

		private string InternalTextBackingArrayToString()
		{
			return null;
		}

		internal virtual int SetArraySizes(UnicodeChar[] unicodeChars)
		{
			return 0;
		}

		public Vector2 GetPreferredValues()
		{
			return default(Vector2);
		}

		public Vector2 GetPreferredValues(float width, float height)
		{
			return default(Vector2);
		}

		public Vector2 GetPreferredValues(string text)
		{
			return default(Vector2);
		}

		public Vector2 GetPreferredValues(string text, float width, float height)
		{
			return default(Vector2);
		}

		protected float GetPreferredWidth()
		{
			return 0f;
		}

		private float GetPreferredWidth(Vector2 margin)
		{
			return 0f;
		}

		protected float GetPreferredHeight()
		{
			return 0f;
		}

		private float GetPreferredHeight(Vector2 margin)
		{
			return 0f;
		}

		public Vector2 GetRenderedValues()
		{
			return default(Vector2);
		}

		public Vector2 GetRenderedValues(bool onlyVisibleCharacters)
		{
			return default(Vector2);
		}

		private float GetRenderedWidth()
		{
			return 0f;
		}

		protected float GetRenderedWidth(bool onlyVisibleCharacters)
		{
			return 0f;
		}

		private float GetRenderedHeight()
		{
			return 0f;
		}

		protected float GetRenderedHeight(bool onlyVisibleCharacters)
		{
			return 0f;
		}

		protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled)
		{
			return default(Vector2);
		}

		protected virtual Bounds GetCompoundBounds()
		{
			return default(Bounds);
		}

		internal virtual Rect GetCanvasSpaceClippingRect()
		{
			return default(Rect);
		}

		protected Bounds GetTextBounds()
		{
			return default(Bounds);
		}

		protected Bounds GetTextBounds(bool onlyVisibleCharacters)
		{
			return default(Bounds);
		}

		protected void AdjustLineOffset(int startIndex, int endIndex, float offset)
		{
		}

		protected void ResizeLineExtents(int size)
		{
		}

		public virtual TMP_TextInfo GetTextInfo(string text)
		{
			return null;
		}

		public virtual void ComputeMarginSize()
		{
		}

		protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender)
		{
		}

		protected void SaveWordWrappingState(ref WordWrapState state, int index, int count)
		{
		}

		protected int RestoreWordWrappingState(ref WordWrapState state)
		{
			return 0;
		}

		protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor)
		{
		}

		protected virtual void SaveSpriteVertexInfo(Color32 vertexColor)
		{
		}

		protected virtual void FillCharacterVertexBuffers(int i, int index_X4)
		{
		}

		protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric)
		{
		}

		protected virtual void FillSpriteVertexBuffers(int i, int index_X4)
		{
		}

		protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor)
		{
		}

		protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor)
		{
		}

		protected void LoadDefaultSettings()
		{
		}

		protected void GetSpecialCharacters(TMP_FontAsset fontAsset)
		{
		}

		protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset)
		{
		}

		protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset)
		{
		}

		protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c)
		{
		}

		protected TMP_FontAsset GetFontAssetForWeight(int fontWeight)
		{
			return null;
		}

		internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface)
		{
			isUsingAlternativeTypeface = default(bool);
			return null;
		}

		protected virtual void SetActiveSubMeshes(bool state)
		{
		}

		protected virtual void DestroySubMeshObjects()
		{
		}

		public virtual void ClearMesh()
		{
		}

		public virtual void ClearMesh(bool uploadGeometry)
		{
		}

		public virtual string GetParsedText()
		{
			return null;
		}

		internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent)
		{
			return false;
		}

		internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent)
		{
		}

		protected Vector2 PackUV(float x, float y, float scale)
		{
			return default(Vector2);
		}

		protected float PackUV(float x, float y)
		{
			return 0f;
		}

		internal virtual void InternalUpdate()
		{
		}

		protected int HexToInt(char hex)
		{
			return 0;
		}

		protected int GetUTF16(string text, int i)
		{
			return 0;
		}

		protected int GetUTF16(int[] text, int i)
		{
			return 0;
		}

		internal int GetUTF16(uint[] text, int i)
		{
			return 0;
		}

		protected int GetUTF16(StringBuilder text, int i)
		{
			return 0;
		}

		private int GetUTF16(TextBackingContainer text, int i)
		{
			return 0;
		}

		protected int GetUTF32(string text, int i)
		{
			return 0;
		}

		protected int GetUTF32(int[] text, int i)
		{
			return 0;
		}

		internal int GetUTF32(uint[] text, int i)
		{
			return 0;
		}

		protected int GetUTF32(StringBuilder text, int i)
		{
			return 0;
		}

		private int GetUTF32(TextBackingContainer text, int i)
		{
			return 0;
		}

		protected Color32 HexCharsToColor(char[] hexChars, int tagCount)
		{
			return default(Color32);
		}

		protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length)
		{
			return default(Color32);
		}

		private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters)
		{
			return 0;
		}

		protected float ConvertToFloat(char[] chars, int startIndex, int length)
		{
			return 0f;
		}

		protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex)
		{
			lastIndex = default(int);
			return 0f;
		}

		internal bool ValidateHtmlTag(UnicodeChar[] chars, int startIndex, out int endIndex)
		{
			endIndex = default(int);
			return false;
		}
	}
}
