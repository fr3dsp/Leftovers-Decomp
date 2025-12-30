using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	[Serializable]
	public struct BitArray256 : IBitArray
	{
		[SerializeField]
		private ulong data1;

		[SerializeField]
		private ulong data2;

		[SerializeField]
		private ulong data3;

		[SerializeField]
		private ulong data4;

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

		public BitArray256(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4)
		{
			data1 = 0uL;
			data2 = 0uL;
			data3 = 0uL;
			data4 = 0uL;
		}

		public BitArray256(IEnumerable<uint> bitIndexTrue)
		{
			data1 = 0uL;
			data2 = 0uL;
			data3 = 0uL;
			data4 = 0uL;
		}

		public static BitArray256 operator ~(BitArray256 a)
		{
			return default(BitArray256);
		}

		public static BitArray256 operator |(BitArray256 a, BitArray256 b)
		{
			return default(BitArray256);
		}

		public static BitArray256 operator &(BitArray256 a, BitArray256 b)
		{
			return default(BitArray256);
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

		public static bool operator ==(BitArray256 a, BitArray256 b)
		{
			return false;
		}

		public static bool operator !=(BitArray256 a, BitArray256 b)
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
