using System;

namespace threeInRow
{
	class BoardView
	{
		public static void Show(BoardModel model)
		{
			Console.Clear();
			Console.WriteLine("  a b c ");
			Console.WriteLine(" ┌─────┐");
			DrawMoves(model, 0);
			DrawMoves(model, 3);
			DrawMoves(model, 6);
			Console.WriteLine(" └─────┘");
			
		}

		private static void DrawMoves(BoardModel model, int index)
		{
			Console.Write(index / 3 + 1);
			Console.Write("│");
			for (int i = index; i < index + 3; i++)
			{
				if (i != index) Console.Write(' ');
				Console.Write(model.Route[i] == ArrContent.Blank ? ' ' : model.Route[i] == ArrContent.Cross ? 'x' : 'o');
			}
			Console.WriteLine("│");

		}
	}
}
