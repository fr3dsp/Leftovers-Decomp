using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public abstract class TMP_Asset : ScriptableObject
	{
		private int m_InstanceID;

		public int hashCode;

		public Material material;

		public int materialHashCode;

		public int instanceID => 0;
	}
}
