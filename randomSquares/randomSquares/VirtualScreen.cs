using System;

namespace randomSquares
{
	class VirtualScreen
	{
		private VirtualScreenRow[] rows;

		public VirtualScreen(int width, int height)
		{
			rows = new VirtualScreenRow[height];
			for (int i = 0; i < rows.Length; i++)
			{
				rows[i] = new VirtualScreenRow(width);
			}
		}

		public void Add(Box box)
		{
			rows[box.StartY].AddBoxTopRow(box.X, box.Width);
			for (int i = box.StartY + 1; i < box.EndY - 1; i++)
			{
				rows[i].AddBoxMiddleRow(box.X, box.Width);
			}
			rows[box.EndY - 1].AddBoxBottomRow(box.X, box.Width);
			AddColor(box);
		}

		public void Show()
		{
			for (int i = 0; i < rows.Length; i++)
			{
				for (int j = 0; j < rows[i].cells.Length; j++)
				{
					Console.ForegroundColor = rows[i].cells[j].color;
					Console.Write(rows[i].cells[j].GetCharacter());
				}
				Console.ResetColor();
				Console.WriteLine();
			}
		}

		public void AddColor(Box box)
		{
			for (int i = box.X; i < box.Width + box.X; i++)
			{
				rows[box.StartY].cells[i].color = box.color;
				rows[box.EndY - 1].cells[i].color = box.color;
			}
			for (int i = box.StartY + 1; i < box.Height + box.StartY - 1; i++)
			{
				rows[i].cells[box.X].color = box.color;
				rows[i].cells[box.X + box.Width - 1].color = box.color;
			}
		}
	}
}