using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class VolumeComponent : ScriptableObject
	{
		public bool active;

		[SerializeField]
		private bool m_AdvancedMode;

		public string displayName { get; protected set; }

		public ReadOnlyCollection<VolumeParameter> parameters { get; private set; }

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void Override(VolumeComponent state, float interpFactor)
		{
		}

		public void SetAllOverridesTo(bool state)
		{
		}

		private void SetAllOverridesTo(IEnumerable<VolumeParameter> enumerable, bool state)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		protected virtual void OnDestroy()
		{
		}

		public void Release()
		{
		}
	}
}
