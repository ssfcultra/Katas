﻿using KeithKatas.October2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace KeithKatas.Tests.October2017
{
    [TestClass]
    public class SquareEveryDigitTests
    {
        [TestMethod]
        public void SquareEveryDigit_SquareDigits_SimpleTest1()
        {
            Assert.AreEqual(811181, SquareEveryDigit.SquareDigits(9119));
        }

        [TestMethod]
        public void SquareEveryDigit_SquareDigits_SimpleTest2()
        {
            Assert.AreEqual(9414, SquareEveryDigit.SquareDigits(3212));
        }

        [TestMethod]
        public void SquareEveryDigit_SquareDigits_SimpleTest3()
        {
            Assert.AreEqual(4114, SquareEveryDigit.SquareDigits(2112));
        }

        [TestMethod]
        public void SquareEveryDigit_SquareDigits_Random()
        {
            var random = new Random();
            int next;

            for (int i = 0; i < 10; ++i)
            {
                next = random.Next(0, 1001);
                Assert.AreEqual(Solution(next), SquareEveryDigit.SquareDigits(next));
            }
        }

        private int Solution(int n)
        {
            return int.Parse(string.Join("", n.ToString().Select(d => int.Parse("" + d) * int.Parse("" + d))));
        }
    }
}
