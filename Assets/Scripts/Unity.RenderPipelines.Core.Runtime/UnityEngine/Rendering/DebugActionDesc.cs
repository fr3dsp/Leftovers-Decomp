using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	internal class DebugActionDesc
	{
		public string axisTrigger;

		public List<string[]> buttonTriggerList;

		public List<KeyCode[]> keyTriggerList;

		public DebugActionRepeatMode repeatMode;

		public float repeatDelay;
	}
}
