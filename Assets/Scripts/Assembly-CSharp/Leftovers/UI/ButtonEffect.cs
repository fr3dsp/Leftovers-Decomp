using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Leftovers.UI
{
	public class ButtonEffect : MonoBehaviour
	{
		[SerializeField]
		private float hoveredScale;

		[SerializeField]
		private Color hoveredColor;

		[SerializeField]
		private float effectDuration;

		private TMP_Text textComponent;

		private Color originalColor;

		private float originalScale;

		private float timer;

		private Coroutine coroutine;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPointerOverDelegate(PointerEventData eventData)
		{
		}

		private void OnPointerOffDelegate(PointerEventData eventData)
		{
		}

		private IEnumerator PointerOverCoroutine()
		{
			return null;
		}

		private IEnumerator PointerOffCoroutine()
		{
			return null;
		}
	}
}
