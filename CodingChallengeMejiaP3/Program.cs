using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;


class Challenges
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to my Coding Challenge program! Please choose an option:");
            Console.WriteLine("1. Sum two numbers");
            Console.WriteLine("2. Convert minutes to seconds");
            Console.WriteLine("3. Add one to a number");
            Console.WriteLine("4. Calculate voltage power");
            Console.WriteLine("5. Calculate age in days");
            Console.WriteLine("6. Find the area of a triangle");
            Console.WriteLine("7. Check if a number is less than or equal to zero");
            Console.WriteLine("8. Check if the sum of two numbers is less than 100");
            Console.WriteLine("9. Check if two numbers are equal");
            Console.WriteLine("10. Give me something");
            Console.WriteLine("0. Exit");
            Console.Write("Please enter your choice: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    SumNumbers();
                    break;
                case "2":
                    ConvertMinutesToSeconds();
                    break;
                case "3":
                    AddOne();
                    break;
                case "4":
                    CalculateVoltagePower();
                    break;
                case "5":
                    CalculateAgeInDays();
                    break;
                case "6":
                    CalculateTriangleArea();
                    break;
                case "7":
                    CheckLessThanOrEqualToZero();
                    break;
                case "8":
                    CheckSumLessThan100();
                    break;
                case "9":
                    CheckIfEqual();
                    break;
                case "10":
                    GiveMeSomething();
                    break;
                case "0":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine();
        }
    }

    public static void GiveMeSomething()
    {
        Console.WriteLine("Please enter a string:");
        string input = Console.ReadLine();
        string result = "something " + input;
        Console.WriteLine(result);
    }

    public static void SumNumbers()
    {
        Console.WriteLine("Please input the first number:");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input a second number:");
        int number2 = int.Parse(Console.ReadLine());

        int sumResult = Sum(number1, number2);
        Console.WriteLine($"The sum of {number1} and {number2} is: {sumResult}");
    }

    public static void ConvertMinutesToSeconds()
    {
        Console.WriteLine("Please enter the number of minutes:");
        int minutes = int.Parse(Console.ReadLine());
        int seconds = MinutesToSeconds(minutes);
        Console.WriteLine($"{minutes} minutes is equal to {seconds} seconds.");
    }

    public static void AddOne()
    {
        Console.WriteLine("Please input any number:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            int result = PlusOne(number);
            Console.WriteLine($"The result is: {result}");
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }

    public static void CalculateVoltagePower()
    {
        Console.WriteLine("Please input the voltage:");
        int voltage = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input the current:");
        int current = int.Parse(Console.ReadLine());

        int power = voltage * current;
        Console.WriteLine($"The calculated power is: {power} Watts");
    }

    public static void CalculateAgeInDays()
    {
        Console.WriteLine("Please input your age in years:");
        int year = int.Parse(Console.ReadLine());
        int ageInDays = year * 365; // Approximation, ignoring leap years
        Console.WriteLine($"Your age in days is approximately: {ageInDays}");
    }

    public static void CalculateTriangleArea()
    {
        Console.Write("Enter the base of the triangle: ");
        double baseValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double heightValue = Convert.ToDouble(Console.ReadLine());

        double area = TriangleArea(baseValue, heightValue);
        Console.WriteLine($"The area of the triangle with base {baseValue} and height {heightValue} is {area}.");
    }

    public static void CheckLessThanOrEqualToZero()
    {
        Console.Write("Please input a number: ");
        int checkNumber = int.Parse(Console.ReadLine());
        bool isLessThanOrEqualToZero = IsLessThanOrEqualToZero(checkNumber);
        Console.WriteLine($"{checkNumber} is less than or equal to zero: {isLessThanOrEqualToZero}");
    }

    public static void CheckSumLessThan100()
    {
        Console.WriteLine("Please input the first number:");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input a second number:");
        int number2 = int.Parse(Console.ReadLine());

        bool result = IsSumLessThan100(number1, number2);
        Console.WriteLine($"The sum of {number1} and {number2} is less than 100: {result}");
    }

    public static void CheckIfEqual()
    {
        Console.WriteLine("Please input the first number:");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input a second number:");
        int number2 = int.Parse(Console.ReadLine());

        bool isEqual = AreEqual(number1, number2);
        Console.WriteLine($"{number1} and {number2} are equal: {isEqual}");
    }

    public static int Sum(int number1, int number2) => number1 + number2;
    public static int MinutesToSeconds(int minutes) => minutes * 60;
    static int PlusOne(int number) => number + 1;
    static double TriangleArea(double baseValue, double heightValue) => 0.5 * baseValue * heightValue;
    static bool IsLessThanOrEqualToZero(int number) => number <= 0;
    static bool IsSumLessThan100(int num1, int num2) => (num1 + num2) < 100;
    static bool AreEqual(int num1, int num2) => num1 == num2;
}