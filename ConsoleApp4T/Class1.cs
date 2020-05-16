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



                                 
            //double result = 0;
            //double b = 1;

            //while (b <= a)
            //{
            //    a -= b;
            //    b += 2;
            //    result += 1;
            //}
            return Math.Sqrt(a);
        }
        public double Mult(double a, double b)
        {
            return a * b;
        }
        public double Div(double c, double d)
        {
            if(b!=0)
                {
              return c / d;
            }
            else
            {
                throw new Exception("Деление на 0");
            }
            
        }
    }
}
