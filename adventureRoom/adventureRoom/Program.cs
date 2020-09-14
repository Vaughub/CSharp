using System;

namespace adventureRoom
{
	class Program
	{
		static void Main(string[] args)
		{
            /*
			        { A: 'B', B: 'A', farge: 'rød', åpen: false },
                    { A: 'D', D: 'A', farge: 'grønn', åpen: false },
                    { B: 'C', C: 'B', farge: 'grå', åpen: false },
                    { B: 'E', E: 'B', farge: 'blå', åpen: false },
                    { E: 'F', F: 'E', farge: 'hvit', åpen: false },
			 */
            Room[] rooms =
            {
                new Room("A", new[] {Door.Red}, Keys.Red),
                new Room("B", new []{Door.Red, Door.Green}, Keys.Green),
                new Room("C", new []{Door.Green}), 
            };

            Player player = new Player();

			House house = new House(rooms, player);


			while (true)
			{
				string command = Console.ReadLine();

				string output = house.Commands(command);

				Console.WriteLine(output + "\n");
            }


		}
    }
}
