using System;
using System.Collections.Generic;
using System.Text;

namespace abaxExercise
{
	abstract class Vehicle
	{
		protected string RegNr { get; }
		protected int Effect { get; }
		protected int? TopSpeed { get; }
		protected string VehicleType { get; }

		protected Vehicle(string regNr, int effect, int? topSpeed, string vehicleType)
		{
			RegNr = regNr;
			Effect = effect;
			TopSpeed = topSpeed;
			VehicleType = vehicleType;
		}

		protected Dictionary<string, string> Label = new Dictionary<string, string>
		{
			{nameof(TopSpeed), "km/t"},
			{"Effect", "kw"}
		};

		public void Print()
		{
			Console.WriteLine(BuildTxt());
		}

		protected string BuildTxt()
		{
			var txt = new StringBuilder();
			txt.AppendLine(GetType().Name);
			txt.AppendLine("Registration: " + RegNr);
			Add(txt, nameof(TopSpeed), TopSpeed);
			Add(txt, "Effect", Effect);
			Add(txt, "Vehicle Type", VehicleType);
			AdditionalInfo(txt);
			return txt.ToString();
		}

		protected void Add(StringBuilder txt, string label, object value)
		{
			if (value == null) return;
			txt.Append(label);
			txt.Append(": ");
			txt.Append(value);
			if (Label.ContainsKey(label)) txt.Append(Label[label]);
			txt.AppendLine();
		}

		protected abstract void AdditionalInfo(StringBuilder stringBuilder);
	}
}
