using System;

namespace ArraysDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array : ");
            int[] marks = new int[5];
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("---- Before Sorting the arrays");
            foreach(int i in marks)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---- After Sorting the arrays");
            // Array sorting
            Array.Sort(marks);
            
            foreach (int i in marks)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---- After Sorting the arrays in Descendin order");
            Array.Reverse(marks);
            foreach (int i in marks)
            {
                Console.WriteLine(i);
            }

            // Finding the element at the given index
            Console.WriteLine("Enter the index");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine(marks[index]);
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Array.FindIndex(marks,t=>t==number));


            Console.WriteLine(Array.Find(marks, num => num % 2 == 0));

            Console.WriteLine(Array.FindAll(marks, num => num % 2 == 0));

            // for printing all even elements using foreach
            foreach(int item in Array.FindAll(marks, num => num % 2 == 0))
            {
                Console.WriteLine(item);
            }



        }
    }
}
