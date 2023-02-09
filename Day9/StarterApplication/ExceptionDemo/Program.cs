using System;

namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");

            // Handling exceptions (Run time Error)
            try
            {
                String s = null;
                int n = int.Parse(Console.ReadLine());
                int n1=int.Parse(Console.ReadLine());
                Console.WriteLine(n / n1);
            }
            catch(DivideByZeroException dzEx)
            {
                Console.WriteLine(dzEx.Message);
            }
            catch(OverflowException ovEx)
            {
                Console.WriteLine(ovEx.Message);
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Connecting with database - Open the connection, manipulations, (gone right or wrong), close the connection
                // Writing in a File -- Open the file,write inside or something might have goes wrong did not get write in the file, close the file
                // Dispose the object after no use...
                Console.WriteLine("Program Done");
            }
        }
    }
}
