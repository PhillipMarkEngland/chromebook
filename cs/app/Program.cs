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
			// if, else if, and else statements
			if (10 < 5)
			{
				if (5 < 4)
				{
				}
			}
			else if (10 < 5)
			{
			}
			else
			{
			}
		}

		// switch statements
		static void SwitchStatement()
		{
			int num = 3;
			switch (num)
			{
				case 1:
					Console.WriteLine("One");
					break;
				case 2:
					Console.WriteLine("Two");
					break;
				case 3:
					Console.WriteLine("Three");
					break;
				default:
					Console.WriteLine("This will run if no other cases do");
					break;
			}	
		}

		// while loop
		static void WhileLoop()
		{
			int num = 0;
			while (num <= 6)
			{
				Console.WriteLine(num);
				num++;
			}
		}

		// for loop
		static void ForLoop()
		{
			// ( initalize counter; condition to check; increment)
			for (int x = 0; x <= 20; x++)
			{
				Console.WriteLine(x);
			}
		}

		// do while loop
		static void DoWhileLoop()
		{
			int num = 0;
			do
			{	
				// This condition will always run
				Console.WriteLine(num);
			} while (num == 20);
		}

		// break and continue statements
		static void BreakAndContinue()
		{
			for (int x = 0; x < 20; x++)
			{
				if (x == 5)
				{	
					Console.WriteLine("Skipping 5");
					continue; // will skip the number 5 in the loop
				}
				if (x == 10)
				{	
					Console.WriteLine("x is equal to 10 so we are ending the loop");
					break; // terminating the loop
				}
				Console.WriteLine(x);
			}
		}

		// logical operators
		static void LogicalOperators()
		{
			// and operator &&
			// or operator ||
			// not operator !
			int x = 20;
			int y = 30;
			if (x == 20 && y == 30)
			{
				Console.WriteLine("Both true");
			}
			if (x != 20 || y != 20)
			{
				Console.WriteLine("One true");
			}
			if (!(x == 10))
			{
				Console.WriteLine("Displays opposite boolean");
			}
		}

		// how to use the conditional operators -> ?
		static void ConditionalOperator()
		{
			int age = 14;
			string message;
			message = (age >= 18) ? "You are not a minor" : "You are a minor";
			Console.WriteLine(message);
		}

		// how to use methods
		static void UsingMethods()
		{
			// <return type> <method name> (<para type> <para name>)
			// use void for the return type if a function doesnt return a value
			int SquareNumber(int number)
			{
				int result = number * number;
				return result;
			}	
			// printing the reuturn value from a function
			Console.WriteLine(SquareNumber(10));


			//passing the return value of a function into another function
			int Double(int number)
			{	
				int result = number * 2;
				return result;
			}

			int SubtractOne(int number)
			{
				int result = --number;
				return result;
			}

			Console.WriteLine(SubtractOne(Double(10))); // returns 19;

			// default parameter values
			static int AddTwo(int number, int y=2)
			{
				int result = number + y;
				return result;
			}

			Console.WriteLine(AddTwo(2)); // returns 4

			// named arguments allow us to rearrange the order of parameters
			static int GetArea(int height, int width)
			{
				int result = height * width;
				return result;
			}

			// when calling GetArea, we can mix up the original order of parameters
			Console.WriteLine(GetArea(width: 5, height: 2));

		}

		// function calls
		// Variables();
		// ConsoleMethods();
		// UserInput();
		// TypeConversion();
		// DoingMath();
		// Conditionals();
		// SwitchStatement();
		// WhileLoop();
		// ForLoop();
		// DoWhileLoop();
		// BreakAndContinue();
		// LogicalOperators();
		// ConditionalOperator();
		UsingMethods();
        }
   }
}
