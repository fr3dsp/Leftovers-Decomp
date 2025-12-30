using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class TextureCurveParameter : VolumeParameter<TextureCurve>
	{
		public TextureCurveParameter(TextureCurve value, bool overrideState = false)
		{
		}

		public override void Release()
		{
		}
	}
}
