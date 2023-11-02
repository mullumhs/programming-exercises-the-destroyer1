using System;

/*
===============================================================================
PROJECT 12: BETTER AREA CALCULATOR
===============================================================================
Objective:
- Learn how to refactor code into more manageable chunks using methods, improving readability and reusability of the code.

Main Tasks:
1. Copy and paste your program from the previous lesson into this one.
2. Write methods for each of the main functions of the program. E.g. ShowMenu, CalculateRectangle, CalculateTriangle, etc.
3. Move the corresponding code into each method.
4. Call the methods from the Main method.

Questions:
1. What is the purpose of splitting the code into smaller chunks (methods)?
2. Why is it important to give a warning message to the user in the else statement?

Extension Tasks:
1. Add a trapezium option to the program. It should also be a separate method.

Example:
- Below is an example of the program's output:

    Choose an Option:
    1. Area of Circle
    2. Area of Rectangle
    3. Area of Triangle

    2

    Enter Width: 3
    Enter Height: 4

    The area of the rectangle is 12

    "Press any key to exit...

Additional Resources:
- Methods: https://www.w3schools.com/cs/cs_methods.php
===============================================================================
*/
namespace ProgrammingExercisesIST
{
    class Project_11_AreaCalculator
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            ShowMenu();

            string choice = Console.ReadLine();

            if (choice == "2")
            {
                CalculateRectangle();
            }


            else if (choice == "1")
            {
                CalculateCircle();
            }
            else if (choice == "3")
            {
                CalculateTriangle();
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("Choose an Option:");
            Console.WriteLine("1. Area of Circle");
            Console.WriteLine("2. Area of Rectangle");
            Console.WriteLine("3. Area of Triangle");
            Console.WriteLine();
        }

        static void CalculateCircle()
        {
            Console.WriteLine("Enter Radius: ");
            double Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double circle = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine($"The area of the circle is {circle}");
            Console.ReadLine();
        }

        static void CalculateRectangle()
        {
            Console.WriteLine("Enter Height: ");
            double Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Width: ");
            double Width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"The area of the rectangle is {Height * Width} ");

            Console.ReadLine();

        }

        static void CalculateTriangle()
        {
            Console.WriteLine("Enter Height: ");
            double Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Base: ");
            double Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"The area of the triangle is {(Height * Base) / 2} ");

            Console.ReadLine();
        }

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/