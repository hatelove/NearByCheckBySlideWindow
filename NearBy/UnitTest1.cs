using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NearBy
{
    [TestClass]
    public class UnitTest1
    {
        [Ignore]
        [TestMethod]
        public void TestMethod1()
        {
            var numbers = new List<int> { 1, 2, 3, 2, 1 };
            var distance = 2;

            Assert.IsTrue(Kata.HasNearBy(numbers, distance));
        }

        [Ignore]
        [TestMethod]
        public void TestHasNearBy_false()
        {
            var numbers = new List<int> { 1, 2, 3, 1, 2 };
            var distance = 2;

            Assert.IsFalse(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_distance_is_zero_should_return_false()
        {
            var numbers = new List<int> { 1, 2, 3, 1, 2 };
            var distance = 0;
            Assert.IsFalse(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_numbers_length_is_1_should_return_false()
        {
            var numbers = new List<int> { 1 };
            var distance = 1;
            Assert.IsFalse(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_numbers_length_is_equals_distance_different_element_should_return_false()
        {
            var numbers = new List<int> {1, 2};
            var distance = 2;
            Assert.IsFalse(Kata.HasNearBy(numbers,distance));
        }
    }

    public static class Kata
    {
        public static bool HasNearBy(List<int> numbers, int distance)
        {
            if (distance == 0 || numbers.Count < 2)
            {
                return false;
            }

            throw new NotImplementedException();
        }
    }
}