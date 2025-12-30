using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class IntParameter : VolumeParameter<int>
	{
		public IntParameter(int value, bool overrideState = false)
		{
		}

		public sealed override void Interp(int from, int to, float t)
		{
		}
	}
}
