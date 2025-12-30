namespace UnityEngine.Rendering
{
	internal class DebugActionState
	{
		private enum DebugActionKeyType
		{
			Button = 0,
			Axis = 1,
			Key = 2
		}

		private DebugActionKeyType m_Type;

		private string[] m_PressedButtons;

		private string m_PressedAxis;

		private KeyCode[] m_PressedKeys;

		private bool[] m_TriggerPressedUp;

		private float m_Timer;

		internal bool runningAction { get; private set; }

		internal float actionState { get; private set; }

		private void Trigger(int triggerCount, float state)
		{
		}

		public void TriggerWithButton(string[] buttons, float state)
		{
		}

		public void TriggerWithAxis(string axis, float state)
		{
		}

		public void TriggerWithKey(KeyCode[] keys, float state)
		{
		}

		private void Reset()
		{
		}

		public void Update(DebugActionDesc desc)
		{
		}
	}
}
