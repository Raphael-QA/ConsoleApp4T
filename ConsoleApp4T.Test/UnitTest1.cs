using System;
using System.Linq;
using Xunit;

namespace ConsoleApp4T.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            Class1 class1 = new Class1();
         

            double a = 2;
            double b = 2;



            double act=class1.Sum(a, b);
            double exp = 4;
            Assert.Equal(exp, act);
        }
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(243, 11, 254)]

        public void TestMethod2(double a, double b, double exp)
        {
            Class1 class1 = new Class1();
  
            double act = class1.Sum(a, b);
           
            Assert.Equal(exp, act);
        }
        [Theory]
        [InlineData(121, 11)]
        [InlineData(25, 5)]

        public void TestSqrt(double a, double exp)
        {
            Class1 class1 = new Class1();
     

            double act = class1.Sqrt(a);

            Assert.Equal(exp, act);
        }
        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(2, 5, 10)]

        public void TestMult(double a, double b, double exp)
        {
            Class1 class1 = new Class1();



            double act = class1.Mult(a,b);

            Assert.Equal(exp, act);
        }
        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(27, 9, 3)]

        public void TestDiv(double a, double b, double exp)
        {
            Class1 class1 = new Class1();


            double act = class1.Div(a, b);

            Assert.Equal(exp, act);
        }
    }
}
