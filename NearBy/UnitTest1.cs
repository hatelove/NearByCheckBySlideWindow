using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NearBy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_numbers_1_2_3_2_1_and_distance_is_2_should_return_true()
        {
            var numbers = new List<int> { 1, 2, 3, 2, 1 };
            var distance = 2;

            Assert.IsTrue(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_numbers_1_2_3_1_2_and_distance_is_2_should_return_false()
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
            var numbers = new List<int> { 1, 2 };
            var distance = 2;
            Assert.IsFalse(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_numbers_1_1_and_distance_2_should_return_true()
        {
            var numbers = new List<int> { 1, 1 };
            var distance = 2;
            Assert.IsTrue(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_numbers_9_5_9_and_distance_is_3_should_return_true()
        {
            var numbers = new List<int> { 9, 5, 9 };
            var distance = 3;
            Assert.IsTrue(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_numbers_9_5_9_and_distance_is_2_should_return_true()
        {
            var numbers = new List<int> { 9, 5, 9 };
            var distance = 2;
            Assert.IsTrue(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_numbers_9_5_6_9_and_distance_is_2_should_return_false()
        {
            var numbers = new List<int> { 9, 5, 6, 9 };
            var distance = 2;
            Assert.IsFalse(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_numbers_9_5_6_4_9_4_4_9and_distance_is_3_should_return_true()
        {
            var numbers = new List<int> { 9, 5, 6, 4, 9, 4, 4, 9 };
            var distance = 3;
            Assert.IsTrue(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_numbers_9_5_6_4_9_4_4_9_and_distance_is_99_should_return_true()
        {
            var numbers = new List<int> { 9, 5, 6, 4, 9, 4, 4, 9 };
            var distance = 99;
            Assert.IsTrue(Kata.HasNearBy(numbers, distance));
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

            var index = 0;
            var windowsSize = distance + 1;
            var size = numbers.Count > windowsSize ? windowsSize : numbers.Count;

            do
            {
                var listOfWindow = numbers.GetRange(index, size);
                if (HasDuplicate(listOfWindow)) return true;

                index++;
            } while (index + size <= numbers.Count);

            return false;
        }

        private static bool HasDuplicate(List<int> listOfWindow)
        {
            var hashSet = new HashSet<int>();
            foreach (var i in listOfWindow)
            {
                if (!hashSet.Add(i))
                {
                    return true;
                }
            }
            return false;
        }
    }
}