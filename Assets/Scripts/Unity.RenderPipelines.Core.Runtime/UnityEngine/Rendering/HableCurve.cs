namespace UnityEngine.Rendering
{
	public class HableCurve
	{
		public class Segment
		{
			public float offsetX;

			public float offsetY;

			public float scaleX;

			public float scaleY;

			public float lnA;

			public float B;

			public float Eval(float x)
			{
				return 0f;
			}
		}

		private struct DirectParams
		{
			internal float x0;

			internal float y0;

			internal float x1;

			internal float y1;

			internal float W;

			internal float overshootX;

			internal float overshootY;

			internal float gamma;
		}

		public class Uniforms
		{
			private HableCurve parent;

			public Vector4 curve => default(Vector4);

			public Vector4 toeSegmentA => default(Vector4);

			public Vector4 toeSegmentB => default(Vector4);

			public Vector4 midSegmentA => default(Vector4);

			public Vector4 midSegmentB => default(Vector4);

			public Vector4 shoSegmentA => default(Vector4);

			public Vector4 shoSegmentB => default(Vector4);

			internal Uniforms(HableCurve parent)
			{
			}
		}

		public readonly Segment[] segments;

		public readonly Uniforms uniforms;

		public float whitePoint { get; private set; }

		public float inverseWhitePoint { get; private set; }

		public float x0 { get; private set; }

		public float x1 { get; private set; }

		public float Eval(float x)
		{
			return 0f;
		}

		public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma)
		{
		}

		private void InitSegments(DirectParams srcParams)
		{
		}

		private void SolveAB(out float lnA, out float B, float x0, float y0, float m)
		{
			lnA = default(float);
			B = default(float);
		}

		private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1)
		{
			m = default(float);
			b = default(float);
		}

		private float EvalDerivativeLinearGamma(float m, float b, float g, float x)
		{
			return 0f;
		}
	}
}
