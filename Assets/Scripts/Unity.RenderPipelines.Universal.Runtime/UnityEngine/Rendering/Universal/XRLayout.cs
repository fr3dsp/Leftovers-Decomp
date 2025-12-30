namespace UnityEngine.Rendering.Universal
{
	internal struct XRLayout
	{
		internal Camera camera;

		internal XRSystem xrSystem;

		internal XRPass CreatePass(XRPassCreateInfo passCreateInfo)
		{
			return null;
		}

		internal void AddViewToPass(XRViewCreateInfo viewCreateInfo, XRPass pass)
		{
		}
	}
}
