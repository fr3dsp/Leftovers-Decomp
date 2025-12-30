using System;

namespace UnityEngine.UI
{
	public interface IMeshModifier
	{
		[Obsolete]
		void ModifyMesh(Mesh mesh);

		void ModifyMesh(VertexHelper verts);
	}
}
