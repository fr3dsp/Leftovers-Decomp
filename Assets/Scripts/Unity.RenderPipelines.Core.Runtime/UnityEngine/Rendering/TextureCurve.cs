using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class TextureCurve : IDisposable
	{
		private const int k_Precision = 128;

		private const float k_Step = 1f / 128f;

		[SerializeField]
		private bool m_Loop;

		[SerializeField]
		private float m_ZeroValue;

		[SerializeField]
		private float m_Range;

		[SerializeField]
		private AnimationCurve m_Curve;

		private AnimationCurve m_LoopingCurve;

		private Texture2D m_Texture;

		private bool m_IsCurveDirty;

		private bool m_IsTextureDirty;

		[field: SerializeField]
		public int length { get; private set; }

		public Keyframe Item => default(Keyframe);

		public TextureCurve(AnimationCurve baseCurve, float zeroValue, bool loop, in Vector2 bounds)
		{
		}

		public TextureCurve(Keyframe[] keys, float zeroValue, bool loop, in Vector2 bounds)
		{
		}

		~TextureCurve()
		{
		}

		[Obsolete]
		public void Dispose()
		{
		}

		public void Release()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetDirty()
		{
		}

		private static TextureFormat GetTextureFormat()
		{
			return default(TextureFormat);
		}

		public Texture2D GetTexture()
		{
			return null;
		}

		public float Evaluate(float time)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int AddKey(float time, float value)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int MoveKey(int index, in Keyframe key)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void RemoveKey(int index)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SmoothTangents(int index, float weight)
		{
		}
	}
}
