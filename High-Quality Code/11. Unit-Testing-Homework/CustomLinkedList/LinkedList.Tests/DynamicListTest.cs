using System;
using CustomLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedList.Tests
{
    [TestClass]
    public class DynamicListTest
    {
        [TestMethod]
        public void TestValidCountOnNewList()
        {
            var list = new DynamicList<int>();

            var initialCount = list.Count;

            Assert.AreEqual(0, initialCount, "A new created list should have a count of 0.");
        }

        [TestMethod]
        public void TestListCountAfterOneElementAdded()
        {
            var list = new DynamicList<int>();

            list.Add(56);
            var count = list.Count;

            Assert.AreEqual(1, count, "List should have a count of " + count + " after adding 1 element.");
        }

        [TestMethod]
        public void TestValueOfTheAddedElement()
        {
            var list = new DynamicList<int>();

            list.Add(121);
            var value = list[0];

            Assert.AreEqual(121, value, "The value at index 0 should be equal to the expected value.");
        }

        [TestMethod]
        public void TestCountAfterTwoElementsAdded()
        {
            var list = new DynamicList<int>();

            list.Add(45);
            list.Add(222);

            var count = list.Count;

            Assert.AreEqual(2, count, "The count should be equal to the expected value " + count + " .");
        }

        [TestMethod]
        public void TestValueAndOrderOfTwoElementsAdded()
        {
            var list = new DynamicList<int>();

            list.Add(756);
            list.Add(124);

            var firstElement = list[0];
            var secondElement = list[1];

            Assert.AreEqual(756, firstElement, "The element should be equal to the first element of the list.");
            Assert.AreEqual(124, secondElement, "The element should be equal to the second element of the list.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Index greater than the count of the list should throw an exeption.")]
        public void Test_GetIndexGreaterThanCount_ShouldTrowArgumentOutOfRangeException()
        {
            var list = new DynamicList<int>();
            list.Add(0);
            var value = list[1];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Negative index should throw an exeption.")]
        public void Test_SetNegativeIndex_ShouldTrowArgumentOutOfRangeException()
        {
            var list = new DynamicList<int>();
            list[-1] = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Index greater than the count of the list should throw an exeption.")]
        public void Test_SetIndexGreaterThanCount_ShouldTrowArgumentOutOfRangeException()
        {
            var list = new DynamicList<int>();
            list.Add(0);
            list[1] = 5;
        }

        [TestMethod]
        public void Test_SetOnValidIndex()
        {
            var list = new DynamicList<string>();
            list.Add("initial");
            list[0] = "changed";
            var newValue = list[0];
            Assert.AreEqual("changed", newValue, "The value at index 0 should be changed through the indexer.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Negative index should throw an exeption.")]
        public void Test_RemoveAtOnNegativeIndex_ShouldTrowArgumentOutOfRangeException()
        {
            var list = new DynamicList<int>();
            list.RemoveAt(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Index greater than the count of the list should throw an exeption.")]
        public void Test_RemoveAtOnIndexGreaterThanCount_ShouldTrowArgumentOutOfRangeException()
        {
            var list = new DynamicList<int>();
            list.Add(0);
            list.Add(1);
            list.RemoveAt(2);
        }

        [TestMethod]
        public void Test_ListCountAfterRemoveAt()
        {
            var list = new DynamicList<int>();
            list.Add(0);
            list.RemoveAt(0);

            var count = list.Count;
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void Test_RemoveAt()
        {
            var list = new DynamicList<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.RemoveAt(1);
            var firstNumber = list[0];
            var secondNumber = list[1];
            Assert.AreEqual(0, firstNumber, "The first number should be the first entered in the list.");
            Assert.AreEqual(
                2,
                secondNumber,
                "The second number should be the third entered after removing the second from the list.");
        }

        [TestMethod]
        public void Test_CountAfterRemoveNonExistingElementFromList()
        {
            var list = new DynamicList<string>();
            list.Add("one");
            list.Add("two");
            var count = list.Count;
            list.Remove("two");
            Assert.AreEqual(
                2,
                count,
                "The count of the list should remain unchanged after trying to remove a non-existing element.");
        }

        [TestMethod]
        public void Test_ReturnValueAfterRemoveNonExistingElementFromList()
        {
            var list = new DynamicList<string>();
            list.Add("one");
            list.Add("two");
            var index = list.Remove("three");

            Assert.AreEqual(-1, index, "The returned index of a non-existing element should be -1.");
        }

        [TestMethod]
        public void Test_CountAfterRemoveElementFromList()
        {
            var list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");
            list.Add("third");

            list.Remove("second");
            var count = list.Count;

            Assert.AreEqual(2, count, "The count of elements of the list should be 2 after removing an element.");
        }

        [TestMethod]
        public void Test_ReturnedIndexOfTheRemovedElement()
        {
            var list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");
            list.Add("third");

            var index = list.Remove("second");

            Assert.AreEqual(1, index, "The index of the removed element should be 1.");
        }

        [TestMethod]
        public void Test_ValueAndOrderOfLeftElementsAfterRemovingAnElement()
        {
            var list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");
            list.Add("third");

            list.Remove("second");
            var first = list[0];
            var second = list[1];

            Assert.AreEqual("first", first, "The first element of the list should be the first one entered.");
            Assert.AreEqual(
                "third",
                second,
                "The second element in the list should be the third one entered after removing an element.");
        }

        [TestMethod]
        public void Test_IndexOfNonExistingElement()
        {
            var list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");

            var index = list.IndexOf("third");

            Assert.AreEqual(-1, index, "The return value when searching for a non-existing element should be -1.");
        }

        [TestMethod]
        public void Test_IndexOfExistingElement()
        {
            var list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");

            var index = list.IndexOf("second");

            Assert.AreEqual(1, index, "The index of the searched element should be 1.");
        }

        [TestMethod]
        public void Test_ContainsOnNonExisingElement()
        {
            var list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");

            var isFound = list.Contains("third");

            Assert.IsFalse(isFound, "The element is not in the list and Contains should return false.");
        }

        [TestMethod]
        public void Test_ContainsOnExisingElement()
        {
            var list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");

            var isFound = list.Contains("second");

            Assert.IsTrue(isFound, "The element is in the list and Contains should return true.");
        }
    }
}