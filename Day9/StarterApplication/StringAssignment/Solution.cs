using System;
using System.Collections.Generic;
using System.Text;

namespace StringAssignment
{
    internal class Solution
    {
        public void lowerCase(String s)
        {
            Console.WriteLine(s.ToLower());
        }
        public void convertTextToSms(String s)
        {
            Console.WriteLine(s.Replace("you","u").Replace("yes","s").Replace("today", "2day").Replace("why","y"));
        }
        public void DoSplit(String s)
        {
            String[] ans = s.Split(" ");


            foreach (String item in ans)
            {
                Console.WriteLine(item);
            }
        }
        public void stringOperations(String a,String b)
        {
            Console.WriteLine("The length of the first string is "+a.Length);
            Console.WriteLine("The length of the second string is " + b.Length);
            Console.WriteLine("The uppercase of the first string  " + a.ToUpper());
            Console.WriteLine("The uppercase of the second string  " + b.ToUpper());
            Console.WriteLine("The concatenated string is " + a+b);
            Console.WriteLine(b + " appears before " + a);

        }
       
    }
}
