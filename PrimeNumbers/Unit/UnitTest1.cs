using NUnit.Framework;
using PrimeNumbers;
using System.Collections;
namespace Unit
{
    public class UnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ArrayList expected= new ArrayList () { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            Assert.AreEqual(PrimeNumbers.PrimeNumbers.FindPrimeNumbers(100),expected);
        }
    }
}