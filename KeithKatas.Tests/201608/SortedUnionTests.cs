﻿using KeithKatas.August2016;
using NUnit.Framework;

namespace Sandbox._201608
{
    [TestFixture]
    public class SortedUnionTests
    {
        [Test]
        public void SortedUnionTest1()
        {
            CollectionAssert.AreEqual(new object[] { 1, 2, 3, 4 }, SortedUnion.UniteUnique(new[] { new object[] { 1, 2 }, new object[] { 3, 4 } }));
            CollectionAssert.AreEqual(new object[] { 1, 3, 2, 5, 4 }, SortedUnion.UniteUnique(new[] { new object[] { 1, 3, 2 }, new object[] { 5, 2, 1, 4 }, new object[] { 2, 1 } }));
            CollectionAssert.AreEqual(new object[] { 4, 3, 2 }, SortedUnion.UniteUnique(new[] { new object[] { 4, 3, 2, 2 } }));
            CollectionAssert.AreEqual(new object[] { 4, "a", 2 }, SortedUnion.UniteUnique(new[] { new object[] { 4, "a", 2 }, new object[] { } }));
            CollectionAssert.AreEqual(new object[] { 4, "a", 2 }, SortedUnion.UniteUnique(new[] { new object[] { }, new object[] { 4, "a", 2 } }));
            CollectionAssert.AreEqual(new object[] { 4, "a", 2 }, SortedUnion.UniteUnique(new[] { new object[] { }, new object[] { 4, "a", 2 }, new object[] { } }));
            CollectionAssert.AreEqual(new object[] { }, SortedUnion.UniteUnique(new[] { new object[] { } }));
            CollectionAssert.AreEqual(new object[] { }, SortedUnion.UniteUnique(new[] { new object[] { }, new object[] { } }));
            CollectionAssert.AreEqual(new object[] { 1, 2 }, SortedUnion.UniteUnique(new[] { new object[] { }, new object[] { 1, 2 } }));
            CollectionAssert.AreEqual(new object[] { 1, 2 }, SortedUnion.UniteUnique(new[] { new object[] { }, new object[] { 1, 2, 1, 2 }, new object[] { 2, 1, 1, 2, 1 } }));
        }
    }
}
