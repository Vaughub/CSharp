using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace wordPuzzle
{
	class Program
	{
		static readonly Random Random = new Random();
			
		static void Main(string[] args)
		{
			string[] dictionary = DictionaryList();
			for (int i = 0; i < 400; i++)
			{
				int ranInt = Random.Next(dictionary.Length);
				string ranWord = dictionary[ranInt];
				Console.Write(ranWord);
				MatchWord(dictionary, ranWord);
			}
		}

		private static void MatchWord(string[] dictionary, string ranWord)
		{
			int numb = 3;
			int count = 1;
			bool shouldAdd = true;
			string[] wordArray = new string[20];
			wordArray[0] = ranWord;
			while (numb < 6)
			{
				foreach (var word in dictionary)
				{
	
					if (!word.StartsWith(ranWord.Substring(ranWord.Length - numb))) continue;
					foreach (var prevWord in wordArray)
					{
						if (word == prevWord) shouldAdd = false;
					}

					if (shouldAdd)
					{
						wordArray[count] = word;
						ranWord = word;
						Console.Write(" - " + word);
						numb = 3;
						count++;
					}
					shouldAdd = true;
				}
				numb++;
			}
			Console.WriteLine();
		}

		static string[] DictionaryList()
		{
			const string path = @"C:\Users\OKaml\Documents\Modul 3\wordPuzzle\wordPuzzle\ordliste.txt";
			string prevWord = string.Empty;
			var list = new List<string>();
			foreach (var lines in File.ReadLines(path))
			{
				var tab = lines.Split('\t');
				var word = tab[1].Trim();
				if (prevWord == word || word.Length < 7 || word.Length > 10 || word.Contains("-")) continue;
				prevWord = word;
				list.Add(word);
			}
			return list.ToArray();
		}
	}
}
