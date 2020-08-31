using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace startList
{
	class Registration
	{
		public int StartNumber { get; private set; }
		public string Name { get; private set; }
		public string Club { get; private set; }
		public string Nationality { get; private set; }
		public string Group { get; private set; }
		public string Class { get; private set; }

		//public Registration(string startNumber, string name, string club, string nationality, string group, string @class)
		//{
		//	StartNumber = startNumber;
		//	Name = name;
		//	Club = club;
		//	Nationality = nationality;
		//	Group = group;
		//	Class = @class;
		//}

		public Registration(string line)
		{
			//line = split[i] = split[i].Trim('/', '"');
			string[] field = line.Split(',').Select(f => f.Trim('/', '"')).ToArray();

			StartNumber = field[0] != "" ? int.Parse(field[0]) : 0;
			Name = field[1];
			Club = field[2];
			Nationality = field[3];
			Group = field[4];
			Class = field[5];
		}

		public void Description()
		{
			//Console.WriteLine(StartNumber + Name + Club + Nationality + Group + Class);
			Console.WriteLine(Club);
		}
	}
}
