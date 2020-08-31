using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace startList
{
	class Program
	{
		static void Main(string[] args)
		{
			string filePath = Path.GetFullPath("startlist.csv");
			List<Registration> registration = File.ReadLines(filePath).Skip(1).Select(line => new Registration(line)).ToList();
			Club club = new Club(registration);
			club.MakeClubList();

			//foreach (var cl in club.ClubList)
			//{
			//	Console.WriteLine(cl.Name);
			//}

			//foreach (var person in registration)
			//{
			//	if (person.Club != "") Console.WriteLine(person.Club);
			//}

			//foreach (var person in club.List)
			//{
			//	if (person.Club != "") Console.WriteLine(person.Club);
			//}
		}
	}
}
