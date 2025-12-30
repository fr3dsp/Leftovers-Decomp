using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	public sealed class VolumeStack : IDisposable
	{
		internal Dictionary<Type, VolumeComponent> components;

		internal VolumeStack()
		{
		}

		internal void Reload(Type[] baseTypes)
		{
		}

		public T GetComponent<T>() where T : VolumeComponent
		{
			return null;
		}

		public VolumeComponent GetComponent(Type type)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
