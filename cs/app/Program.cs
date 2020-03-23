using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {

		// writing to console
		static void ConsoleMethods()
		{
			string name = "Phillip";
			int age = 26;
			string fruit = "apples";
			Console.WriteLine("Hello World!"); // writing text to console
			Console.WriteLine("{0} is {1} years old", name, age); // string formatting
			Console.WriteLine($"{name} would love to eat {fruit}"); // string formatting
		}

		// getting user input
		static void UserInput()
		{
			Console.WriteLine("What is your name?");
			string yourName = Console.ReadLine(); // getting input
			Console.WriteLine($"Your name is {yourName}!"); // using the input
		}

		// type conversion
		static void TypeConversion()
		{
			Console.WriteLine("Please enter a number");
			int num1 = int.Parse(Console.ReadLine()); // using int.Parse()
			Console.WriteLine("Please enter another number");
			int num2 = int.Parse(Console.ReadLine()); // using int.Parse()
			int sum = num1 + num2;
			Console.WriteLine($"The sum of your numbers is {sum}");
		}

		// explains how variables work
		static void Variables()
		{
			int num = 20; // intergers
			string name = "Phillip"; // strings
			float gpa = 12.2F; // floats
			double score = 9.22; // double
			char grade = 'A'; // char
			bool isMale = true; // boolean
			var phrase = "You are awesome!"; // var will assume your data type
			const double PI = 3.14; // const will make a variable unchangable
		}

		// basic arithmetic
		static void DoingMath()
		{
			int addition = 2 + 2; // adding
			int subtract = 10 - 5; // subtracting
			int multiply = 2 * 2; // multiplication
			int divide = 10 / 2; // division
			int modulus = 11 % 2; // get the remainder after divison
			addition++; // increment by 1
			addition--; // decrement by 1
			addition += subtract; // same as addition = addition + subtract
			addition -= subtract; // same as addition = addition - subtract	
		}

		// dealing with loops conditionals and general control flow
		static void Conditionals()
		{
			if (10 < 5) // if statement
			{
				// insert code here
			}
			else if (10 < 5) // else if statement
			{
				// insert code here
			}
			else // else statement
			{
				// insert code here
			}	
		}

		// function calls
		// Variables();
		// ConsoleMethods();
		// UserInput();
		// TypeConversion();
		// DoingMath();
		Conditionals();
        }
   }
}
