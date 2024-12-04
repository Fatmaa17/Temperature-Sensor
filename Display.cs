using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor
{
	internal class Display
	{
		public void showTemp(object? obj, TempArgs args)
		{
			Console.WriteLine($"Temperature is now set to: {args.Temprature}");

		}
	}
}
