using System;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Experimental.Rendering.Universal
{
	[Serializable]
	public struct Light2DBlendStyle
	{
		internal enum TextureChannel
		{
			None = 0,
			R = 1,
			G = 2,
			B = 3,
			A = 4,
			OneMinusR = 5,
			OneMinusG = 6,
			OneMinusB = 7,
			OneMinusA = 8
		}

		internal struct MaskChannelFilter
		{
			public Vector4 mask { get; private set; }

			public Vector4 inverted { get; private set; }

			public MaskChannelFilter(Vector4 m, Vector4 i)
			{
				mask = default(Vector4);
				inverted = default(Vector4);
			}
		}

		internal enum BlendMode
		{
			Additive = 0,
			Multiply = 1,
			Subtractive = 2,
			Custom = 99
		}

		[Serializable]
		internal struct BlendFactors
		{
			public float multiplicative;

			public float additive;
		}

		public string name;

		[SerializeField]
		internal TextureChannel maskTextureChannel;

		[SerializeField]
		internal float renderTextureScale;

		[SerializeField]
		internal BlendMode blendMode;

		[SerializeField]
		internal BlendFactors customBlendFactors;

		internal RenderTargetHandle renderTargetHandle;

		internal Vector2 blendFactors => default(Vector2);

		internal MaskChannelFilter maskTextureChannelFilter => default(MaskChannelFilter);

		internal bool isDirty { get; set; }

		internal bool hasRenderTarget { get; set; }
	}
}
