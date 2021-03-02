using System;
using System.Collections.Generic;
using System.Text;


namespace NUnit2
{
    interface IMathLibrary
    {
        double Addition(double a, double b);
        double Subtraction(double a, double b);
        double Multiplication(double a, double b);
        double Division(double a, double b);
    }

    public class Calculator1 : IMathLibrary
    {
        double result = 0;
        public double Addition(double a, double b)
        {
            result = a + b;
            return result;
        }

        public double Subtraction(double a, double b)
        {
            result = a - b;
            return result;
        }

        public double Multiplication(double a, double b)
        {
            result = a * b;
            return result;
        }

        public double Division(double a, double b)
        {
            
            result = a / b;
            return result;
        }

        public void AllClear()
        {
            result = 0;
        }

        public double GetResult
        {
            get { return result; }
        }
        static void Main(string[] args)
        {
        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework;
//using NUnit2; 


//namespace NUnit2
//{

//    [TestFixture]
//    public class CalculatorTests
//    {
//        private Calculator calculator;


//        [SetUp]
//        public void SetUp()
//        {
//            calculator = new Calculator();

//        }

//        [Test]
//        [TestCase(2, 1, 3)]
//        //[TestCase(2,1,4)]
//        public void addMethod(int a, int b, int sum)
//        {

//            var result = calculator.Add(a, b);

//            Assert.That(result, Is.EqualTo(sum));
//        }
//        static void Main(string[] args)
//      {
//      }


//        //[TearDown]
//        //public void CleanUpMethod()
//        //{
//        //    sum = 0;
//        //}

//    }
//}