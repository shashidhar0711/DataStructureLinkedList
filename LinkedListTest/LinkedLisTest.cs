using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DataStructureLinkedList;

namespace LinkedListTest
{
    [TestClass]
    public class LinkedLisTest
    {
        public readonly LinkedList linkedList = new LinkedList();

        /// <summary>
        /// Givens the element to insert in linkedist and need to search if exist it should return true.
        /// </summary>
        [TestMethod]
        public void GivenElementToInsertInLinkedistAndNeedToSearch_IfExistItShouldReturnTrue()
        {
            /// Arrange
            linkedList.InsertElemetAtEnd(56);
            linkedList.InsertElemetAtEnd(30);
            linkedList.InsertElemetAtEnd(70);

            /// giving key value should insert at given index position
            linkedList.InsertNode(70, 40);

            /// Act
            bool result = linkedList.SearchKey(40);

            /// Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Givens the element to insert in linkedist and need to search if exist it should return false.
        /// </summary>
        [TestMethod]
        public void GivenElementToInsertInLinkedistAndNeedToSearch_IfExistItShouldReturnFalse()
        {
            /// Arrange
            linkedList.InsertElemetAtEnd(56);
            linkedList.InsertElemetAtEnd(30);
            linkedList.InsertElemetAtEnd(70);

            /// giving key value should insert at given index position
            linkedList.InsertNode(56, 40);

            /// Act
            bool result = linkedList.SearchKey(50);

            /// Assert
            Assert.IsFalse(result);
        }
    }
}
