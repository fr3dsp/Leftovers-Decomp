using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	public sealed class VolumeProfile : ScriptableObject
	{
		public List<VolumeComponent> components;

		[NonSerialized]
		public bool isDirty;

		private void OnEnable()
		{
		}

		public void Reset()
		{
		}

		public T Add<T>(bool overrides = false) where T : VolumeComponent
		{
			return null;
		}

		public VolumeComponent Add(Type type, bool overrides = false)
		{
			return null;
		}

		public void Remove<T>() where T : VolumeComponent
		{
		}

		public void Remove(Type type)
		{
		}

		public bool Has<T>() where T : VolumeComponent
		{
			return false;
		}

		public bool Has(Type type)
		{
			return false;
		}

		public bool HasSubclassOf(Type type)
		{
			return false;
		}

		public bool TryGet<T>(out T component) where T : VolumeComponent
		{
			component = null;
			return false;
		}

		public bool TryGet<T>(Type type, out T component) where T : VolumeComponent
		{
			component = null;
			return false;
		}

		public bool TryGetSubclassOf<T>(Type type, out T component) where T : VolumeComponent
		{
			component = null;
			return false;
		}

		public bool TryGetAllSubclassOf<T>(Type type, List<T> result) where T : VolumeComponent
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal int GetComponentListHashCode()
		{
			return 0;
		}
	}
}
