using System;

namespace UnityEngine.Rendering
{
	public class HLSLArray : Attribute
	{
		public int arraySize;

		public Type elementType;

		public HLSLArray(int arraySize, Type elementType)
		{
		}
	}
}
