namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	internal class RenderGraphDebugParams
	{
		public bool clearRenderTargetsAtCreation;

		public bool clearRenderTargetsAtRelease;

		public bool disablePassCulling;

		public bool immediateMode;

		public bool logFrameInformation;

		public bool logResources;

		public void RegisterDebug(string name)
		{
		}

		public void UnRegisterDebug(string name)
		{
		}
	}
}
