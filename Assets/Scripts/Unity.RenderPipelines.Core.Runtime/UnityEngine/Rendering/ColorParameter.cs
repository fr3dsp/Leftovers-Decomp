using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class ColorParameter : VolumeParameter<Color>
	{
		public bool hdr;

		public bool showAlpha;

		public bool showEyeDropper;

		public ColorParameter(Color value, bool overrideState = false)
		{
		}

		public ColorParameter(Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = false)
		{
		}

		public override void Interp(Color from, Color to, float t)
		{
		}
	}
}
