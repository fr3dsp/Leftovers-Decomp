using System;

namespace UnityEngine.EventSystems
{
	[Obsolete]
	public class TouchInputModule : PointerInputModule
	{
		private Vector2 m_LastMousePosition;

		private Vector2 m_MousePosition;

		private PointerEventData m_InputPointerEvent;

		[SerializeField]
		private bool m_ForceModuleActive;

		[Obsolete]
		public bool allowActivationOnStandalone
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool forceModuleActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected TouchInputModule()
		{
		}

		public override void UpdateModule()
		{
		}

		public override bool IsModuleSupported()
		{
			return false;
		}

		public override bool ShouldActivateModule()
		{
			return false;
		}

		private bool UseFakeInput()
		{
			return false;
		}

		public override void Process()
		{
		}

		private void FakeTouches()
		{
		}

		private void ProcessTouchEvents()
		{
		}

		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
		}

		public override void DeactivateModule()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
