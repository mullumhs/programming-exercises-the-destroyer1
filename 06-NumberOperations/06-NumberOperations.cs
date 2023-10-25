using System;

/*
===============================================================================
PROJECT 06: NUMBER OPERATIONS
===============================================================================
Objective:
- Practice obtaining numerical input from the user and performing basic arithmetic operations.

Main Tasks:
1. Store user input as a floating point number for the variable 'y' as shown for 'x'.
2. Perform and output the result of multiplication using '*' with 'x' and 'y'.
3. Perform and output the result of subtraction using '-' with 'x' and 'y'.
4. Perform and output the result of division using '/' with 'x' and 'y'.
5. Wait for input before ending the program.

Questions:
1. What does "Convert.ToDouble" do?
2. What is a parameter? Give an example of where you have used one.
3. Why is the 'Console.ReadLine()' a parameter to Convert.ToDouble()?

Extension Tasks:
1. Modify the program to work with the 'double' type.
2. Research how to get the remainder of a division using the 'modulus operator'.

Example:
- Below is what the final program output might look like:

    Please enter a number for X:
    7
    Please enter a number for Y:
    3
    X plus Y = 10
    X times Y = 21
    X minus Y = 4
    X divided by Y = 2.333333

Additional Resources:
- Convert.ToDouble: https://www.tutorialspoint.com/convert-tosingle-method-in-chash
- Parameters: https://www.w3schools.com/cs/cs_method_parameters.php
- Arithmetic Operators: https://www.w3schools.com/cs/cs_operators_arithmetic.php
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_06_NumberOperations
    {
        static void Main(string[] args)
        {
            // How to input a number from the user and store it in a variable 'x'
            Console.WriteLine("Please enter a number for X:");
            double x = Convert.ToDouble(Console.ReadLine());
            
            // Your code goes below here
            Console.WriteLine("Please enter a number for y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{x} plus {y} = {x + y}");
            Console.WriteLine($"{x} times {y} = {x * y}");          
            Console.WriteLine($"{x} minus {y} = {x - y}");
            Console.WriteLine($"{x} divided by {y} = {x / y}");
            Console.ReadLine();

        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================
Feedback on your C# Programming Task:

Code:

Your code is well-structured and follows the task instructions accurately. You have successfully implemented the arithmetic operations and used the Convert.ToDouble() method correctly to obtain user input.
Code Commenting:

Your comments are clear and relevant, providing useful information about the code's functionality. However, there are no comments in the main body of your code. Adding comments to your code can make it easier for others (and yourself in the future) to understand what your code is doing.
Answers to Questions:

You didn't provide answers to the questions in your code. Remember to include these in your submission next time.
Extension Tasks:

You've successfully modified the program to work with the 'double' type as per the first extension task.
The second extension task is missing, which was to research and implement the modulus operator. Please ensure to complete all extension tasks in the future.
Suggestions for Improvement:

For the division operation, consider handling the case where 'y' might be zero. Division by zero is undefined and will result in a runtime error.
It would be good to add error handling to your code. For example, you could use a try-catch block to handle any potential exceptions that might occur when converting the user input to a double.
Keep up the good work and continue practicing to further improve your coding skills!


===============================================================================
*/
