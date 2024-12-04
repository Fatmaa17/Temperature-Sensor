using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor
{
	internal class Alarm
	{
		//          Threshold
		public int AlarmValue { get; set; }
        public Alarm(int alarmDefault)
        {
            AlarmValue = alarmDefault;
        }
        public void setAlarm(int newAlarm)
		{
			AlarmValue = newAlarm;
		}
		public void fireAlarm(object? obj, TempArgs tempArgs)
		{
			if(tempArgs.Temprature > AlarmValue)
			{
                Console.WriteLine($"Take care, The temp value {tempArgs.Temprature} is greater than {AlarmValue}");
			}
		}
	}
}
