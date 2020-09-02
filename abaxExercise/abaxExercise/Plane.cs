using System.Text;

namespace abaxExercise
{
	internal class Plane : Vehicle
	{
		internal int Wingspan { get; }
		internal int LoadCapacity { get; }
		internal int DeadWeight { get; }

		public Plane(string regNr, int effect, int? topSpeed, string vehicleType, int wingspan, int loadCapacity, int deadWeight)
			: base(regNr, effect, topSpeed, vehicleType)
		{
			Wingspan = wingspan;
			LoadCapacity = loadCapacity;
			DeadWeight = deadWeight;
		}

		protected override void AdditionalInfo(StringBuilder txt)
		{
			txt.AppendLine("Wingspan: " + Wingspan + "m");
			txt.AppendLine("Load capacity: " + LoadCapacity + " Tonn");
			txt.AppendLine("Dead weight: " + DeadWeight + " Tonn");
		}
	}
}
