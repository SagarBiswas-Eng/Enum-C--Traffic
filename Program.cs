using System;

// Defining Constants (Enum for Colors)
enum Colors
{
    Red,
    Green,
    Blue,
    Yellow
}

// Flags and Bitmasking (Enum for Permissions)
[Flags]
enum Permissions
{
    Read = 1,
    Write = 2,
    Execute = 4
}

// State Machine (Enum for Traffic Light States)
enum TrafficLightState
{
    RedLight,
    YellowLight,
    GreenLight
}

class Program
{
    // Function to convert a string to TrafficLightState enum
    static TrafficLightState StringToTrafficLightState(string str)
    {
        if (str == "RedLight")
        {
            return TrafficLightState.RedLight;
        }
        else if (str == "YellowLight")
        {
            return TrafficLightState.YellowLight;
        }
        else if (str == "GreenLight")
        {
            return TrafficLightState.GreenLight;
        }
        else
        {
            // Handle invalid input here
            Console.WriteLine("Invalid input. Defaulting to RedLight.");
            return TrafficLightState.RedLight;
        }
    }

    static void Main()
    {
        // Defining Constants Example
        Colors myColor = Colors.Green; // Using the Color enum constant

        // Flags and Bitmasking Example
        Permissions userPermissions = Permissions.Read | Permissions.Write;

        // State Machine Example
        Console.Write("Enter a traffic light state (RedLight, YellowLight, GreenLight): ");
        string userInput = Console.ReadLine();

        // Convert the user input to a TrafficLightState enum
        TrafficLightState trafficState = StringToTrafficLightState(userInput);

        // Custom Data Types Example
        DaysOfWeek today = DaysOfWeek.Wednesday;

        // Switch Statement Example (Using the State Machine Enum)
        switch (trafficState)
        {
            case TrafficLightState.RedLight:
                Console.WriteLine("Stop! The light is red.");
                break;
            case TrafficLightState.YellowLight:
                Console.WriteLine("Slow down. The light is yellow.");
                break;
            case TrafficLightState.GreenLight:
                Console.WriteLine("Go ahead. The light is green.");
                break;
        }

        // Output the selected color and permissions
        Console.WriteLine($"Selected color: {myColor}");
        Console.WriteLine($"User permissions: {userPermissions}");
        Console.WriteLine($"Today is: {today}");
    }
}

// Custom Data Types (Enum for Days of the Week)
enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}
