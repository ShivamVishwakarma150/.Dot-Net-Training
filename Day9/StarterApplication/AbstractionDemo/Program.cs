using System;

namespace AbstractionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Facebook fb=new Facebook();
            fb.printDetails();

            Twitter tw=new Twitter();
            tw.printDetails();
        }
    }
}
