namespace TMPro
{
	public struct CaretInfo
	{
		public int index;

		public CaretPosition position;

		public CaretInfo(int index, CaretPosition position)
		{
			this.index = 0;
			this.position = default(CaretPosition);
		}
	}
}
