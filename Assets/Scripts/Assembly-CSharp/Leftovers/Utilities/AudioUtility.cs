using System.Collections;
using UnityEngine;

namespace Leftovers.Utilities
{
	public class AudioUtility : MonoBehaviour
	{
		[SerializeField]
		private AudioSource audioSource;

		[SerializeField]
		private float volume;

		public void StartFadeIn(float duration)
		{
		}

		private IEnumerator FadeIn(float duration)
		{
			return null;
		}

		public void StartFadeOut(float duration)
		{
		}

		private IEnumerator FadeOut(float duration)
		{
			return null;
		}

		public void PlayIfNotPlaying()
		{
		}
	}
}
