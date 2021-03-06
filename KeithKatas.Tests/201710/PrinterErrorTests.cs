﻿using KeithKatas.October2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.October2017
{
    [TestFixture]
    public class PrinterErrorTests
    {
        private static Random rnd = new Random();

        [Test]
        public void Printer_PrinterError_SimpleTest()
        {
            Console.WriteLine("Testing PrinterError");
            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Assert.AreEqual("3/56", Printer.PrinterError(s));
        }

        [Test]
        public void Printer_PrinterError_MoreSimpleTests()
        {
            Console.WriteLine("Testing PrinterError");
            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Assert.AreEqual("3/56", Printer.PrinterError(s));
            s = "kkkwwwaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Assert.AreEqual("6/60", Printer.PrinterError(s));
            s = "kkkwwwaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyzuuuuu";
            Assert.AreEqual("11/65", Printer.PrinterError(s));
        }

        [Test]
        public void Printer_PrinterError_RandomTest()
        {
            Console.WriteLine("Random Tests");
            for (int i = 0; i < 200; i++)
            {
                string s = DoEx();
                Assert.AreEqual(PrinterErrorSol(s), Printer.PrinterError(s));
            }
        }

        private string DoEx()
        {
            int i = 0; String res = ""; int n = 0;
            int k = rnd.Next(10, 500);
            while (i < (int)3 * k / 2)
            {
                n = rnd.Next(97, 109);
                res += (char)(n);
                i++;
            }
            while (i < 2 * k)
            {
                if (i % 17 == 0) n = rnd.Next(110, 122); else n = rnd.Next(97, 109);
                res += (char)(n);
                i++;
            }
            return res;
        }
        private string PrinterErrorSol(String s)
        {
            int cnt = 0; int l = s.Length;
            for (int i = 0; i < l; i++)
            {
                int c = (int)s[i];
                if (c > 109 && c <= 122)
                    cnt++;
            }
            return cnt.ToString() + "/" + l.ToString();
        }
    }
}
