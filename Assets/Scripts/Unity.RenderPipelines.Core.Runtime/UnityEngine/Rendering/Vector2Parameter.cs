using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class Vector2Parameter : VolumeParameter<Vector2>
	{
		public Vector2Parameter(Vector2 value, bool overrideState = false)
		{
		}

		public override void Interp(Vector2 from, Vector2 to, float t)
		{
		}
	}
}
