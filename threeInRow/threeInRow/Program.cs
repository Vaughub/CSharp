using System;
using System.Threading;

namespace threeInRow
{
	class Program
	{
		static void Main(string[] args)
		{
			BoardModel model = new BoardModel();
			while (true)
			{
				BoardView.Show(model);
				if (model.GameRunning) Console.Write("Skriv inn hvor du vil sette kryss (f.eks. \"a2\"): ");
				else Console.WriteLine($"{model.winner} has won!, type 'r' to try again");
				var position = Console.ReadLine();
				if (!model.GameRunning && position == "r") model = new BoardModel();
				else if (!model.GameRunning) continue;

				model.SetCross(position);
				model.CheckIfWon();
				Thread.Sleep(2000);
				model.SetRandomCircle();
			}
		}
	}
}
