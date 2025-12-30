using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[ExecuteAlways]
	public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier
	{
		[NonSerialized]
		private Graphic m_Graphic;

		protected Graphic graphic => null;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}

		public virtual void ModifyMesh(Mesh mesh)
		{
		}

		public abstract void ModifyMesh(VertexHelper vh);
	}
}
