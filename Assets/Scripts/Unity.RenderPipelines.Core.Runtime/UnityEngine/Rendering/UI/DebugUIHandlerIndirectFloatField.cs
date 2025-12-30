using System;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerIndirectFloatField : DebugUIHandlerWidget
	{
		public Text nameLabel;

		public Text valueLabel;

		public Func<float> getter;

		public Action<float> setter;

		public Func<float> incStepGetter;

		public Func<float> incStepMultGetter;

		public Func<float> decimalsGetter;

		public void Init()
		{
		}

		public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			return false;
		}

		public override void OnDeselection()
		{
		}

		public override void OnIncrement(bool fast)
		{
		}

		public override void OnDecrement(bool fast)
		{
		}

		private void ChangeValue(bool fast, float multiplier)
		{
		}

		private void UpdateValueLabel()
		{
		}
	}
}
