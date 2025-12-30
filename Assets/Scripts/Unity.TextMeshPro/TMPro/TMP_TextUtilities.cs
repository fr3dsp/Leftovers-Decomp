using UnityEngine;

namespace TMPro
{
	public static class TMP_TextUtilities
	{
		private struct LineSegment
		{
			public Vector3 Point1;

			public Vector3 Point2;

			public LineSegment(Vector3 p1, Vector3 p2)
			{
				Point1 = default(Vector3);
				Point2 = default(Vector3);
			}
		}

		private static Vector3[] m_rectWorldCorners;

		private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";

		private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera)
		{
			return 0;
		}

		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor)
		{
			cursor = default(CaretPosition);
			return 0;
		}

		public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera)
		{
			return 0;
		}

		public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly)
		{
			return 0;
		}

		public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera)
		{
			return false;
		}

		public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly)
		{
			return 0;
		}

		public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly)
		{
			return 0;
		}

		public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera)
		{
			return 0;
		}

		public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera)
		{
			return 0;
		}

		public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera)
		{
			return 0;
		}

		public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera)
		{
			return 0;
		}

		public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera)
		{
			return 0;
		}

		private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d)
		{
			return false;
		}

		public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint)
		{
			worldPoint = default(Vector3);
			return false;
		}

		private static bool IntersectLinePlane(LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint)
		{
			intersectingPoint = default(Vector3);
			return false;
		}

		public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point)
		{
			return 0f;
		}

		public static char ToLowerFast(char c)
		{
			return '\0';
		}

		public static char ToUpperFast(char c)
		{
			return '\0';
		}

		internal static uint ToUpperASCIIFast(uint c)
		{
			return 0u;
		}

		public static int GetHashCode(string s)
		{
			return 0;
		}

		public static int GetSimpleHashCode(string s)
		{
			return 0;
		}

		public static uint GetSimpleHashCodeLowercase(string s)
		{
			return 0u;
		}

		public static int HexToInt(char hex)
		{
			return 0;
		}

		public static int StringHexToInt(string s)
		{
			return 0;
		}
	}
}
