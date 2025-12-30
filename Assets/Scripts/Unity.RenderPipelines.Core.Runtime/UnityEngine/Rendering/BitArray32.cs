using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	[Serializable]
	public struct BitArray32 : IBitArray
	{
		[SerializeField]
		private uint data;

		public uint capacity => 0u;

		public bool allFalse => false;

		public bool allTrue => false;

		private string humanizedVersion => null;

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

		public BitArray32(uint initValue)
		{
			data = 0u;
		}

		public BitArray32(IEnumerable<uint> bitIndexTrue)
		{
			data = 0u;
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

		public static BitArray32 operator ~(BitArray32 a)
		{
			return default(BitArray32);
		}

		public static BitArray32 operator |(BitArray32 a, BitArray32 b)
		{
			return default(BitArray32);
		}

		public static BitArray32 operator &(BitArray32 a, BitArray32 b)
		{
			return default(BitArray32);
		}

		public static bool operator ==(BitArray32 a, BitArray32 b)
		{
			return false;
		}

		public static bool operator !=(BitArray32 a, BitArray32 b)
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
