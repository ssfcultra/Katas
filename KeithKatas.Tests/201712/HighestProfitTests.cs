﻿using Kata.December2017;
using NUnit.Framework;
using System;
using System.Linq;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class HighestProfitTests
    {
        [Test]
        public static void HighestProfit_MixMax_BasicTest()
        {
            Assert.AreEqual(new int[] { -1, 20 }, HighestProfit.MinMax(new int[] { 1, 2, 5, -1, 12, 20 }));
            Assert.AreEqual(new int[] { 1, 5 }, HighestProfit.MinMax(new int[] { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(new int[] { -3, 5 }, HighestProfit.MinMax(new int[] { 1, 2, -3, 4, 5 }));
            Assert.AreEqual(new int[] { -5, 9 }, HighestProfit.MinMax(new int[] { 1, 9, 3, 4, -5 }));
            Assert.AreEqual(new int[] { -214, 542 }, HighestProfit.MinMax(new int[] { 4, 5, 29, 54, 4, 0, -214, 542, -64, 1, -3, 6, -6 }));
            Assert.AreEqual(new int[] { 4, 4 }, HighestProfit.MinMax(new int[] { 4 }));
        }

        [Test]
        public static void HighestProfit_MixMax_RandomTestArrayOneElement()
        {
            Random random = new Random();
            int rn = random.Next(1, 500);
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(new int[] { rn, rn }, HighestProfit.MinMax(new int[] { rn }));
            }
        }

        //-----------------------
        private static int[] CombineIntegers(int k)
        {
            Random random = new Random();
            int[] res = new int[k];
            for (int i = 0; i < k; i++)
            {
                int x = random.Next(1, 10000);
                int y = random.Next(17, 29);
                int sgn = random.Next(0, 10);
                if (sgn == 0)
                    x = -x;
                res[i] = x * y;
            }
            return res;
        }
        private static int[] MinMaxSol(int[] lst)
        {
            return new int[] { lst.Min(), lst.Max() };
        }

        //-----------------------

        [Test]
        public static void HighestProfit_MixMax_RandomTestBiggerArrays()
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int[] lst = CombineIntegers(random.Next(10, 50));
                //Console.WriteLine("minMax test number: " + i);
                Assert.AreEqual(MinMaxSol(lst), HighestProfit.MinMax(lst));
            }
        }
    }
}
