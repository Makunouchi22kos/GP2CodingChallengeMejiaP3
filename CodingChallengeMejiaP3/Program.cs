using System;

class Challenges
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to my Coding Challenge program! Please choose an option:");
            Console.WriteLine("1. Sum two numbers");
            Console.WriteLine("2. Convert minutes to seconds");
            Console.WriteLine("3. Convert hours to seconds");
            Console.WriteLine("4. Add one to a number");
            Console.WriteLine("5. Calculate voltage power");
            Console.WriteLine("6. Calculate age in days");
            Console.WriteLine("7. Find the area of a triangle");
            Console.WriteLine("8. Check if a number is less than or equal to zero");
            Console.WriteLine("9. Check if the sum of two numbers is less than 100");
            Console.WriteLine("10. Check if two numbers are equal");
            Console.WriteLine("11. Reverse a boolean value");
            Console.WriteLine("12. Give me something");
            Console.WriteLine("13. Sum of angles of a polygon");
            Console.WriteLine("14. Name with 'Edabit'");
            Console.WriteLine("15. Use logical AND (&&) operator");
            Console.WriteLine("16. Calculate basketball points");
            Console.WriteLine("17. Find the perimeter of a rectangle");
            Console.WriteLine("18. Greet by name");
            Console.WriteLine("19. Calculate total number of legs of animals");
            Console.WriteLine("20. Calculate football points");
            Console.WriteLine("21. Month Name Challenge");
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
                    ConvertHoursToSeconds();
                    break;
                case "4":
                    AddOne();
                    break;
                case "5":
                    CalculateVoltagePower();
                    break;
                case "6":
                    CalculateAgeInDays();
                    break;
                case "7":
                    CalculateTriangleArea();
                    break;
                case "8":
                    CheckLessThanOrEqualToZero();
                    break;
                case "9":
                    CheckSumLessThan100();
                    break;
                case "10":
                    CheckIfEqual();
                    break;
                case "11":
                    ReverseBooleanValue();
                    break;
                case "12":
                    GiveMeSomething();
                    break;
                case "13":
                    SumPolygon();
                    break;
                case "14":
                    NameString();
                    break;
                case "15":
                    LogicalAndOperator();
                    break;
                case "16":
                    CalculateBasketballPoints();
                    break;
                case "17":
                    FindPerimeter();
                    break;
                case "18":
                    GreetByName();  // Call the new greeting function
                    break;
                case "19":
                    CalculateAnimalLegs();  // New functionality for calculating total legs
                    break;
                case "20":
                    CalculateFootballPoints();  // New functionality for football points
                    break;
                case "21":
                    MonthNameChallenge();  // Call the MonthName challenge function
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


    public static void MonthNameChallenge()
    {
        Console.WriteLine("Please enter a number between 1 and 12 to get the corresponding month name:");
        if (int.TryParse(Console.ReadLine(), out int monthNumber))
        {
            if (monthNumber >= 1 && monthNumber <= 12)
            {
                string monthName = MonthName(monthNumber);
                Console.WriteLine($"MonthName({monthNumber}) is: {monthName}");
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 12.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }

    // Function to return the month name
    public static string MonthName(int number)
    {
        string[] months =
        {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };
        return months[number - 1];
    }

    public static void CalculateFootballPoints()
    {
        Console.WriteLine("Please enter the number of wins:");
        if (int.TryParse(Console.ReadLine(), out int wins))
        {
            Console.WriteLine("Please enter the number of draws:");
            if (int.TryParse(Console.ReadLine(), out int draws))
            {
                Console.WriteLine("Please enter the number of losses:");
                if (int.TryParse(Console.ReadLine(), out int losses))
                {
                    int totalPoints = FootballPoints(wins, draws, losses);
                    Console.WriteLine($"({wins}, {draws}, {losses}) -->2 {totalPoints}");
                }
                else
                {
                    Console.WriteLine("Please enter a valid number of losses.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number of draws.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number of wins.");
        }
    }

    // Function to calculate football points
    public static int FootballPoints(int wins, int draws, int losses)
    {
        return (wins * 3) + (draws * 1) + (losses * 0);  // Calculate points
    }

    // Function to greet by name
    public static void GreetByName()
    {
        Console.WriteLine("Please enter a name:");
        string name = Console.ReadLine();
        string greeting = HelloName(name);
        Console.WriteLine(greeting);
    }

    public static void CalculateAnimalLegs()
    {
        Console.WriteLine("Please enter the number of chickens:");
        if (int.TryParse(Console.ReadLine(), out int chickens))
        {
            Console.WriteLine("Please enter the number of cows:");
            if (int.TryParse(Console.ReadLine(), out int cows))
            {
                Console.WriteLine("Please enter the number of pigs:");
                if (int.TryParse(Console.ReadLine(), out int pigs))
                {
                    int totalLegs = (chickens * 2) + (cows * 4) + (pigs * 4);
                    Console.WriteLine($"The total number of legs is: {totalLegs} <-- ({chickens}, {cows}, {pigs}) ");
                }
                else
                {
                    Console.WriteLine("Please enter a valid number for pigs.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number for cows.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number for chickens.");
        }
    }

    // Function that takes a name and returns a greeting string
    public static string HelloName(string name)
    {
        return $"Hello {name}!";
    }

    // Function to calculate basketball points
    public static void CalculateBasketballPoints()
    {
        Console.WriteLine("Please enter the number of 2-pointers scored:");
        if (int.TryParse(Console.ReadLine(), out int twoPointers))
        {
            Console.WriteLine("Please enter the number of 3-pointers scored:");
            if (int.TryParse(Console.ReadLine(), out int threePointers))
            {
                int totalPoints = CalculatePoints(twoPointers, threePointers);
                Console.WriteLine($"({twoPointers}, {threePointers}) --> is {totalPoints} points.");
            }
            else
            {
                Console.WriteLine("Please enter a valid number of 3-pointers.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number of 2-pointers.");
        }
    }

    // Function to calculate the total points based on 2-pointers and 3-pointers
    public static int CalculatePoints(int twoPointers, int threePointers)
    {
        return (twoPointers * 2) + (threePointers * 3);
    }

    // Function to simulate the behavior of the && operator
    public static void LogicalAndOperator()
    {
        Console.WriteLine("Please enter the first boolean value (true/false):");
        string input1 = Console.ReadLine().ToLower();
        Console.WriteLine("Please enter the second boolean value (true/false):");
        string input2 = Console.ReadLine().ToLower();

        bool a, b;
        if (bool.TryParse(input1, out a) && bool.TryParse(input2, out b))
        {
            bool result = And(a, b);
            // Output the result in the exact desired format
            Console.WriteLine($"And {input1}, {input2} --> {result.ToString().ToLower()}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'true' or 'false' for both values.");
        }
    }

    // And function simulating the && operator
    public static bool And(bool a, bool b)
    {
        return a && b; // Returns true only if both a and b are true
    }

    public static void SumNumbers()
    {
        Console.WriteLine("Please input the first number:");
        if (int.TryParse(Console.ReadLine(), out int number1))
        {
            Console.WriteLine("Please input a second number:");
            if (int.TryParse(Console.ReadLine(), out int number2))
            {
                int sumResult = Sum(number1, number2);
                Console.WriteLine($"The sum of {number1} and {number2} is: {sumResult}");
            }
            else
            {
                Console.WriteLine("Please enter a valid second number.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid first number.");
        }
    }

    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static void ConvertMinutesToSeconds()
    {
        Console.WriteLine("Please enter the number of minutes:");
        if (int.TryParse(Console.ReadLine(), out int minutes))
        {
            int seconds = minutes * 60;
            Console.WriteLine($"{minutes} minutes is equal to {seconds} seconds.");
        }
        else
        {
            Console.WriteLine("Please enter a valid number of minutes.");
        }
    }

    public static void ConvertHoursToSeconds()
    {
        Console.WriteLine("Please enter the number of hours:");
        if (int.TryParse(Console.ReadLine(), out int hours))
        {
            int seconds = hours * 3600;
            Console.WriteLine($"{hours} hours is equal to {seconds} seconds.");
        }
        else
        {
            Console.WriteLine("Please enter a valid number of hours.");
        }
    }

    public static void AddOne()
    {
        Console.WriteLine("Please enter a number:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            int result = number + 1;
            Console.WriteLine($"The result of adding one to {number} is: {result}");
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }

    public static void CalculateVoltagePower()
    {
        Console.WriteLine("Please enter the voltage (V):");
        if (double.TryParse(Console.ReadLine(), out double voltage))
        {
            Console.WriteLine("Please enter the current (I):");
            if (double.TryParse(Console.ReadLine(), out double current))
            {
                double power = voltage * current;
                Console.WriteLine($"The power is: {power} watts.");
            }
            else
            {
                Console.WriteLine("Please enter a valid current value.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid voltage value.");
        }
    }

    public static void CalculateAgeInDays()
    {
        Console.WriteLine("Please enter your age in years:");
        if (int.TryParse(Console.ReadLine(), out int ageInYears))
        {
            int ageInDays = ageInYears * 365;
            Console.WriteLine($"You are approximately {ageInDays} days old.");
        }
        else
        {
            Console.WriteLine("Please enter a valid age.");
        }
    }

    public static void CalculateTriangleArea()
    {
        Console.WriteLine("Please enter the base of the triangle:");
        if (double.TryParse(Console.ReadLine(), out double baseLength))
        {
            Console.WriteLine("Please enter the height of the triangle:");
            if (double.TryParse(Console.ReadLine(), out double height))
            {
                double area = 0.5 * baseLength * height;
                Console.WriteLine($"The area of the triangle is: {area} square units.");
            }
            else
            {
                Console.WriteLine("Please enter a valid height.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid base length.");
        }
    }

    public static void CheckLessThanOrEqualToZero()
    {
        Console.WriteLine("Please enter a number:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number <= 0)
                Console.WriteLine($"{number} is less than or equal to zero.");
            else
                Console.WriteLine($"{number} is greater than zero.");
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }

    public static void CheckSumLessThan100()
    {
        Console.WriteLine("Please enter the first number:");
        if (int.TryParse(Console.ReadLine(), out int number1))
        {
            Console.WriteLine("Please enter the second number:");
            if (int.TryParse(Console.ReadLine(), out int number2))
            {
                int sum = number1 + number2;
                if (sum < 100)
                    Console.WriteLine("The sum is less than 100.");
                else
                    Console.WriteLine("The sum is not less than 100.");
            }
            else
            {
                Console.WriteLine("Please enter a valid second number.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid first number.");
        }
    }

    public static void CheckIfEqual()
    {
        Console.WriteLine("Please enter the first number:");
        if (int.TryParse(Console.ReadLine(), out int number1))
        {
            Console.WriteLine("Please enter the second number:");
            if (int.TryParse(Console.ReadLine(), out int number2))
            {
                if (number1 == number2)
                    Console.WriteLine("The numbers are equal.");
                else
                    Console.WriteLine("The numbers are not equal.");
            }
            else
            {
                Console.WriteLine("Please enter a valid second number.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid first number.");
        }
    }

    public static void ReverseBooleanValue()
    {
        Console.WriteLine("Please enter a boolean value (true/false):");
        string input = Console.ReadLine().ToLower();
        if (bool.TryParse(input, out bool value))
        {
            bool reversedValue = !value;
            Console.WriteLine($"The reversed value is: {reversedValue}");
        }
        else
        {
            Console.WriteLine("Please enter a valid boolean value.");
        }
    }

    public static void GiveMeSomething()
    {
        Console.WriteLine("Please enter something:");
        string input = Console.ReadLine();
        Console.WriteLine($"You entered: {input}");
    }

    public static void SumPolygon()
    {
        Console.WriteLine("Please enter the number of sides of the polygon:");
        if (int.TryParse(Console.ReadLine(), out int sides))
        {
            int sumOfAngles = (sides - 2) * 180;
            Console.WriteLine($"The sum of the interior angles of a polygon with {sides} sides is: {sumOfAngles} degrees.");
        }
        else
        {
            Console.WriteLine("Please enter a valid number of sides.");
        }
    }

    public static void NameString()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine($"Your name is: {name}");
    }

    public static void FindPerimeter()
    {
        Console.WriteLine("Enter the length of the rectangle:");
        if (double.TryParse(Console.ReadLine(), out double length))
        {
            Console.WriteLine("Enter the width of the rectangle:");
            if (double.TryParse(Console.ReadLine(), out double width))
            {
                double perimeter = 2 * (length + width);
                Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");
            }
            else
            {
                Console.WriteLine("Please enter a valid width.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid length.");
        }
    }
}
