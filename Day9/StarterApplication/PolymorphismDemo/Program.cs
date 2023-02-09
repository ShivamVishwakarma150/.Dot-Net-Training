using System;

namespace PolymorphismDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperCalculator sc =new SuperCalculator();
            Console.WriteLine(sc.Multiply(10, 20));

            DeluxCalculator dc=new DeluxCalculator();
            Console.WriteLine(dc.Multiply(10,30));


        }
    }
}
