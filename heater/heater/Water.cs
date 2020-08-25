using System;

namespace heater
{
	public class Water
	{
		public double Amount { get; }
		public WaterState State { get; private set; }
		public double Temperature { get; private set; }
		public double? ProportionFirstState { get; private set; }

		public Water(double amount, double temperature, double? proportion = null)
		{
			Amount = amount;
			Temperature = temperature;
			State = temperature <= 0 ? WaterState.Solid : temperature >= 100 ? WaterState.Gas : WaterState.Liquid;

			if (temperature != 100 && temperature != 0) return;
			if (proportion == null) throw new ArgumentException("When temperature is 0 or 100, you must provide a value for proportion");
			ProportionFirstState = proportion;
			State = temperature == 0 ? WaterState.SolidAndLiquid : WaterState.LiquidAndGas;
		}

		public void AddEnergy(double calories)
		{
			double degreesUp = calories / Amount;

			if (Temperature < 0 && Temperature + degreesUp > 0)
			{
				double caloriesToZero = -Temperature * Amount;
				double caloriesToLiquid = 80 * Amount;
				calories -= caloriesToZero;
				ProportionFirstState = calories / caloriesToLiquid >= 1 ? 0 : 1 - calories / caloriesToLiquid;
				State = ProportionFirstState == 0 ? WaterState.Liquid : WaterState.SolidAndLiquid;
				Temperature = ProportionFirstState == 0 ? (calories - caloriesToLiquid) / Amount : 0;
			}
			else if (Temperature < 100 && Temperature + degreesUp > 100)
			{
				double caloriesToBoiling = (100 - Temperature) * Amount;
				double caloriesToGas = 600 * Amount;
				calories -= caloriesToBoiling;
				ProportionFirstState = calories / caloriesToGas >= 1 ? 0 : 1 - calories / caloriesToGas;
				State = ProportionFirstState == 0 ? WaterState.Gas : WaterState.LiquidAndGas;
				Temperature = ProportionFirstState == 0 ? 100 + (calories - caloriesToGas) / Amount : 100;
			}
			else Temperature += degreesUp;
		}
	}
}
