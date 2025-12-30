using System;

namespace UnityEngine.Rendering
{
	public class GenerateHLSL : Attribute
	{
		public PackingRules packingRules;

		public bool containsPackedFields;

		public bool needAccessors;

		public bool needSetters;

		public bool needParamDebug;

		public int paramDefinesStart;

		public bool omitStructDeclaration;

		public bool generateCBuffer;

		public int constantRegister;

		public GenerateHLSL(PackingRules rules = PackingRules.Exact, bool needAccessors = true, bool needSetters = false, bool needParamDebug = false, int paramDefinesStart = 1, bool omitStructDeclaration = false, bool containsPackedFields = false, bool generateCBuffer = false, int constantRegister = -1)
		{
		}
	}
}
