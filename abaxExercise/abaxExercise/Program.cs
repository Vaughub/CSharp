namespace abaxExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			Vehicle[] vehicle =
			{
				new Car("NF123456", 147, 200, "green", "light vehicle"),
				new Car("NF654321", 150, 195, "blue", "light vehicle"),
				new Plane("LN1234", 1000, null, "jet", 30, 2, 10),
				new Boat("ABC123", 100, 30, null, 500)
			};

			foreach (var veh in vehicle)
			{
				veh.Print();
			}
		}
	}
}
