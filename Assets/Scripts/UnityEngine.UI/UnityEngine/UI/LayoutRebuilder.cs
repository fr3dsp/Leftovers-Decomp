using System.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	public class LayoutRebuilder : ICanvasElement
	{
		private RectTransform m_ToRebuild;

		private int m_CachedHashFromTransform;

		private static ObjectPool<LayoutRebuilder> s_Rebuilders;

		public Transform transform => null;

		private void Initialize(RectTransform controller)
		{
		}

		private void Clear()
		{
		}

		static LayoutRebuilder()
		{
		}

		private static void ReapplyDrivenProperties(RectTransform driven)
		{
		}

		public bool IsDestroyed()
		{
			return false;
		}

		private static void StripDisabledBehavioursFromList(List<Component> components)
		{
		}

		public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot)
		{
		}

		public void Rebuild(CanvasUpdate executing)
		{
		}

		private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action)
		{
		}

		private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action)
		{
		}

		public static void MarkLayoutForRebuild(RectTransform rect)
		{
		}

		private static bool ValidController(RectTransform layoutRoot, List<Component> comps)
		{
			return false;
		}

		private static void MarkLayoutRootForRebuild(RectTransform controller)
		{
		}

		public void LayoutComplete()
		{
		}

		public void GraphicUpdateComplete()
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
