using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	[ExecuteAlways]
	public class UIFoldout : Toggle
	{
		public GameObject content;

		public GameObject arrowOpened;

		public GameObject arrowClosed;

		protected override void Start()
		{
		}

		private void OnValidate()
		{
		}

		public void SetState(bool state)
		{
		}

		public void SetState(bool state, bool rebuildLayout)
		{
		}
	}
}
