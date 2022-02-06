using NUnit.Framework;
using Discriminant;
using System.Collections.Generic;
namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var expected = Discriminant.Discriminant.ParsePart("6x^2");
            Assert.AreEqual(expected, 6);
            expected = Discriminant.Discriminant.ParsePart("+5x");
            Assert.AreEqual(expected, 5);
            expected = Discriminant.Discriminant.ParsePart("+3");
            Assert.AreEqual(expected,3);
            List<int> expected2 = new List<int>();
            expected2 = Discriminant.Discriminant.SplitAndParse("6x^2-3x+4");
            List <int> list = new List<int>() {6,-3,4};
            CollectionAssert.AreEqual(expected2,list);
        }
    }
}