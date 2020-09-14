using System;

namespace adventureRoom2
{
	class Program
	{
		static void Main(string[] args)
		{

			Door doorA = new Door(DoorColor.Red);
			Door doorB = new Door(DoorColor.Green);

			Room[] rooms =
			{
				new Room(new[] {doorA}, Key.Red, "Room A"),
				new Room(new[] {doorA, doorB}, Key.Green, "Room B"), 
				new Room(new[] {doorB}, null, "Room C"), 
			};

			Player player = new Player();

			House house = new House(rooms, player);

			Console.WriteLine("Welcome to Adventure Rooms");
			while (true)
			{
				if (rooms.Length - 1 == player.Position)
				{
					Console.WriteLine("You won");
					break;
				}
				Console.Write(">");
				string command =  Console.ReadLine();
				string output = house.HandelCommand(command);
				Console.WriteLine(output + "\n");
			}

		}
	}
}
