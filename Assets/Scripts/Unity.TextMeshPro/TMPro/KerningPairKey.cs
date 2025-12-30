namespace TMPro
{
	public struct KerningPairKey
	{
		public uint ascii_Left;

		public uint ascii_Right;

		public uint key;

		public KerningPairKey(uint ascii_left, uint ascii_right)
		{
			ascii_Left = 0u;
			ascii_Right = 0u;
			key = 0u;
		}
	}
}
