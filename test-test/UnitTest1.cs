using NUnit.Framework;
using ConsoleApp1;
using System.Reflection;

namespace test_test
{
    public class Tests
    {
        private MathOperations mo;

        [SetUp]
        public void Setup()
        {
            mo = new MathOperations();
        }

        [Test]
        public void DivideByZero()
        {
            double a = mo.Division(12, 3);
            Assert.AreEqual(a, 4);
        }
        [Test]
        public void DivideByZero2()
        {
            double a = mo.Division(12, 0);
            Assert.IsNaN(a);
        }
    }
}