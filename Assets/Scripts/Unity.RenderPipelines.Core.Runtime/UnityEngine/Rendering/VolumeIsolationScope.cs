using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Rendering
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Obsolete]
	public struct VolumeIsolationScope : IDisposable
	{
		public VolumeIsolationScope(bool unused)
		{
		}

		void IDisposable.Dispose()
		{
		}
	}
}
