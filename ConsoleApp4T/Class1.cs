using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4T
{
    public class Class1

    {
        public double a;
        public double b;
        public int c;
        public int d;
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public double Min(double a, double b)
        {
            return a - b;
        }
        public double Sqrt(double a)
        {
            int result = 0;
            int b = 1;
            
            while (b <= a)
            {
                a -= b;
                b += 2;
                result += 1;
            }
            return result;
        }
        public double Mult(double a, double b)
        {
            return a * b;
        }
        public int Div(int c, int d)
        {
            return c / d;
        }
    }
}
