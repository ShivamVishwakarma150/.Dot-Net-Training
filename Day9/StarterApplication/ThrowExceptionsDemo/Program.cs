using System;

namespace ThrowExceptionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Email ID : ");
                string email = Console.ReadLine();
                if (email.Length > 10)
                {
                    // used for explicitly throwing an exception
                    // The throw keyword is used for instructing the CLR to throw the exception if the condition is true.
                    throw new EmailLengthException("Email Length Greater than 10");
                }
            }
            catch (EmailLengthException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class EmailLengthException : Exception
    {
        public EmailLengthException(string message):base(message)
        {
            
        }
    }

}
