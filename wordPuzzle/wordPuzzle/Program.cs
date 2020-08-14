using System;
using System.Collections.Generic;
using System.IO;

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
				string startWord = dictionary[ranInt];
				Console.Write(startWord);
				FindMatchingWord(dictionary, startWord);
			}
		}

		private static void FindMatchingWord(string[] dictionary, string startWord)
		{
			int numb = 3;
			List<string> wordArray = new List<string> {startWord};
			while (numb < 6)
			{
				for (int i = 0; i < dictionary.Length; i++)
				{
					string word = dictionary[i];
					if (!word.StartsWith(startWord.Substring(startWord.Length - numb)) || wordArray.Contains(word)) continue;
					wordArray.Add(word);
					startWord = word;
					Console.Write(" - " + word);
					numb = 3;
					i = 0;
				}
				numb++;
			}
			Console.WriteLine();
		}

		static string[] DictionaryList()
		{
			const string path = @"C:\Users\OKaml\Documents\Modul 3\CSharp\wordPuzzle\wordPuzzle\ordliste.txt";
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
