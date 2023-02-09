using System;

namespace ArraysDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Classwork :- Write a program to take inputs in array and then arrange it in ascending,descending order and then find the average or that array , and then find all values lesser that that avg.
            Console.Write("Enter size of Array : ");
            int size=int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("Enter "+arr.Length+" Numbers");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Arrays in Ascending Order");
            Array.Sort(arr);
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Arrays in Descending Order");
            Array.Sort(arr);
            Array.Reverse(arr);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            // Finding avg
            int sum = 0;
            for(int i=0;i<arr.Length;i++) {
                sum += arr[i];
            }
            int avg = (sum / arr.Length);
            Console.WriteLine("Avg is : "+avg);

            // Values lesser than avg
            Console.Write("Values lesser than avg : ");
            foreach(int item in Array.FindAll(arr, num => num < avg))
            {
                Console.Write(item+",");
            }
            Console.WriteLine();




        }
    }
}
