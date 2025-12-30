namespace UnityEngine.Rendering.Universal
{
	[DisallowMultipleComponent]
	public class UniversalAdditionalLightData : MonoBehaviour
	{
		[SerializeField]
		private bool m_UsePipelineSettings;

		public bool usePipelineSettings
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
