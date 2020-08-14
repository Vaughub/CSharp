using System;
using System.Collections.Generic;
using System.IO;

namespace wordPuzzle
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] dictionary = DictionaryList();
			Random random = new Random();
			for (int i = 0; i < 200; i++)
			{
				int ranInt = random.Next(dictionary.Length);
				string startWord = dictionary[ranInt];
				Console.Write(startWord);
				FindMatchingWord(dictionary, startWord);
			}
		}

		static void FindMatchingWord(string[] dictionary, string startWord)
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
			Console.WriteLine("\n");
			Console.WriteLine("\n");
		}

		static string[] DictionaryList()
		{
			const string path = @"C:\Users\OKaml\Documents\Modul 3\CSharp\wordPuzzle\wordPuzzle\ordliste.txt";
			string prevWord = string.Empty;
			List<string> list = new List<string>();
			foreach (var lines in File.ReadLines(path))
			{
				var tab = lines.Split('\t');
				var word = tab[1].Trim().ToLower();
				if (prevWord == word || word.Length < 7 || word.Length > 10 || word.Contains('-')) continue;
				prevWord = word;
				list.Add(word);
			}
			return list.ToArray();
		}
	}
}
