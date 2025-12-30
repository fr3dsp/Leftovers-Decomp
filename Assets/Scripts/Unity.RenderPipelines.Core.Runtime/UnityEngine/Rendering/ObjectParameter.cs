using System;
using System.Collections.ObjectModel;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class ObjectParameter<T> : VolumeParameter<T>
	{
		internal ReadOnlyCollection<VolumeParameter> parameters { get; private set; }

		public sealed override bool overrideState
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public sealed override T value
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public ObjectParameter(T value)
		{
		}

		internal override void Interp(VolumeParameter from, VolumeParameter to, float t)
		{
		}
	}
}
