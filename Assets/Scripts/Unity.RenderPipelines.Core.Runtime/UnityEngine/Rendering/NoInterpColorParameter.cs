using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class NoInterpColorParameter : VolumeParameter<Color>
	{
		public bool hdr;

		public bool showAlpha;

		public bool showEyeDropper;

		public NoInterpColorParameter(Color value, bool overrideState = false)
		{
		}

		public NoInterpColorParameter(Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = false)
		{
		}
	}
}
