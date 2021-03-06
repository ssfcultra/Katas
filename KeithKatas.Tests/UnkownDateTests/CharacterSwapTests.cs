﻿using System;
using NUnit.Framework;
using Kata;

namespace Sandbox
{
    [TestFixture]
    public class CharacterSwapTests
    {
        [Test]
        public void CharacterSwapFirstTest()
        {
            string input = "this is my string";
            Assert.AreEqual("th3s 6s my str15ng", CharacterSwap.Vowel2Index(input));
        }

        [Test]
        public void CharacterSwapSecondTest()
        {
            string input = "Codewars is the best site in the world";
            Assert.AreEqual("C2d4w6rs 10s th15 b18st s23t25 27n th32 w35rld", CharacterSwap.Vowel2Index(input));
        }

        [Test]
        public void CharacterSwapThirdTest()
        {
            string input = "Tomorrow is going to be raining";
            Assert.AreEqual("T2m4rr7w 10s g1415ng t20 b23 r2627n29ng", CharacterSwap.Vowel2Index(input));
        }

        [Test]
        public void CharacterSwapFourthTest()
        {
            string input = "";
            Assert.AreEqual("", CharacterSwap.Vowel2Index(input));
        }
    }
}
