using System.Text;

namespace abaxExercise
{
	internal class Car : Vehicle
	{
		internal string Color { get; }

		public Car(string regNr, int effect, int? topSpeed, string color, string vehicleType) : base(regNr, effect, topSpeed, vehicleType)
		{
			Color = color;
		}

		protected override void AdditionalInfo(StringBuilder txt)
		{
			txt.AppendLine("Color: " + Color);
		}
	}
}
