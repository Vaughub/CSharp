using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace purePuzzle
{
	class Program
	{
		static void Main(string[] args)
		{
			// 2-1

			//int counter = 0;
			//while (counter < 4)
			//{
			//	for (int i = 0; i < 8; i++)
			//	{
			//		if (counter == 1 && (i == 0 || i == 7)) Console.Write(' ');
			//		else if (counter == 2 && (i == 0 || i == 1 || i == 6 || i == 7)) Console.Write(' ');
			//		else if (counter == 3 && (i == 0 || i == 1 || i == 2 || i == 5 || i == 6 || i == 7)) Console.Write(' ');
			//		else Console.Write('#');
			//	}
			//	Console.WriteLine();
			//	counter++;
			//}

			// 2-1

			//for (int i = 0; i < 4; i++)
			//{
			//	space(i);
			//	hash(8 - 2 * i);
			//	Console.WriteLine();
			//}

			// 2-2

			//for (int i = 3; i >= 0; i--)
			//{
			//	space(i);
			//	hash(8 - 2 * i);
			//	Console.WriteLine();
			//}

			//for (int i = 0; i < 4; i++)
			//{
			//	space(i);
			//	hash(8 - 2 * i);
			//	Console.WriteLine();
			//}

			// 2-3

			//for (int i = 0; i < 4; i++)
			//{
			//	space(i);
			//	hash(i + 1);
			//	space(12 - 4 * i);
			//	hash(i + 1);
			//	Console.WriteLine();
			//}

			//for (int i = 3; i >= 0; i--)
			//{
			//	space(i);
			//	hash(i + 1);
			//	space(12 - 4 * i);
			//	hash(i + 1);
			//	Console.WriteLine();
			//}

			// 2-9

			string[] names = { "Ola", "Petter", "Sissel", "Eivind", "aaaaa" };
			int words = 0;
			string vowelsWord = "";
			string longestWord = "";

			foreach (var item in names)
			{
				int itemVowels = item.Count("aeiouAEIOU".Contains);
				int vowels = vowelsWord.Count("aeiouAEIOU".Contains);

				if (item.Length > longestWord.Length) longestWord = item;
				if (itemVowels > vowels) vowelsWord = item;
				words++;
			}
			Console.WriteLine("Number of words: " + words);
			Console.WriteLine("Word with most vowels: " + vowelsWord);
			Console.WriteLine("The longest word: " + longestWord);

		}

		static void space(int count) 
		{
			for (int i = 0; i < count; i++) Console.Write(' ');
		}

		static void hash(int count)
		{
			for (int i = 0; i < count; i++) Console.Write('#');
		}


	}
}
