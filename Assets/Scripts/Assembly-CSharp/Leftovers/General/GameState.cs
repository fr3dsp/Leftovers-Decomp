using System;
using System.Collections;
using System.Collections.Generic;
using Leftovers.Neighbour;
using Leftovers.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace Leftovers.General
{
	public class GameState : MonoBehaviour
	{
		[Serializable]
		private class StringEvent : UnityEvent<string>
		{
		}

		[Serializable]
		private class IntEvent : UnityEvent<int>
		{
		}

		private static GameState instance;

		[SerializeField]
		private int startingNumberOfLeftovers;

		[SerializeField]
		private int startingNumberOfChances;

		[SerializeField]
		private int mistressThreshold;

		[SerializeField]
		private int[] chancesOpeningSegmentIndices;

		[SerializeField]
		private float cryDuration;

		[SerializeField]
		private AudioSource cryAudioSource;

		[SerializeField]
		private AudioClip cryAudioClip;

		[SerializeField]
		private NeighbourDialoguePlayer mumDialoguePlayer;

		[SerializeField]
		private Teleportation mumTeleportation;

		[SerializeField]
		private GameObject bully;

		[SerializeField]
		private UnityEvent onRestartOldMan;

		[SerializeField]
		private UnityEvent onRestartMistressChase;

		[SerializeField]
		private StringEvent onNumberOfLeftOversChanged;

		[SerializeField]
		private UnityEvent onMistressThresholdReached;

		[SerializeField]
		private UnityEvent onReceivedExtraLeftover;

		[SerializeField]
		private UnityEvent onGaveAwayExtraLeftover;

		[SerializeField]
		private UnityEvent onFoundCannedFood;

		private int numberOfLeftovers;

		private int numberOfChances;

		private bool canShowLeftovers;

		private bool hasExtraLeftover;

		private List<NeighbourState> neighbourStates;

		public static GameState Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int NumberOfLeftOvers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool HasExtraLeftOver
		{
			set
			{
			}
		}

		public bool CanShowLeftovers
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void ResetGame()
		{
		}

		private void Update()
		{
		}

		public void EditorDecreaseNumberOfLeftovers()
		{
		}

		public void DecreaseNumberOfLeftovers(int number)
		{
		}

		public void Cry()
		{
		}

		private IEnumerator DelayCry()
		{
			return null;
		}

		public void ForceMistressThreshold()
		{
		}

		public void RestartOldManConversation()
		{
		}

		public void RestartMistressChase()
		{
		}

		public void FoundCannedFood()
		{
		}
	}
}
