using System.Text;

namespace adventureRoom
{
	class Room
	{
		public string Name { get; set; }
		public Door[] Door { get; set; }
		public Keys KeyInRoom { get; set; }


		public Room(string name, Door[] door, Keys keyOnTable = Keys.None)
		{
			Name = name;
			Door = door;
			KeyInRoom = keyOnTable;
		}


		public string LookForKey2(Player User)
		{
			if (KeyInRoom != Keys.None)
			{
				User.Content[User.Position] = KeyInRoom;
				KeyInRoom = Keys.None;
				return $"You picked up the {User.Content[User.Position]} key";
			}

			return "Nothing to pick up";
		}

		public string LookAroundRoom()
		{
			var txtBuild = new StringBuilder();
			txtBuild.Append("You see a");
			foreach (var door in Door)
			{
				txtBuild.Append($"{door} door ");
			}
			if (KeyInRoom != Keys.None) txtBuild.Append($"{KeyInRoom} key");

			return txtBuild.ToString();
		}

		public string TryOpenDoor(string pickedDoor, Keys[] userContent)
		{
			//foreach (var key in userContent)
			//{

			//}

			//userContent.Contains(Keys.Red);
			//userContent.Contains(userContent[i])


			for (int i = 0; i < Door.Length; i++)
			{
				if (pickedDoor.ToLower() == Door[i].ToString().ToLower() && userContent[i] != Keys.None)
				{
					Door[i] = adventureRoom.Door.Open;
					return $"You open the {pickedDoor} door";
				}
			}

			return "Unable to open door";
		}

		//if (Rooms[User.Position].KeyInRoom != Keys.None)
		//{
		//	User.Content[User.Position] = Rooms[User.Position].KeyInRoom;
		//	Rooms[User.Position].KeyInRoom = Keys.None;
		//	return $"You have picked up {User.Content[User.Position]}";
		//}
		//else return "There is no key here";



		//public string PickUpKey()
		//{

		//}

		//      public string UnlockDoor()
		//      {

		//      }


	}
}