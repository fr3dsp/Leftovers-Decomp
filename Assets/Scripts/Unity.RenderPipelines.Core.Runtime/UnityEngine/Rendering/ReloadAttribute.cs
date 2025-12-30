using System;

namespace UnityEngine.Rendering
{
	public sealed class ReloadAttribute : Attribute
	{
		public enum Package
		{
			Builtin = 0,
			Root = 1
		}

		public ReloadAttribute(string[] paths, Package package = Package.Root)
		{
		}

		public ReloadAttribute(string path, Package package = Package.Root)
		{
		}

		public ReloadAttribute(string pathFormat, int rangeMin, int rangeMax, Package package = Package.Root)
		{
		}
	}
}
