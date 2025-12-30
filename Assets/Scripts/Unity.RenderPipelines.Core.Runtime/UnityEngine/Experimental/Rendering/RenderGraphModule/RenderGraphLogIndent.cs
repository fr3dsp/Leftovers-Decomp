using System;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	internal struct RenderGraphLogIndent : IDisposable
	{
		private int m_Indentation;

		private RenderGraphLogger m_Logger;

		private bool m_Disposed;

		public RenderGraphLogIndent(RenderGraphLogger logger, int indentation = 1)
		{
			m_Indentation = 0;
			m_Logger = null;
			m_Disposed = false;
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}
	}
}
