using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class NoInterpVector3Parameter : VolumeParameter<Vector3>
	{
		public NoInterpVector3Parameter(Vector3 value, bool overrideState = false)
		{
		}
	}
}
