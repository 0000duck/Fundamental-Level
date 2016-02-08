using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomLinkedListTests
{
    [TestClass]
    public class DynamicListTests
    {
        private DynamicList<ValueType> dynamicListValueType;

        [TestInitialize]
        public void InitializeList()
        {
            this.dynamicListValueType = new DynamicList<ValueType>();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexerGetter_NegativeIndex_ShouldThrowException()
        {
            var testElement = this.dynamicListValueType[-9];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexerGetter_IndexLargerThanElementsCount_ShouldThrowException()
        {
            var testCount = this.dynamicListValueType.Count + 1;
            var testElement = this.dynamicListValueType[testCount];
        }

        [TestMethod]
        public void TestIndexerGetter_CorrectInput()
        {
            this.dynamicListValueType.Add(5.1334);

            ValueType expectedElement = 5.1334;

            Assert.AreEqual(expectedElement, this.dynamicListValueType[0], "The indexer getter doesn't return the right value");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIntexerSetter_NegativeIndex_ShouldThrowException()
        {
            this.dynamicListValueType[-1] = 5;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIntexerSetter_IndexLargerThanElementsCount_ShouldThrowException()
        {
            var testCount = this.dynamicListValueType.Count + 1;
            this.dynamicListValueType[testCount] = 5;
        }

        [TestMethod]
        public void TestIndexerSetter_CorrectInput()
        {
            this.dynamicListValueType.Add(10);

            this.dynamicListValueType[0] = 17777777777965465440;
            var expectedElement = 17777777777965465440;

            Assert.AreEqual(expectedElement, this.dynamicListValueType[0], "The indexer setter doesn't set the right value");
        }

        [TestMethod]
        public void TestAdd_EmptyList()
        {
            this.dynamicListValueType.Add(22);

            var expectedElement = 22;

            Assert.AreEqual(expectedElement, this.dynamicListValueType[this.dynamicListValueType.Count - 1],
                "The add method doesn't add the right element in an empty list");
        }

        [TestMethod]
        public void TestAdd_NonEmptyList()
        {
            this.dynamicListValueType.Add(22);
            this.dynamicListValueType.Add(44);
            this.dynamicListValueType.Add(88);

            var expectedElement = 88;

            Assert.AreEqual(expectedElement, this.dynamicListValueType[this.dynamicListValueType.Count - 1],
                "The add method doesn't add the right element in a non-empty list");
        }

        [TestMethod]
        public void TestCountIncrementation_Add()
        {
            this.dynamicListValueType.Add(22);
            this.dynamicListValueType.Add(33);

            var expectedCount = 2;

            Assert.AreEqual(expectedCount, this.dynamicListValueType.Count,
                "The add method doesn't increment the elements count when adding new element");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveAt_NegativeIndex_ShouldThrowException()
        {
            this.dynamicListValueType.RemoveAt(-5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveAt_IndexLargerThanElementsCount_ShouldThrowException()
        {
            this.dynamicListValueType.RemoveAt(this.dynamicListValueType.Count + 1);
        }

        [TestMethod]
        public void TestRemoveAt_ValueContainedInList()
        {
            this.dynamicListValueType.Add(22);
            this.dynamicListValueType.Add(33);
            this.dynamicListValueType.Add(44);

            var expectedElement = 33;

            Assert.AreEqual(expectedElement, this.dynamicListValueType.RemoveAt(1),
                "The RemoveAt method doesn't return the right element");
        }

        [TestMethod]
        public void TestCountDecrementation_RemoveAt()
        {
            this.dynamicListValueType.Add(22);
            this.dynamicListValueType.Add(33);
            this.dynamicListValueType.Add(44);

            this.dynamicListValueType.RemoveAt(1);

            var expectedCount = 2;

            Assert.AreEqual(expectedCount, this.dynamicListValueType.Count,
                "The RemoveAt method doesn't decrement the elements count when removing an element");
        }

        [TestMethod]
        public void TestIfElementRemoved_RemoveAt()
        {
            this.dynamicListValueType.Add(22);
            this.dynamicListValueType.Add(33);
            this.dynamicListValueType.Add(44);

            var elementToBeRemoved = this.dynamicListValueType.RemoveAt(1); ;

            bool isElementRemoved = true;
            for (var i = 0; i < this.dynamicListValueType.Count; i++)
            {
                if (this.dynamicListValueType[i].Equals(elementToBeRemoved))
                {
                    isElementRemoved = false;
                }
            }

            Assert.AreEqual(true, isElementRemoved, "The RemoveAt method doesn't remove the element");
        }

        [TestMethod]
        public void TestRemove_ValueContainedInList()
        {
            this.dynamicListValueType.Add(22);
            this.dynamicListValueType.Add(33);
            this.dynamicListValueType.Add(44);

            ValueType expectedIndex = 1;

            Assert.AreEqual(expectedIndex, this.dynamicListValueType.Remove(33),
                "The Remove method doesn't return the right element");
        }

        [TestMethod]
        public void TestRemove_ValueNotContainedInList()
        {
            this.dynamicListValueType.Add(22);
            this.dynamicListValueType.Add(33);
            this.dynamicListValueType.Add(44);

            var excpetedResult = -1;

            Assert.AreEqual(excpetedResult, this.dynamicListValueType.Remove(55),
                "The Remove method doesn't return the right value when given element not present in the list");
        }

        [TestMethod]
        public void TestIfElementRemoved_Remove()
        {
            this.dynamicListValueType.Add(22);
            this.dynamicListValueType.Add(33);
            this.dynamicListValueType.Add(44);

            var elementToBeRemoved = this.dynamicListValueType.Remove(1); ;

            bool isElementRemoved = true;
            for (var i = 0; i < this.dynamicListValueType.Count; i++)
            {
                if (this.dynamicListValueType[i].Equals(elementToBeRemoved))
                {
                    isElementRemoved = false;
                }
            }

            Assert.AreEqual(true, isElementRemoved, "The Remove method doesn't remove the element");
        }

        [TestMethod]
        public void TestCountDecrementation_Remove()
        {
            this.dynamicListValueType.Add(22);
            this.dynamicListValueType.Add(33);
            this.dynamicListValueType.Add(44);

            this.dynamicListValueType.Remove(33);

            var expectedCount = 2;

            Assert.AreEqual(expectedCount, this.dynamicListValueType.Count,
                "The remove method doesn't decrement the elements count when removing an element");
        }

        [TestMethod]
        public void TestIndexOf_ValueContainedInList()
        {
            this.dynamicListValueType.Add(22);
            this.dynamicListValueType.Add(33);
            this.dynamicListValueType.Add(44);

            var expectedIndex = 1;

            Assert.AreEqual(expectedIndex, this.dynamicListValueType.IndexOf(33),
                "The IndexOf method doesn't return the right index when given element contained in the list");
        }

        [TestMethod]
        public void TestIndexOf_ValueNotContainedInList()
        {
            this.dynamicListValueType.Add(22);
            this.dynamicListValueType.Add(33);
            this.dynamicListValueType.Add(44);

            var expectedResult = -1;

            Assert.AreEqual(expectedResult, this.dynamicListValueType.IndexOf(55),
                "The IndexOf method doesn't return the right value when given value not contained in the list");
        }

        [TestMethod]
        public void TestContains_ValueContainedInList()
        {
            this.dynamicListValueType.Add(22);
            this.dynamicListValueType.Add(33);
            this.dynamicListValueType.Add(44);

            bool expectedResult = true;

            Assert.AreEqual(expectedResult, this.dynamicListValueType.Contains(22),
                "The Contains method can't find the element");
        }

        [TestMethod]
        public void TestContains_ValueNotContainedInList()
        {
            this.dynamicListValueType.Add(22);
            this.dynamicListValueType.Add(33.135464644444686);
            this.dynamicListValueType.Add(44);

            bool expectedResult = false;

            Assert.AreEqual(expectedResult, this.dynamicListValueType.Contains(55),
                "The contains method doesn't return the right value when given element not contained in the list");
        }
    }
}