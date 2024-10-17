using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Challenges
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my Coding Challenge program! There will be a variety of different functions you will have to choose from. Please pick one.");

        // Sum Functionality
        Console.WriteLine("Today we are going to use the number adder called SUM. Please put two numbers for us to add.\n");

        Console.WriteLine("Please input the first number:");
        var number1 = Console.ReadLine();
        int number1int = int.Parse(number1);

        Console.WriteLine("Awesome! Please input a second number:");
        var number2 = Console.ReadLine();
        int number2int = int.Parse(number2);

        int sumResult = Sum(number1int, number2int);
        Console.WriteLine($"The sum of the number {number1} and the number {number2} is equal to: {sumResult}");

        // Minutes to Seconds Functionality
        Console.WriteLine("Now let's convert minutes to seconds. Please enter the number of minutes:");
        var minutesInput = Console.ReadLine();
        int minutes = int.Parse(minutesInput);
        int seconds = MinutesToSeconds(minutes);
        Console.WriteLine($"{minutes} minutes is equal to {seconds} seconds.");


        // any number plus 1

        Console.WriteLine("Now let's add plus 1 to any number.");
        Console.WriteLine("Please input any number:");
        var numberInput = Console.ReadLine();
        if (int.TryParse(numberInput, out int number))
        {
            int result = PlusOne(number);
            Console.WriteLine($"The result is: {result}");
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }

        // Calcate voltage

        Console.WriteLine("Now let's Calculate Voltage Power");

        // Input voltage
        Console.WriteLine("Please input the voltage:");
        string voltageInput = Console.ReadLine();
        int voltage;
        if (!int.TryParse(voltageInput, out voltage))
        {
            Console.WriteLine("Invalid input for voltage. Please enter a valid integer.");
            return; // Exit the program if the input is invalid
        }

        // Input current
        Console.WriteLine("Please input the current:");
        string currentInput = Console.ReadLine();
        int current;
        if (!int.TryParse(currentInput, out current))
        {
            Console.WriteLine("Invalid input for current. Please enter a valid integer.");
            return; // Exit the program if the input is invalid
        }

        // Calculate power
        int power = voltage * current;

        // Output the result
        Console.WriteLine($"The calculated power is: {power} Watts");

        //Calcation Years to days

        Console.WriteLine("We can calculate age in years and return them into age of days");
        Console.WriteLine("Please input an age in years");
        string yearsInput = Console.ReadLine();
        int year;

        if (!int.TryParse(yearsInput, out year))
        {
            Console.WriteLine("Invalid input for age. Please enter a valid integer.");
            return; // Exit the program if the input is invalid
        }

        int ageInDays = year * 365; // Approximation, ignoring leap years
        Console.WriteLine($"Your age in days is approximately: {ageInDays}");

        {
            //base of a triangle
            Console.Write("Now lets find the base of a triangle");
            Console.Write("Enter the base of the triangle: ");
            double baseValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the triangle: ");
            double heightValue = Convert.ToDouble(Console.ReadLine());

            double area = TriangleArea(baseValue, heightValue);

            Console.WriteLine($"The area of the triangle with base {baseValue} and height {heightValue} is {area}.");
        }

        {
            //less than or equal to zero
            int checkNumber = GetIntegerInput("Now let's check if a number is less than or equal to zero. Please input a number:");
            bool isLessThanOrEqualToZero = IsLessThanOrEqualToZero(checkNumber);
            Console.WriteLine($"{checkNumber} is less than or equal to zero: {isLessThanOrEqualToZero}");
        }





    }


       




    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int MinutesToSeconds(int minutes)
    {
        // Convert minutes to seconds
        return minutes * 60;
    }

    static int PlusOne(int number)
    {
        return number + 1;
    }

    static double TriangleArea(double baseValue, double heightValue)
    {
        return 0.5 * baseValue * heightValue;
    }

    static int GetIntegerInput(string message)
    {
        Console.WriteLine(message);
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static double GetDoubleInput(string message)
    {
        Console.WriteLine(message);
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double result))
            {
                return result;
            }
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static bool IsLessThanOrEqualToZero(int number)
    {
        return number <= 0;
    }
}
