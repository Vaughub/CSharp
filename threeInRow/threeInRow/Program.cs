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
				Console.Write("Skriv inn hvor du vil sette kryss (f.eks. \"a2\"): ");
				var position = Console.ReadLine();
				model.SetCross(position);
				BoardView.Show(model);
				model.CheckIfWon();
				if (model.GameRunning)
				{
					Thread.Sleep(1000);
					model.SetRandomCircle();
					BoardView.Show(model);
					model.CheckIfWon();
				}
				if (!model.GameRunning) model = new BoardModel();
			}
		}
	}
}
