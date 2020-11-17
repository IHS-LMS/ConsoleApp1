using NUnit.Framework;
using 

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            MathOperations mo = new MathOperations();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}