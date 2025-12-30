using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[DisallowMultipleComponent]
	public class ToggleGroup : UIBehaviour
	{
		[SerializeField]
		private bool m_AllowSwitchOff;

		protected List<Toggle> m_Toggles;

		public bool allowSwitchOff
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected ToggleGroup()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnEnable()
		{
		}

		private void ValidateToggleIsInGroup(Toggle toggle)
		{
		}

		public void NotifyToggleOn(Toggle toggle, bool sendCallback = true)
		{
		}

		public void UnregisterToggle(Toggle toggle)
		{
		}

		public void RegisterToggle(Toggle toggle)
		{
		}

		public void EnsureValidState()
		{
		}

		public bool AnyTogglesOn()
		{
			return false;
		}

		public IEnumerable<Toggle> ActiveToggles()
		{
			return null;
		}

		public Toggle GetFirstActiveToggle()
		{
			return null;
		}

		public void SetAllTogglesOff(bool sendCallback = true)
		{
		}
	}
}
