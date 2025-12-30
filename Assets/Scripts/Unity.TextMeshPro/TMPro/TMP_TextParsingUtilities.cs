namespace TMPro
{
	public class TMP_TextParsingUtilities
	{
		private static readonly TMP_TextParsingUtilities s_Instance;

		private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";

		private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

		public static TMP_TextParsingUtilities instance => null;

		static TMP_TextParsingUtilities()
		{
		}

		public static int GetHashCode(string s)
		{
			return 0;
		}

		public static int GetHashCodeCaseSensitive(string s)
		{
			return 0;
		}

		public static char ToLowerASCIIFast(char c)
		{
			return '\0';
		}

		public static char ToUpperASCIIFast(char c)
		{
			return '\0';
		}

		public static uint ToUpperASCIIFast(uint c)
		{
			return 0u;
		}

		public static uint ToLowerASCIIFast(uint c)
		{
			return 0u;
		}

		public static bool IsHighSurrogate(uint c)
		{
			return false;
		}

		public static bool IsLowSurrogate(uint c)
		{
			return false;
		}

		internal static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate)
		{
			return 0u;
		}
	}
}
