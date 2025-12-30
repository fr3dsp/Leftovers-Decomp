namespace UnityEngine.Rendering
{
	public static class TileLayoutUtils
	{
		public static bool TryLayoutByTiles(RectInt src, uint tileSize, out RectInt main, out RectInt topRow, out RectInt rightCol, out RectInt topRight)
		{
			main = default(RectInt);
			topRow = default(RectInt);
			rightCol = default(RectInt);
			topRight = default(RectInt);
			return false;
		}

		public static bool TryLayoutByRow(RectInt src, uint tileSize, out RectInt main, out RectInt other)
		{
			main = default(RectInt);
			other = default(RectInt);
			return false;
		}

		public static bool TryLayoutByCol(RectInt src, uint tileSize, out RectInt main, out RectInt other)
		{
			main = default(RectInt);
			other = default(RectInt);
			return false;
		}
	}
}
