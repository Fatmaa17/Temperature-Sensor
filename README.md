# Temperature Sensor System

This project implements a temperature monitoring system using the **Observer Design Pattern**. The system consists of a sensor that tracks temperature changes and two observers: a display that shows the current temperature and an alarm that triggers a warning if the temperature exceeds a user-defined threshold.

## Features

1. **Sensor (Subject)**:
   - Allows the user to set the temperature.
   - Notifies observers when the temperature changes.

2. **Display (Observer)**:
   - Shows the current temperature when updated by the sensor.

3. **Alarm (Observer)**:
   - Alerts the user when the temperature exceeds a specified threshold.
   - Allows the user to set or update the alarm threshold.

## How to Use

1. Run the application.
2. Choose an option from the menu:
   - `1` to set the temperature.
   - `2` to update the alarm threshold.
   - `3` to exit the application.
3. Observe the system's responses based on the temperature and alarm settings.

## Technologies

- C#
- Object-Oriented Programming
- Observer Design Pattern

## Sample Output

```plaintext
Welcome to the temperature system
1. Set the temp
2. Set the Okay Alarm value
3. Exit

1
Okay okay! Enter the temperature value please(Note default alarm val is 20): 
15
Temperature is now set to: 15

1
Okay okay! Enter the temperature value please(Note default alarm val is 20): 
25
Temperature is now set to: 25
Take care, The temp value 25 is greater than 20

2
Okay okay! Enter the ALARM temperature value please: 
30

1
Okay okay! Enter the temperature value please(Note default alarm val is 20): 
35
Temperature is now set to: 35
Take care, The temp value 35 is greater than 30

3
'System closed'
