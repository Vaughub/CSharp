using System;

namespace randomSquares
{
	class VirtualScreenRow
	{
		public VirtualScreenCell[] cells;

		public VirtualScreenRow(int screenWidth)
		{
			cells = new VirtualScreenCell[screenWidth];
			for (int i = 0; i < cells.Length; i++) cells[i] = new VirtualScreenCell();
		}

		public void AddBoxTopRow(int boxX, int boxWidth)
		{
			cells[boxX].AddLowerRightCorner();
			cells[boxX + (boxWidth - 1)].AddLowerLeftCorner();
			for (int i = boxX + 1; i < boxX + (boxWidth - 1); i++) cells[i].AddHorizontal();
		}

		public void AddBoxMiddleRow(int boxX, int boxWidth)
		{
			cells[boxX].AddVertical();
			cells[boxX + (boxWidth - 1)].AddVertical();
		}

		public void AddBoxBottomRow(int boxX, int boxWidth)
		{
			cells[boxX].AddUpperRightCorner();
			cells[boxX + (boxWidth - 1)].AddUpperLeftCorner();
			for (int i = boxX + 1; i < boxX + (boxWidth - 1); i++) cells[i].AddHorizontal();
		}
	}
}
