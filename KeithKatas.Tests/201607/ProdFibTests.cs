﻿using KeithKatas.July2016;
using NUnit.Framework;

namespace Sandbox._201607
{
    [TestFixture]
    public class ProdFibTests
    {
        [Test]
        public void ProdFibTest1()
        {
            ulong[] r = new ulong[] { 55, 89, 1 };
            CollectionAssert.AreEqual(r, ProdFib.productFib(4895));
        }

        [Test]
        public void ProdFibTest2()
        {
            ulong[] r = new ulong[] { 21, 34, 1 };
            CollectionAssert.AreEqual(r, ProdFib.productFib(714));
        }

        [Test]
        public void ProdFibTest3()
        {
            ulong[] r = new ulong[] { 34, 55, 0 };
            CollectionAssert.AreEqual(r, ProdFib.productFib(800));
        }

        [Test]
        public void ProdFibTest4()
        {
            ulong[] r = new ulong[] { 610, 987, 1 };
            CollectionAssert.AreEqual(r, ProdFib.productFib(602070));
        }
        
        [Test]
        public void ProdFibTest5()
        {
            ulong[] r = new ulong[] { 610, 987, 1 };
            CollectionAssert.AreEqual(r, ProdFib.productFib(447577));
        }
    }
}
