using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	internal class TProfilingSampler<TEnum> : ProfilingSampler where TEnum : Enum
	{
		internal static Dictionary<TEnum, TProfilingSampler<TEnum>> samples;

		static TProfilingSampler()
		{
		}

		public TProfilingSampler(string name)
			: base(null)
		{
		}
	}
}
