using System;
using UnityEngine.Profiling;

namespace UnityEngine.Rendering
{
	public class ProfilingSampler
	{
		private Recorder m_Recorder;

		private Recorder m_InlineRecorder;

		internal CustomSampler sampler { get; private set; }

		internal CustomSampler inlineSampler { get; private set; }

		public string name { get; private set; }

		public bool enableRecording
		{
			set
			{
			}
		}

		public float gpuElapsedTime => 0f;

		public int gpuSampleCount => 0;

		public float cpuElapsedTime => 0f;

		public int cpuSampleCount => 0;

		public float inlineCpuElapsedTime => 0f;

		public int inlineCpuSampleCount => 0;

		public static ProfilingSampler Get<TEnum>(TEnum marker) where TEnum : Enum
		{
			return null;
		}

		public ProfilingSampler(string name)
		{
		}

		public void Begin(CommandBuffer cmd)
		{
		}

		public void End(CommandBuffer cmd)
		{
		}

		internal bool IsValid()
		{
			return false;
		}

		private ProfilingSampler()
		{
		}
	}
}
