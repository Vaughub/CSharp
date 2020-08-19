namespace randomSquares
{
	class Screen
	{
		public VirtualScreenCell[][] col;

		public Screen()
		{
			col = new VirtualScreenCell[20][];
			for (int i = 0; i < col.Length; i++)
			{
				col[i] = new VirtualScreenCell[20];
				for (int j = 0; j < col[i].Length; j++)
				{
					col[i][j] = new VirtualScreenCell();
				}
			}
		}
	}
}