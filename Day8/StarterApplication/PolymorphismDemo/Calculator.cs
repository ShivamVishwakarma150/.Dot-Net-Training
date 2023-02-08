using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismDemo
{
    internal class Calculator // base,super,parent class
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(int x,int y ,int z)
        {
            return x + y + z;   
        }

        public virtual int Multiply(int a,int b)
        {
            return a * b;
        }
        public int Multiply(int a, int b,int c)
        {
            return a * b*c;
        }
    }
    class SuperCalculator:Calculator
    {

    }

    class DeluxCalculator:Calculator
    {
        public override int Multiply(int x,int y)
        {

            return base.Multiply(x,y);
        } 
    }
}
