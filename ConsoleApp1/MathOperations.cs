using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MathOperations
    {
        public int x;
        public int y;
        public MathOperations()
        {

        }
        public MathOperations(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double Addition(double x, double y)
        {
            return x + y;
        }
        public double Division(double x, double y)
        {
            return x / y;
        }
    }
}
