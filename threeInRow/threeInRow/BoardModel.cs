using System;

namespace threeInRow
{
	class BoardModel
	{
		public ArrContent[] Route { get; private set; }
		public bool GameRunning { get; private set; }
		private readonly Random Random;

		public BoardModel()
		{
			Route = new ArrContent[9];
			GameRunning = true;
			Random = new Random();
		}



		public void SetCross(string position)
		{
			while (true)
			{
				if (position.Length == 2)
				{
					int row = position[0] == 'a' ? 0 : position[0] == 'b' ? 1 : position[0] == 'c' ? 2 : 10;
					int column = position[1] == '1' ? 0 : position[1] == '2' ? 3 : position[1] == '3' ? 6 : 10;
					int index = row + column;
					if (index < 9 && Route[index] == ArrContent.Blank)
					{
						Route[index] = ArrContent.Cross;
						break;
					}
				}
				Console.WriteLine("Ugyldig trekk, prøv igjen");
				position = Console.ReadLine();
			}

		}

		public void SetRandomCircle()
		{
			while (true)
			{
				int randomInt = Random.Next(Route.Length);
				if (Route[randomInt] == ArrContent.Blank) Route[randomInt] = ArrContent.Circle;
				else continue;
				break;
			}
		}

		public void CheckIfWon()
		{
				CheckProgram(0, 1, 2);
				CheckProgram(3, 4, 5);
				CheckProgram(6, 7, 8);
				CheckProgram(0, 3, 6);
				CheckProgram(1, 4, 7);
				CheckProgram(2, 5, 8);
				CheckProgram(0, 4, 8);
				CheckProgram(6, 4, 2);
		}

		private void CheckProgram(int x, int y, int z)
		{
			if ((Route[x] == ArrContent.Cross || Route[x] == ArrContent.Circle) && Route[x] == Route[y] && Route[x] == Route[z])
			{
				Console.WriteLine($"The winner is '{(Route[x] == ArrContent.Circle ? "o" : "x")}'");
				while (true)
				{
					Console.WriteLine("Type 'r' to try again");
					string answer = Console.ReadLine();
					if (answer != "r") continue;
						GameRunning = false;
						break;
				}
			}
		}
	}
}
