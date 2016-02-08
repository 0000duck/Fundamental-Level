using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01.LinkedQueue;

namespace LinkedQueue.Tests
{
    [TestClass]
    public class LinkedQueueTest
    {
        [TestMethod]
        public void TestQueueReturnsExpectedElement()
        {
            var linkedQueue = new LinkedQueue<int>();

            linkedQueue.Enqueue(5);

            var element = linkedQueue.Dequeue();

            Assert.AreEqual(5, element, "The queue does not contain the element.");
        }

        [TestMethod]
        public void TestQueueReturnsSeveralExpectedElements()
        {
            var linkedQueue = new LinkedQueue<int>();

            const int maxValue = 10;

            for (int i = 0; i < maxValue; i++)
            {
                linkedQueue.Enqueue(i);
            }

            for (int i = 0; i < maxValue; i++)
            {
                var element = linkedQueue.Dequeue();

                Assert.AreEqual(i, element, "The expected element is different from the actual one.");
            }
        }

        [TestMethod]
        public void TestQueueSeveralElementsCount()
        {
            var linkedQueue = new LinkedQueue<int>();

            const int maxValue = 1000;

            for (int i = 0; i < maxValue; i++)
            {
                linkedQueue.Enqueue(i);
            }

            Assert.AreEqual(maxValue, linkedQueue.Count, "The count is different than the expected one.");
        }

        [TestMethod]
        public void TestQueueSeveralElementsDequeueCount()
        {
            var linkedQueue = new LinkedQueue<int>();

            const int maxValue = 300;
            const int dequeueValue = 50;

            for (int i = 0; i < maxValue; i++)
            {
                linkedQueue.Enqueue(i);
            }

            for (int i = 0; i < dequeueValue; i++)
            {
                linkedQueue.Dequeue();
            }

            Assert.AreEqual(maxValue - dequeueValue, linkedQueue.Count, "The count is different than the expected one.");
        }

        [TestMethod]
        [ExpectedException(typeof (InvalidOperationException))]
        public void TestEqueueThrowsExceptionWhenEmpty()
        {
            var linkedQueue = new LinkedQueue<int>();

            var element = linkedQueue.Dequeue();

            Assert.IsNotNull(element, "The queue is empty.");
        }
    }
}