using System;
using System.Collections.Generic;

namespace DreamWedding_Proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lt= new List<string>();
            DreamWedding dw = new DreamWedding();
            Console.WriteLine("Welcome to Conto wedding Services......");
            Console.WriteLine("Enter the wedding package you wish");
            String package = Console.ReadLine();
            if (package == "FSD" || package == "fsd" || package == "DW" || package == "dw" || package == "D" || package == "d")
            {

            }
            else
            {
                Console.WriteLine("No Such package available");
                return;
            }
            int Work=0;
            if (package == "FSD" || package == "fsd")
                Work = 5;
            else if (package == "DW" || package == "dw")
                Work = 3;
            else if (package == "D" || package == "d")
                Work = 3;
            Console.WriteLine("Enter "+Work+" Event names and cost separated by ',' for the selected package");
            for (int i = 1; i <= Work; i++)
            {
                Console.WriteLine("Enter event Details "+i);
                lt.Add(Console.ReadLine().ToLower());
            }

           Dictionary<String,double> ans = new Dictionary<String,double>();

            ans = dw.CreateWedding(package, lt);


            Console.WriteLine("\nEvent Name       Cost");
            foreach(KeyValuePair<String,double> item in ans)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }

            Console.WriteLine("Total Cost for the wedding is " + dw.GetTotalCost(ans));



        }
    }
}
