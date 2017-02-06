using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NearBy
{
    [TestClass]
    public class UnitTest1
    {
        [Ignore]
        [TestMethod]
        public void TestMethod1()
        {
            var numbers = new List<int> {1,2,3,2,1};
            var distance = 2;

            Assert.IsTrue(Kata.HasNearBy(numbers, distance));
        }

        [Ignore]
        [TestMethod]
        public void TestHasNearBy_false()
        {
            var numbers = new List<int> {1, 2, 3, 1, 2};
            var distance = 2;

            Assert.IsFalse(Kata.HasNearBy(numbers, distance));
        }
    }

    public static class Kata
    {
        public static bool HasNearBy(List<int> numbers, int distance)
        {
            throw new NotImplementedException();
        }
    }
}
