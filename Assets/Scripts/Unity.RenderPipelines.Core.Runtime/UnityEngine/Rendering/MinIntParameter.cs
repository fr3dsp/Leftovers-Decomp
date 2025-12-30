using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class MinIntParameter : IntParameter
	{
		public int min;

		public override int value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public MinIntParameter(int value, int min, bool overrideState = false)
			: base(0)
		{
		}
	}
}
