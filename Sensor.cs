using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor
{
	internal class Sensor
	{
		//Declare event
		public event EventHandler<TempArgs> SensorChanged;
		private int CurrentTemp { get; set; }
		public void TempChange(int newTemp)
		{
			CurrentTemp = newTemp;
			                  //Sensor
			SensorChanged.Invoke(this, new TempArgs(newTemp));
		}
	}
}
