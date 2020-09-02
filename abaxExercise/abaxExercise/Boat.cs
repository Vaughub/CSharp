using System.Text;

namespace abaxExercise
{
	internal class Boat : Vehicle
	{
		internal int GrossTonnage { get; }

		public Boat(string regNr, int effect, int? topSpeed, string vehicleType, int grossTonnage) 
			: base(regNr, effect, topSpeed, vehicleType)
		{
			GrossTonnage = grossTonnage;
			Label[nameof(TopSpeed)] = "knop";
		}

		protected override void AdditionalInfo(StringBuilder txt)
		{
			txt.AppendLine("Gross tonnage: " + GrossTonnage + "kg");
		}
	}
}
