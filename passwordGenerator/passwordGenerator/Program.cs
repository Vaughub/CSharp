using System;

namespace passwordGenerator
{
	class Program
	{
		static readonly Random Random = new Random();

		static void Main(string[] args)
		{
			if (!CheckValid(args))
			{
				WriteInstruction();
				return;
			}
			string pattern = args[1].PadRight(Int32.Parse(args[0]), 'l');
			string password = "";

			while (pattern.Length > 0)
			{
				int pickChar = Random.Next(0, pattern.Length);
				char patChar = pattern[pickChar];
				if (patChar == 'l') password += GenerateRandomChar('a', 'z');
				if (patChar == 'L') password += GenerateRandomChar('A', 'Z');
				if (patChar == 'd') password += Random.Next(0, 10).ToString();
				if (patChar == 's') password += (char)Random.Next(33, 48);
				pattern = pattern.Remove(pickChar, 1);
			}
			Console.WriteLine(password);
		}

		static char GenerateRandomChar(char min, char max)
		{
			return (char)Random.Next(min, max);
		}

		static bool CheckValid(string[] args)
		{
			if (args.Length != 2) return false;
			if (!int.TryParse(args[0], out _)) return false;

			foreach (var item in args[1])
			{
				switch (item)
				{
					case 'l':
					case 'L':
					case 'd':
					case 's':
						continue;
					default:
						return false;
				}
			}

			return true;
		}

		static void WriteInstruction()
		{
			Console.WriteLine("Options:");
			Console.WriteLine("> l = lower case letter");
			Console.WriteLine("> L = upper case letter");
			Console.WriteLine("> d = digit");
			Console.WriteLine("> s = special character");
			Console.WriteLine("Example: 14 lLssdd");
		}
	}
}