using System;

namespace UnityEngine.Rendering
{
	public class SurfaceDataAttributes : Attribute
	{
		public string[] displayNames;

		public bool isDirection;

		public bool sRGBDisplay;

		public FieldPrecision precision;

		public bool checkIsNormalized;

		public SurfaceDataAttributes(string displayName = "", bool isDirection = false, bool sRGBDisplay = false, FieldPrecision precision = FieldPrecision.Default, bool checkIsNormalized = false)
		{
		}

		public SurfaceDataAttributes(string[] displayNames, bool isDirection = false, bool sRGBDisplay = false, bool checkIsNormalized = false, FieldPrecision precision = FieldPrecision.Default)
		{
		}
	}
}
