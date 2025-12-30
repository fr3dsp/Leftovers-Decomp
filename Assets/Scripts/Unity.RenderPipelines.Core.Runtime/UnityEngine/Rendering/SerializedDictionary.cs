using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class SerializedDictionary<K, V> : Dictionary<K, V>, ISerializationCallbackReceiver
	{
		[SerializeField]
		private List<K> m_Keys;

		[SerializeField]
		private List<V> m_Values;

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
