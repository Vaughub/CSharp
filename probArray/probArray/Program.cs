using System;

namespace probArray
{
	class Program
	{
		static readonly Random Random = new Random();

		static void Main(string[] args)
		{
			//work3();
			//work4();
			work5();

		}

		static void work3() 
		{
			int[] values = { 1, 2, 3, 4 };
			if (CheckIfSorted(values)) Console.WriteLine("True");
			else Console.WriteLine("False");
		}

		static bool CheckIfSorted(int[] x)
		{
			for (int i = 1; i < x.Length; i++)
			{
				if (x[i - 1] > x[i]) return false;
			}
			return true;
		}

		static void work4()
		{
			char[] cipher = { 'T', 'Y', 'W', 'P', 'O', 'Q', 'F', 'G', 'S', 'A', 'N', 'B', 'M' };
			string plainText = "ABC";
			string cipherText = "";
			string newText = "";

			foreach (var letter in plainText)
			{
				cipherText += cipher[(int)letter - 65];
			}
			Console.WriteLine($"{plainText} -> {cipherText}");
			foreach (var letter in cipherText)
			{
				for (int i = 0; i < cipher.Length; i++)
				{
					if (cipher[i] == letter)
					{
						int val = 65 + i;
						newText += (char)val;
					}
				}
			}
			Console.WriteLine($"{cipherText} -> {newText}");
		}

		static void work5()
		{
			var cipher = new char[26];
			while (cipher[25] == '\0') 
			{
				for (var i = 0; i < cipher.Length; i++)
				{
					//cipher[i] = Random.Next('A', 'Z').ToString();

					cipher[i] = (char)Random.Next('a', 'z');

					foreach (var letter in cipher)
					{

					}
				
				}
			}
			for (var i = 0; i < cipher.Length; i++)
			{
				Console.WriteLine($"{i}:{cipher[i]}");
			}
		}


	}
}
