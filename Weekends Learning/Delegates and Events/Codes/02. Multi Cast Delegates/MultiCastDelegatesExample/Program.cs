using System;
using ClassLibrary1;

namespace MultiCastDelegatesExample
{
    class Program
    {
        static void Main()
        {
            //create object of Sample
            Sample s = new Sample();

            //create reference variable of MyDelegateType
            MyDelegateType myDelegate;

            //add ref of first target method
            // Internally it will create an object of delegate  in that delegate obejct the referenct add method will stored and then the reference of the delegate object will be stored in the reference variable called myDelegate.
            myDelegate = s.Add;

            //add ref of second target method
            myDelegate += s.Multiply;

            //invoke both target methods; first Add method; and then Multiply method
            myDelegate.Invoke(40, 10);

             
        }
    }
}
