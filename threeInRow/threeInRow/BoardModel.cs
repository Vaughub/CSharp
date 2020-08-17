using System;

namespace threeInRow
{
	class BoardModel
	{
		public string[] route = { " ", " ", " ", " ", " ", " ", " ", " ", " " };
		public bool GameRunning = true;
		public string winner = " ";

		private readonly Random random = new Random();

		public void SetCross(string position)
		{
			for (int i = 0; i < 3; i++)
			{
				if (position == $"a{i + 1}" && route[i] == " ")
				{
					route[i] = "x";
					return;
				}
				if (position == $"b{i + 1}" && route[i + 3] == " ")
				{
					route[i + 3] = "x";
					return;
				}
				if (position == $"c{i + 1}" && route[i + 6] == " ")
				{
					route[i + 6] = "x";
					return;
				}
			}
			Console.WriteLine("Ugylding trekk, prøv igjen");
		}

		public void SetRandomCircle()
		{
			while (true)
			{
				int randomInt = random.Next(route.Length);
				if (route[randomInt] == " ") route[randomInt] = "o";
				else continue;
				break;
			}
			CheckIfWon();
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
			if ((route[x] == "x" || route[x] == "o") && route[x] == route[y] && route[x] == route[z])
			{
				winner = $"{x}";
				GameRunning = false;
			}

		}
	}
}
