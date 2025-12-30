using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering.UI
{
	public class DebugUIHandlerCanvas : MonoBehaviour
	{
		private int m_DebugTreeState;

		private Dictionary<Type, Transform> m_PrefabsMap;

		public Transform panelPrefab;

		public List<DebugUIPrefabBundle> prefabs;

		private List<DebugUIHandlerPanel> m_UIPanels;

		private int m_SelectedPanel;

		private DebugUIHandlerWidget m_SelectedWidget;

		private string m_CurrentQueryPath;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		internal void ResetAllHierarchy()
		{
		}

		private void Rebuild()
		{
		}

		private void Traverse(DebugUI.IContainer container, Transform parentTransform, DebugUIHandlerWidget parentUIHandler)
		{
		}

		private DebugUIHandlerWidget GetWidgetFromPath(string queryPath)
		{
			return null;
		}

		private void ActivatePanel(int index, bool tryAndKeepSelection = false)
		{
		}

		internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext)
		{
		}

		private void SelectPreviousItem()
		{
		}

		private void SelectNextItem()
		{
		}

		private void ChangeSelectionValue(float multiplier)
		{
		}

		private void ActivateSelection()
		{
		}

		private void HandleInput()
		{
		}
	}
}
