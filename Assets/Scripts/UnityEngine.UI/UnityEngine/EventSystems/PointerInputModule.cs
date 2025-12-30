using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
	public abstract class PointerInputModule : BaseInputModule
	{
		protected class ButtonState
		{
			private PointerEventData.InputButton m_Button;

			private MouseButtonEventData m_EventData;

			public MouseButtonEventData eventData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public PointerEventData.InputButton button
			{
				get
				{
					return default(PointerEventData.InputButton);
				}
				set
				{
				}
			}
		}

		protected class MouseState
		{
			private List<ButtonState> m_TrackedButtons;

			public bool AnyPressesThisFrame()
			{
				return false;
			}

			public bool AnyReleasesThisFrame()
			{
				return false;
			}

			public ButtonState GetButtonState(PointerEventData.InputButton button)
			{
				return null;
			}

			public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data)
			{
			}
		}

		public class MouseButtonEventData
		{
			public PointerEventData.FramePressState buttonState;

			public PointerEventData buttonData;

			public bool PressedThisFrame()
			{
				return false;
			}

			public bool ReleasedThisFrame()
			{
				return false;
			}
		}

		public const int kMouseLeftId = -1;

		public const int kMouseRightId = -2;

		public const int kMouseMiddleId = -3;

		public const int kFakeTouchesId = -4;

		protected Dictionary<int, PointerEventData> m_PointerData;

		private readonly MouseState m_MouseState;

		protected bool GetPointerData(int id, out PointerEventData data, bool create)
		{
			data = null;
			return false;
		}

		protected void RemovePointerData(PointerEventData data)
		{
		}

		protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released)
		{
			pressed = default(bool);
			released = default(bool);
			return null;
		}

		protected void CopyFromTo(PointerEventData from, PointerEventData to)
		{
		}

		protected PointerEventData.FramePressState StateForMouseButton(int buttonId)
		{
			return default(PointerEventData.FramePressState);
		}

		protected virtual MouseState GetMousePointerEventData()
		{
			return null;
		}

		protected virtual MouseState GetMousePointerEventData(int id)
		{
			return null;
		}

		protected PointerEventData GetLastPointerEventData(int id)
		{
			return null;
		}

		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return false;
		}

		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
		}

		protected virtual void ProcessDrag(PointerEventData pointerEvent)
		{
		}

		public override bool IsPointerOverGameObject(int pointerId)
		{
			return false;
		}

		protected void ClearSelection()
		{
		}

		public override string ToString()
		{
			return null;
		}

		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
		}
	}
}
