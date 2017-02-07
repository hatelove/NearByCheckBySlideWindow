using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace NearBy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_numbers_1_2_3_2_1_and_distance_is_2_should_return_true()
        {
            var numbers = new int[] { 1, 2, 3, 2, 1 };
            var distance = 2;

            Assert.IsTrue(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_numbers_1_2_3_1_2_and_distance_is_2_should_return_false()
        {
            var numbers = new int[] { 1, 2, 3, 1, 2 };
            var distance = 2;

            Assert.IsFalse(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_distance_is_zero_should_return_false()
        {
            var numbers = new int[] { 1, 2, 3, 1, 2 };
            var distance = 0;
            Assert.IsFalse(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_numbers_length_is_1_should_return_false()
        {
            var numbers = new int[] { 1 };
            var distance = 1;
            Assert.IsFalse(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_numbers_length_is_equals_distance_different_element_should_return_false()
        {
            var numbers = new int[] { 1, 2 };
            var distance = 2;
            Assert.IsFalse(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_numbers_1_1_and_distance_2_should_return_true()
        {
            var numbers = new int[] { 1, 1 };
            var distance = 2;
            Assert.IsTrue(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_numbers_9_5_9_and_distance_is_3_should_return_true()
        {
            var numbers = new int[] { 9, 5, 9 };
            var distance = 3;
            Assert.IsTrue(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_numbers_9_5_9_and_distance_is_2_should_return_true()
        {
            var numbers = new int[] { 9, 5, 9 };
            var distance = 2;
            Assert.IsTrue(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_numbers_9_5_6_9_and_distance_is_2_should_return_false()
        {
            var numbers = new int[] { 9, 5, 6, 9 };
            var distance = 2;
            Assert.IsFalse(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_numbers_9_5_6_4_9_4_4_9and_distance_is_3_should_return_true()
        {
            var numbers = new int[] { 9, 5, 6, 4, 9, 4, 4, 9 };
            var distance = 3;
            Assert.IsTrue(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_numbers_9_5_6_4_9_4_4_9_and_distance_is_99_should_return_true()
        {
            var numbers = new int[] { 9, 5, 6, 4, 9, 4, 4, 9 };
            var distance = 99;
            Assert.IsTrue(Kata.HasNearBy(numbers, distance));
        }

        [TestMethod]
        public void Test_Long_array()
        {
            var numbers = Enumerable.Range(-3000, 5000).ToArray();
            var distance = 100;
            Assert.IsFalse(Kata.HasNearBy(numbers, distance));
        }
    }

    public static class Kata
    {
        public static bool HasNearBy(int[] nums, int k)
        {
            if (k == 0)
            {
                return false;
            }

            var set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.Add(nums[i])) return true;

                //hashset 只保留目前 window 的內容
                if (i >= k) set.Remove(nums[i - k]);
            }

            return false;
        }
    }
}