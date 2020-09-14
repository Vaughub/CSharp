using System.Text;
using System.Linq;

namespace adventureRoom2
{
	class Room
	{
		public string Name { get; set; }
		public Door[] Doors { get; set; }
		public Key? KeyInRoom { get; set; }

		public Room(Door[] doors, Key? keyInRoom, string name)
		{
			Doors = doors;
			KeyInRoom = keyInRoom;
			Name = name;
		}

		public string LookAroundRoom()
		{
			var txtBuild = new StringBuilder();
			txtBuild.AppendLine("You see:");
			foreach (var door in Doors)
			{
				txtBuild.AppendLine($"   {(door.DoorOpen == false ? "Closed" : "Open")} {door.DoorColor.ToString().ToLower()} door");
			}
			if (KeyInRoom != null) txtBuild.Append($"   {KeyInRoom} key");

			return txtBuild.ToString();

		}

		public string PickUpKey(Player player)
		{
			if (KeyInRoom == null) return "   Nothing to pick up";
			player.InventoryKeys[player.Position] = (Key)KeyInRoom;
			KeyInRoom = null;
			return $"   You picked up the {player.InventoryKeys[player.Position].ToString().ToLower()} key";

		}

		public string TryOpenDoor(string door, Key[] inventory)
		{
			for (int i = 0; i < Doors.Length; i++)
			{
				if (Doors[i].DoorOpen || door != Doors[i].DoorColor.ToString().ToLower() || inventory[i] == Key.None) continue;
				Doors[i].DoorOpen = true;
				return $"   You opened the {Doors[i].DoorColor.ToString().ToLower()} door";
			}

			bool doorInRoom = Doors.Any(d => d.DoorColor.ToString().ToLower() == door);
			return doorInRoom ? "   You don't have the key to this door" : "   Door is not in this room";
		}

		public string TryGoNextRoom(string door, Player player)
		{
			foreach (var d in Doors)
			{
				if (door != d.DoorColor.ToString().ToLower() || !d.DoorOpen) continue;

				if ((int) d.DoorColor == player.Position)
				{
					player.Position++;
					return $"You went through the {d.DoorColor.ToString().ToLower()} door";
				}
				if ((int) d.DoorColor + 1 == player.Position)
				{
					player.Position--;
					return $"You went through the {d.DoorColor.ToString().ToLower()} door";
				}
			}

			bool doorInRoom = Doors.Any(d => d.DoorColor.ToString().ToLower() == door);
			return doorInRoom ? "Door is closed" : "Door is not in this room";
		}
	}
}