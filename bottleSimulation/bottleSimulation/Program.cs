using System;
using System.Collections.Generic;
using FlaskeTing;

namespace Ver2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] userInput = GetUserInput();
			Bottle bottle1 = new Bottle(userInput[0]);
			Bottle bottle2 = new Bottle(userInput[1]);
			int counter = 1;
			int wantedVolume = userInput[2];
			int[] arrayBin = new int[counter];
			List<int> storage = new List<int>();

			while (true)
			{
				DoOperations(arrayBin, bottle1, bottle2, storage);
				if (IsSolved(bottle1, bottle2, wantedVolume, arrayBin, storage)) break;
				if (!PlusTheBit(arrayBin))
				{
					counter++;
					arrayBin = new int[counter];
					storage = new List<int>();
				}
				if (arrayBin.Length != 9) continue;
				Console.WriteLine("Stopped");
				break;
			}
		}

		private static int[] GetUserInput()
		{
			Console.WriteLine("Give the bottles a max capacity");
			int[] tempArray = new int[3];
			for (int i = 0; i < tempArray.Length; i++)
			{
				if (i < 2) Console.WriteLine("Bottle " + (i + 1));
				else Console.WriteLine("Wanted amount ");
				if (int.TryParse(Console.ReadLine().Trim(), out int userInput)) tempArray[i] = userInput;
				else GetUserInput();
			}
			return tempArray;
		}

		static bool PlusTheBit(int[] arrayBin)
		{
			int i;
			for (i = arrayBin.Length - 1; i >= 0; i--)
			{
				if (arrayBin[i] < 7)
				{
					arrayBin[i]++;
					break;
				}
				arrayBin[i] = 0;
			}
			return i != -1;
		}

		private static bool IsSolved(Bottle bottle1, Bottle bottle2, int wantedVolume, int[] arrayBin, List<int> storage)
		{
			int[] action = storage.ToArray();
			if (bottle1.Content != wantedVolume && bottle2.Content != wantedVolume) return false;
			for (var i = 0; i < arrayBin.Length; i++)
			{
				var operation = arrayBin[i];
				Console.Write((i + 1) + ": " + operationNames[operation]);
				int index1 = 2 * (arrayBin.Length - i);
				int index2 = 2 * (arrayBin.Length - i - 1) + 1;
				Console.WriteLine(" - " + action[action.Length - index1] + " / " + action[action.Length - index2]);
			}
			return true;
		}

		static string[] operationNames = {
			"Fylle flaske 1 fra springen",
			"Fylle flaske 2 fra springen",
			"Tømme flaske 1 i flaske 2",
			"Tømme flaske 2 i flaske 1",
			"Fylle opp flaske 2 med flaske 1",
			"Fylle opp flaske 1 med flaske 2",
			"Tømme flaske 1 (kaste vannet)",
			"Tømme flaske 2 (kaste vannet)",
		};


		private static void DoOperations(int[] operations, Bottle bottle1, Bottle bottle2, List<int> storage)
		{
			bottle1.Empty();
			bottle2.Empty();
			foreach (var operation in operations)
			{
				if (operation == 0) bottle1.FillToTopFromTap();
				else if (operation == 1) bottle2.FillToTopFromTap();
				else if (operation == 2) bottle2.Fill(bottle1.Empty());
				else if (operation == 3) bottle1.Fill(bottle2.Empty());
				else if (operation == 4) bottle2.FillToTop(bottle1);
				else if (operation == 5) bottle1.FillToTop(bottle2);
				else if (operation == 6) bottle1.Empty();
				else if (operation == 7) bottle2.Empty();
				//if (storage.Count > 300) storage = new List<int>();
				storage.Add(bottle1.Content);
				storage.Add(bottle2.Content);
			}
		}
	}
}