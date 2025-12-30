using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class Vector3Parameter : VolumeParameter<Vector3>
	{
		public Vector3Parameter(Vector3 value, bool overrideState = false)
		{
		}

		public override void Interp(Vector3 from, Vector3 to, float t)
		{
		}
	}
}
