using System;

/*
===============================================================================
PROJECT 01: HELLO WORLD
===============================================================================
Objective:
- Familiarize with basic console output and input operations in C#.

Main Tasks:
1. Output 'Hello World!' to the console screen using 'Console.WriteLine();'.
2. Make the program wait for input using 'Console.ReadLine();'.

Questions:
1. What is the difference between input and output?
input is what you put in and output is what the code sh`ows
Extension Tasks:
1. Output another message / pause after the ReadLine.
2. Research online how to change the colour and/or make the console beep.

Additional Resources:
- Microsoft Docs: Console.WriteLine Method: https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline
- Microsoft Docs: Console.ReadLine Method: https://docs.microsoft.com/en-us/dotnet/api/system.console.readline
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_01_HelloWorld
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            Console.WriteLine("hello World");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("goodbye");
            Console.ReadLine();
            Console.Beep(1000, 5000);
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

Your code for the main tasks is correct. You have successfully used Console.WriteLine(); to output 'Hello World' and Console.ReadLine(); to make the program wait for user input.

For the extension tasks, you have correctly implemented the Console.Beep(); method to make the console beep. Good job on that!

However, you have declared the ConsoleColor foreground variable but didn't use it to change the console color. You need to use Console.ForegroundColor = foreground; to actually change the console color.

Code Commenting:

Your code comments are clear and concise, providing a good understanding of what each part of your code is doing.
Answers to Questions:

Your answer to the question is correct. Input is the data that you provide to the program, and output is what the program returns after processing the input.
Extension Tasks:

You have successfully completed the first extension task by outputting another message and pausing after the ReadLine.

For the second extension task, you have correctly used the Console.Beep(); method to make the console beep, but you need to use the Console.ForegroundColor property to change the console color.

Overall, you are doing a great job! Keep practicing and experimenting with different features of C#.

===============================================================================
*/