using System;
using System.Collections.Generic;
using System.Text;

namespace adventureRoom
{
	class Room
	{
		public string Name { get; set; }
		public Door[] Door { get; set; }
		public Keys KeyOnTable { get; set; }


		public Room(string name, Door[] door, Keys keyOnTable)
		{
			Name = name;
			Door = door;
			KeyOnTable = keyOnTable;
		}


		public string LookAroundRoom()
		{
			if (KeyOnTable != null) return $"Room contains {KeyOnTable} key";
			return "Nothing";
		}

		//public string PickUpKey()
		//{

		//}

  //      public string UnlockDoor()
  //      {
			
  //      }
    }
}