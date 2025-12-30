using System;

namespace UnityEngine.Rendering.Universal
{
	[Serializable]
	public class StencilStateData
	{
		public bool overrideStencilState;

		public int stencilReference;

		public CompareFunction stencilCompareFunction;

		public StencilOp passOperation;

		public StencilOp failOperation;

		public StencilOp zFailOperation;
	}
}
