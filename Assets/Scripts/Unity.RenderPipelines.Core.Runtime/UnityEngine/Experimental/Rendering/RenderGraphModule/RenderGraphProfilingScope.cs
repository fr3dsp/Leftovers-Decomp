using System;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	public struct RenderGraphProfilingScope : IDisposable
	{
		private bool m_Disposed;

		private ProfilingSampler m_Sampler;

		private RenderGraph m_RenderGraph;

		public RenderGraphProfilingScope(RenderGraph renderGraph, ProfilingSampler sampler)
		{
			m_Disposed = false;
			m_Sampler = null;
			m_RenderGraph = null;
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}
	}
}
