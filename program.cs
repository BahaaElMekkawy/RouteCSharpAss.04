using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number*/
            Console.WriteLine("Please Enter A Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Number; ++i)
            {
                Console.WriteLine(i);
            }
            /**************************************************************************************************************************/
            /*2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.*/

            Console.WriteLine("Please Enter A Number");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{Number1} * {i} = {Number1 * i}");
            }
            /**************************************************************************************************************************/
            /*3- Write a program that allows to user to insert number then print all even numbers between 1 to this number*/

            Console.WriteLine("Please Enter A Number");
            int Number2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= Number2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            /**************************************************************************************************************************/
            /*4- Write a program that takes two integers then prints the power.*/

            Console.WriteLine("Please Enter A Number");
            int Number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter The Power");
            int Pow = Convert.ToInt32(Console.ReadLine());
            int Result = Number3;
            for (int i = 1; i < Pow; ++i)
            {
                Result *= Number3;
            }
            //Console.WriteLine(Result);
            /**************************************************************************************************************************/
            /*5- Write a program to enter marks of five subjects and calculate total, average and percentage.*/

            int[] marks = new int[5];
            int total = 0;
            double average;
            double percentage;

            Console.WriteLine("Enter  5 Marks ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter Mark {i + 1} -->  ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                total += marks[i];
            }

            average = total / 5.0;

            //assume each mark is 100
            percentage = (total / 500.0) * 100;

            Console.WriteLine($"Total : {total}");
            Console.WriteLine($"Average : {average}");
            Console.WriteLine($"Percentage: {percentage}");

            /**************************************************************************************************************************/
            /*6- Write a program to input the month number and print the number of days in that month.*/

            Console.WriteLine("Please Enter The Month Number");
            int Month = Convert.ToInt32(Console.ReadLine());
            switch (Month)
            {
                case 1:
                    Console.WriteLine("January has 31 days.");
                    break;
                case 2:
                    Console.WriteLine("February has 28 or 29 days.");
                    break;
                case 3:
                    Console.WriteLine("March has 31 days.");
                    break;
                case 4:
                    Console.WriteLine("April has 30 days.");
                    break;
                case 5:
                    Console.WriteLine("May has 31 days.");
                    break;
                case 6:
                    Console.WriteLine("June has 30 days.");
                    break;
                case 7:
                    Console.WriteLine("July has 31 days.");
                    break;
                case 8:
                    Console.WriteLine("August has 31 days.");
                    break;
                case 9:
                    Console.WriteLine("September has 30 days.");
                    break;
                case 10:
                    Console.WriteLine("October has 31 days.");
                    break;
                case 11:
                    Console.WriteLine("November has 30 days.");
                    break;
                case 12:
                    Console.WriteLine("December has 31 days.");
                    break;
                default:
                    Console.WriteLine("Invalid month number! Please enter a number between 1 and 12.");
                    break;

                    /**************************************************************************************************************************/
                    /*7- Write a program to create a Simple Calculator.*/

                    while (true)
            {
                Console.WriteLine("Please Enter First Number");
                int FNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Second Number");
                int SNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Operation '+' '-' '*' '/'");
                char OP = Convert.ToChar(Console.ReadLine());

                switch (OP)
                {
                    case '+':
                        Console.WriteLine($"Result = {FNumber + SNumber}");
                        break;
                    case '*':
                        Console.WriteLine($"Result = {FNumber * SNumber}");
                        break;
                    case '/':
                        Console.WriteLine($"Result = {(double)FNumber / (double)SNumber}");
                        break;
                    case '-':
                        Console.WriteLine($"Result = {FNumber - SNumber}");
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }

            }

            /**************************************************************************************************************************/
            ///*8- Write a program to allow the user to enter int and print the REVERSED of it.*/

            Console.WriteLine("Please Enter a Number to Revese it");
            int Num = Convert.ToInt32(Console.ReadLine());
            int Reversed = 0;
            while (Num != 0)
            {
                int lastdigit = Num % 10;
                Reversed = Reversed * 10 + lastdigit;
                Num = Num / 10;
            }
            Console.WriteLine(Reversed);


            /**************************************************************************************************************************/
            /*9- Write a program in C# Sharp to find prime numbers within a range of numbers.*/

            Console.Write("Enter First Number: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            for (int i = Num1; i < Num2; i++)
            {
                bool isPrime = true;
                if (i == 1 || i == 2)
                    isPrime = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine($"{i} is a prime number");
                }

            }

            /**************************************************************************************************************************/
            /*10- . Write a program in C# Sharp to convert a decimal number into binary without using an array.*/


        }
    }
}





