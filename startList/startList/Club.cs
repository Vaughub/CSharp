using System;
using System.Collections.Generic;
using System.Text;

namespace startList
{
	class Club
	{
		public string Name { get; }
		public List<Registration> List { get; }
		public List<Club> ClubList { get; set; }

		public Club(List<Registration> registration)
		{
			List = registration;
		}

		public Club(string name)
		{
			Name = name;
		}

		public void MakeClubList()
		{
			ClubList = new List<Club>();
			foreach (var person in List)
			{
				if (person.Club != "") ClubList.Add(new Club(person.Club));
			}
		}
	}
}
