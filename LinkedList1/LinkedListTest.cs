using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DataStructureLinkedList;

namespace LinkedList1
{
    [TestClass]
    public class LinkedListTest
    {
        private readonly LinkedList linkedList;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListTest"/> class.
        /// </summary>
        public LinkedListTest()
        {
            linkedList = new LinkedList();
        }

        /// <summary>
        /// Givens the existing element to search should return boolean.
        /// </summary>
        [TestMethod]
        public void GivenExistingElementToSearch_ShouldReturnIntgerIndexValue()
        {
            /// Arrange
            int expected = 1;

            /// Act
            linkedList.InsertElemetAtEnd(56);
            linkedList.InsertElemetAtEnd(30);
            linkedList.InsertElemetAtEnd(70);
            int actual = linkedList.SearchKey(30);

            /// Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Givens the not existing element to search should return boolean value.
        /// </summary>
        [TestMethod]
        public void GivenNotExistingElementToSearch_ShouldReturnIntegerIndexValue()
        {
            /// Arrange
            int expected = -1;

            /// Act
            linkedList.InsertElemetAtEnd(56);
            linkedList.InsertElemetAtEnd(30);
            linkedList.InsertElemetAtEnd(70);
            int actual = linkedList.SearchKey(80);

            /// Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
