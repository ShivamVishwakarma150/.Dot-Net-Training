using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            // Non-Generic List
            ArrayList list = new ArrayList();

            list.Add(100);
            list.Add("Shivam");
            list.Add('F');
            list.Add(98);

            // Non Generic Dictionary (key,value) 
            Hashtable hTable = new Hashtable();
            // key value pair of data
            hTable.Add(1, "Shivam");
            hTable.Add(2, "Dhivya");
            hTable.Add(3, "VIkash");

            // Generic List
            List<int> numbers = new List<int>();
            numbers.Add(100);
            numbers.Add(50);
            numbers.Add(10);

            List<String> names = new List<String>();
            names.Add("Shivam");
            names.Add("Jyoti");
            names.Add("Vikash");

            // Generic Dictionary
            Dictionary<int,String> keyValuePairs= new Dictionary<int,String>();

            keyValuePairs.Add(101, "Shivam");
            keyValuePairs.Add(102, "Vikash");
            keyValuePairs.Add(103, "Prashant");
            keyValuePairs.Add(104, "Santosh");

            foreach(KeyValuePair<int,String> item in keyValuePairs)
            {
                /* Console.WriteLine(item.Key);*/
                /*Console.WriteLine(item.Value);*/
                Console.WriteLine(item);
            }

            Console.Write("Enter a key value : ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(keyValuePairs[key]);

            Console.WriteLine(keyValuePairs.ContainsKey(103));
            
            SortedSet<int> sortedList = new SortedSet<int>();
            sortedList.Add(100);
            sortedList.Add(50);
            sortedList.Add(101);

            foreach(int nums in sortedList)
            {
                    Console.WriteLine(nums);
            }



        }
    }
}
