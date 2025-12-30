using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	[Serializable]
	public struct BitArray8 : IBitArray
	{
		[SerializeField]
		private byte data;

		public uint capacity => 0u;

		public bool allFalse => false;

		public bool allTrue => false;

		public string humanizedData => null;

		public bool Item
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public BitArray8(byte initValue)
		{
			data = 0;
		}

		public BitArray8(IEnumerable<uint> bitIndexTrue)
		{
			data = 0;
		}

		public static BitArray8 operator ~(BitArray8 a)
		{
			return default(BitArray8);
		}

		public static BitArray8 operator |(BitArray8 a, BitArray8 b)
		{
			return default(BitArray8);
		}

		public static BitArray8 operator &(BitArray8 a, BitArray8 b)
		{
			return default(BitArray8);
		}

		public IBitArray BitAnd(IBitArray other)
		{
			return null;
		}

		public IBitArray BitOr(IBitArray other)
		{
			return null;
		}

		public IBitArray BitNot()
		{
			return null;
		}

		public static bool operator ==(BitArray8 a, BitArray8 b)
		{
			return false;
		}

		public static bool operator !=(BitArray8 a, BitArray8 b)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
