using System;

namespace ClassLibrary1
{
    //delegate type
    public delegate void MyDelegateType(int a, int b);

    //publisher
    public class Publisher
    {
        //private delegate
        private MyDelegateType myDelegate;

        //step 1: create event
        public event MyDelegateType myEvent
        {
            add
            {
                myDelegate += value;
            }
            remove
            {
                myDelegate -= value;
            }
        }

        public void RaiseEvent(int a, int b)
        {
            //step 2: raise event
            // atleast one or more methods have been subscribe to the event then only we have raise the event
            if (this.myDelegate != null)
            {
                this.myDelegate(a, b);
            }
        }
    }
}
