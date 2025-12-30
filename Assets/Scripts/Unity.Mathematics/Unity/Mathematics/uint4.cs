using System;
using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
	[Serializable]
	public struct uint4 : IEquatable<uint4>, IFormattable
	{
		internal sealed class DebuggerProxy
		{
		}

		public uint x;

		public uint y;

		public uint z;

		public uint w;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public uint4(uint x, uint y, uint z, uint w)
		{
			this.x = 0u;
			this.y = 0u;
			this.z = 0u;
			this.w = 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 operator *(uint4 lhs, uint4 rhs)
		{
			return default(uint4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(uint4 rhs)
		{
			return false;
		}

		public override bool Equals(object o)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
}
