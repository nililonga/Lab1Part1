using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{//Declare integer
			int numberA, numberB;

			//have user enter first number
			Console.WriteLine("enter a number");
			string input1 = Console.ReadLine();

			//have user enter second number
			Console.WriteLine("enter a second number");
			string input2 = Console.ReadLine();

			//check to see if lengths are the same
			if (input1.Length == input2.Length)
			{//convert string to integer
				numberA = int.Parse(input1);
				numberB = int.Parse(input2);



				//check first hundereds places
				int hundreds = input1[0] + input2[0];
				//check second tens place
				int tens = input1[1] + input2[1];
				//check third ones place
				int ones = input1[2] + input2[2];
				//see if they are equal
				if ((hundreds == tens) && (tens == ones))
				{
					Console.WriteLine("True");
				}
				else
				{//if they are not equal provide false statement
					Console.WriteLine("False");
				}
				Console.ReadLine();
			}
		}
	}
}
