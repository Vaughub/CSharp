using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace Players
{
	class Player
	{
		private string Name;
		private int Points;

		public Player(string name, int points)
		{
			Name = name;
			Points = points;
		}

		public void Play(Player player2)
		{
			Random random = new Random();
			while (true)
			{
				int power1 = random.Next(100);
				int power2 = random.Next(100);
				if (power1 > power2)
				{
					Points++;
					player2.Points--;
					break;
				}
				if (power1 < power2)
				{
					Points--;
					player2.Points++;
					break;
				}
			}
		}

		public void ShowNameAndPoints()
		{
			Console.WriteLine(Name + " - " + Points);
		}
	}
}
