using System;

namespace ArraysDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[2];
            int[] sqlMarks = { 90, 89, 56, 100 }; // size of this array is 4
            char[] choices = { '+', '-', '*', '/' };
            string[] names= new string[2];

            Console.WriteLine("Enter the marks");
            marks[0]=int.Parse(Console.ReadLine());
            marks[1]=int.Parse(Console.ReadLine());

          /*  Console.WriteLine(marks[0]); // first
            Console.WriteLine(marks[1]); // second*/

           /* for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
*/

            foreach (int item in marks)
            {
                Console.WriteLine(item);
            }

            for(int i = 0; i < names.Length; i++)
            {
                names[i]=Console.ReadLine();
            }
            foreach (String item in names)
            {
                Console.WriteLine(item);
            }

        }
    }
}
