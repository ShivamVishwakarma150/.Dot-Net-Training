using System;

namespace ConditionalStatementDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

            Console.WriteLine("Enter the month number");
            int month = int.Parse(Console.ReadLine());

            switch(month)
            {
                case 1:
                    Console.WriteLine("Jan");
                    break;
                case 2:
                    Console.WriteLine("Feb");
                    break;
                case 3:
                    Console.WriteLine("Mar");
                    break;
                default:
                    Console.WriteLine("Not a month");
                    break;
                }
        }
    }
}
