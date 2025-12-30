using System;

namespace TMPro
{
	[Serializable]
	public struct FontAssetCreationSettings
	{
		public string sourceFontFileName;

		public string sourceFontFileGUID;

		public int pointSizeSamplingMode;

		public int pointSize;

		public int padding;

		public int packingMode;

		public int atlasWidth;

		public int atlasHeight;

		public int characterSetSelectionMode;

		public string characterSequence;

		public string referencedFontAssetGUID;

		public string referencedTextAssetGUID;

		public int fontStyle;

		public float fontStyleModifier;

		public int renderMode;

		public bool includeFontFeatures;

		internal FontAssetCreationSettings(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode)
		{
			sourceFontFileName = null;
			this.sourceFontFileGUID = null;
			this.pointSizeSamplingMode = 0;
			this.pointSize = 0;
			this.padding = 0;
			this.packingMode = 0;
			this.atlasWidth = 0;
			this.atlasHeight = 0;
			characterSetSelectionMode = 0;
			characterSequence = null;
			referencedFontAssetGUID = null;
			referencedTextAssetGUID = null;
			fontStyle = 0;
			fontStyleModifier = 0f;
			this.renderMode = 0;
			includeFontFeatures = false;
		}
	}
}
