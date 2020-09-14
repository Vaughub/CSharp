namespace adventureRoom
{
	class House
	{
		public Room[] Rooms { get; set; }
		public Player User { get; set; }

		public House(Room[] rooms, Player user)
		{
			Rooms = rooms;
			User = user;
		}

		public string LookForKey()
		{
			if (Rooms[User.Position].KeyInRoom != Keys.None)
			{
				User.Content[User.Position] = Rooms[User.Position].KeyInRoom;
				Rooms[User.Position].KeyInRoom = Keys.None;
				return $"You have picked up {User.Content[User.Position]}";
			}
			else return "There is no key here";
		}

		public string Commands(string command)
		{
			var x = command.Split(' ');
			if (command == "pick") return Temp();
			if (command == "look") return Temp2();
			if (command == "inventory") return Temp3();
			if (x[0] == "door" && x.Length > 1) return Temp4(x[1]);
			return "Invalid command";
		}

		private string Temp4(string pickedDoor)
		{
			//if (pickedDoor == null) return "Invalid command";
			return Rooms[User.Position].TryOpenDoor(pickedDoor, User.Content);
		}

		private string Temp3()
		{
			return User.CheckInventory();
		}

		private string Temp2()
		{
			return Rooms[User.Position].LookAroundRoom();
		}

		private string Temp()
		{
			return Rooms[User.Position].LookForKey2(User);
		}
	}
}
