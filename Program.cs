namespace TemperatureSensor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Sensor (Subject) => To adjust temp (temp as input) -------> Raise an event for temp change
			//Display the input temp ------> Observer
			//Alarm if up too much , down as well ------> Observer

			Sensor sensor = new Sensor();
			Display display = new Display();
			Alarm alarm = new Alarm(20);
			//Subscribtion
			sensor.SensorChanged += display.showTemp;
			sensor.SensorChanged += alarm.fireAlarm;
			Console.WriteLine("Welcome to the temperature system");
			while (true)
			{
				Console.WriteLine("1. Set the temp\n" +
					"2. Set the Okay Alarm value\n" +
					"3. Exit");

				var option = Console.ReadLine();
				switch (option)
				{
					case "1":
						Console.WriteLine("Okay okay! Enter the temperature value please(Note default alarm val is 20): ");
						int temp = Convert.ToInt32(Console.ReadLine());
						sensor.TempChange(temp);
						break;
					case "2":
						Console.WriteLine("Okay okay! Enter the ALARM temperature value please: ");
						var alarmVal = Convert.ToInt32(Console.ReadLine());
						alarm.setAlarm(alarmVal);
						break;
					case "3":
						Environment.Exit(0);
						break;
					default:
						Console.WriteLine("Wrong input, please enter correct value!");
						break;
				}
			}
		}
	}
}
