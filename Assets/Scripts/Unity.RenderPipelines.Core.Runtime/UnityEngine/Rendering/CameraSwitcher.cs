namespace UnityEngine.Rendering
{
	public class CameraSwitcher : MonoBehaviour
	{
		public Camera[] m_Cameras;

		private int m_CurrentCameraIndex;

		private Camera m_OriginalCamera;

		private Vector3 m_OriginalCameraPosition;

		private Quaternion m_OriginalCameraRotation;

		private Camera m_CurrentCamera;

		private GUIContent[] m_CameraNames;

		private int[] m_CameraIndices;

		private DebugUI.EnumField m_DebugEntry;

		private int m_DebugEntryEnumIndex;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private int GetCameraCount()
		{
			return 0;
		}

		private Camera GetNextCamera()
		{
			return null;
		}

		private void SetCameraIndex(int index)
		{
		}
	}
}
