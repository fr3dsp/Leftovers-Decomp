using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	[Serializable]
	public struct BitArray64 : IBitArray
	{
		[SerializeField]
		private ulong data;

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

		public BitArray64(ulong initValue)
		{
			data = 0uL;
		}

		public BitArray64(IEnumerable<uint> bitIndexTrue)
		{
			data = 0uL;
		}

		public static BitArray64 operator ~(BitArray64 a)
		{
			return default(BitArray64);
		}

		public static BitArray64 operator |(BitArray64 a, BitArray64 b)
		{
			return default(BitArray64);
		}

		public static BitArray64 operator &(BitArray64 a, BitArray64 b)
		{
			return default(BitArray64);
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

		public static bool operator ==(BitArray64 a, BitArray64 b)
		{
			return false;
		}

		public static bool operator !=(BitArray64 a, BitArray64 b)
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
