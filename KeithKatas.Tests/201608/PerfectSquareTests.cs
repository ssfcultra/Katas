﻿using KeithKatas.August2016;
using NUnit.Framework;

namespace Sandbox._201608
{
    [TestFixture]
    public class PerfectSquareTests
    {
        [Test]
        public void PerfectSquareTest1()
        {
            Assert.AreEqual(false, PerfectSquares.IsSquare(-1), "negative numbers aren't square numbers");
            Assert.AreEqual(false, PerfectSquares.IsSquare(3), "3 isn't a square number");
            Assert.AreEqual(true, PerfectSquares.IsSquare(4), "4 is a square number");
            Assert.AreEqual(true, PerfectSquares.IsSquare(25), "25 is a square number");
            Assert.AreEqual(false, PerfectSquares.IsSquare(26), "26 isn't a square number");
        }
    }
}
