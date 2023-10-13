using System;

/*
===============================================================================
PROJECT 02: VARIABLES
===============================================================================
Objective:
- Understand and practice declaring variables and manipulating string data.

Main Tasks:
1. Create a string variable and assign it a value.
2. Output a message that contains this variable.
3. Make the program wait for input.

Questions:
1. What is a variable? a variable is something that can change
2. What is a string? a string is when you set aside memory and give it a value

Extension Tasks:
1. Try creating two string variables and using them in the same message.
2. Use Google to work out how to change a variable to uppercase or lowercase before outputting it.

Additional Resources:
- Variables: https://www.tutorialspoint.com/csharp/csharp_variables.htm
- Data Types: https://www.tutorialspoint.com/csharp/csharp_data_types.htm
- String Manipulation: https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-6.0
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_02_Variables
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            string name = "linc";
            Console.WriteLine("Hello + name");
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

Your string variable declaration is correct. Good job!
However, when you're outputting the variable in Console.WriteLine(), you need to remove the quotes around name for it to be recognized as a variable. The correct way would be Console.WriteLine("Hello " + name);.
Code Commenting:

Your code is well-commented, and it's easy to understand what the task is.
Answers to Questions:

Your explanation of a variable is correct but could be more detailed. A variable is a named space in the memory where a programmer can store data and later retrieve the data using the variable name.
Your answer to what a string is partially correct. While it is true that a string involves setting aside memory, a more accurate definition would be: A string is a sequence of characters.
Extension Tasks:

It seems you haven't attempted the extension tasks. When you do, remember to create two string variables and use them in the same message for the first task.
For the second task, research how to change a string to uppercase or lowercase in C#. The ToUpper() and ToLower() methods should be helpful.
Overall, you're on the right track. Keep practicing and don't forget to attempt the extension tasks for more practice. Keep it up!


===============================================================================
*/
