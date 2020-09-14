using System.Linq;

namespace adventureRoom2
{
	class House
	{
		public Room[] Rooms { get; set; }
		public Player Player { get; set; }

		public House(Room[] rooms, Player player)
		{
			Rooms = rooms;
			Player = player;
		}

		public string HandelCommand(string txt)
		{
			string[] command = txt.Split(' ').Select(str => str.ToLowerInvariant()).ToArray();
			Room room = Rooms[Player.Position];
			if (command[0] == "help") return ShowHelpText();
			if (command[0] == "look") return room.LookAroundRoom();
			if (command[0] == "pick") return room.PickUpKey(Player);
			if (command.Length > 1 && command[0] == "open") return room.TryOpenDoor(command[1], Player.InventoryKeys);
			if (command.Length > 1 && command[0] == "go") 
				return room.TryGoNextRoom(command[1], Player) + $" / You are in {Rooms[Player.Position].Name}";
			return command[0] == "inventory" ? Player.CheckInventory() : "   Invalid command";
		}

		private string ShowHelpText()
		{
			return "   help			shows all commands\n" +
				   "   look			shows what is in the room\n" +
				   "   pick			picks up things in the room\n" +
			       "   open <color>		try to open selected door\n" +
				   "   go <color>		try to go through selected door\n" +
			       "   inventory		shows inventory\n";
		}
	}
}
