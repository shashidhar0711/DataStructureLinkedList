using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructureLinkedList;

namespace LinkedListTest1
{
    [TestClass]
    public class LinkedTest
    {

        private readonly LinkedList linkedList;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListTest"/> class.
        /// </summary>
        public LinkedTest()
        {
            linkedList = new LinkedList();
        }

        /// <summary>
        /// UC7 Test Case 7.1
        /// Givens the existing element to search should return boolean.
        /// </summary>
        [TestMethod]
        public void GivenExistingElementToSearch_ShouldReturnBooleanValueTrue()
        {
            /// Arrange
            linkedList.InsertElemetAtEnd(56);
            linkedList.InsertElemetAtEnd(30);
            linkedList.InsertElemetAtEnd(70);

            /// Act
            bool actual = linkedList.SearchKey(30);

            /// Assert
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// UC7 Test Case 7.2
        /// Givens the not existing element to search should return boolean value.
        /// </summary>
        [TestMethod]
        public void GivenNotExistingElementToSearch_ShouldReturnBooleanValueFalse()
        {
            /// Arrange
            linkedList.InsertElemetAtEnd(56);
            linkedList.InsertElemetAtEnd(30);
            linkedList.InsertElemetAtEnd(70);

            /// Act
            bool actual = linkedList.SearchKey(80);

            /// Assert
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// UC8 Test Case 8.1
        /// Givens the element to insert in linkedist and need to search if exist it should return true.
        /// giving key value should insert at given index position
        /// </summary>
        [TestMethod]
        public void GivenElementToInsertInLinkedistAndNeedToSearch_IfExistItShouldReturnTrue()
        {
            /// Arrange
            linkedList.InsertElemetAtEnd(56);
            linkedList.InsertElemetAtEnd(30);
            linkedList.InsertElemetAtEnd(70);
            linkedList.InsertNode(70, 40);

            /// Act
            bool result = linkedList.SearchKey(40);

            /// Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// UC8 Test Case 8.2
        /// Givens the element to insert in linkedist and need to search if exist it should return false.
        /// giving key value should insert at given index position
        /// </summary>
        [TestMethod]
        public void GivenElementToInsertInLinkedistAndNeedToSearch_IfExistItShouldReturnFalse()
        {
            /// Arrange
            linkedList.InsertElemetAtEnd(56);
            linkedList.InsertElemetAtEnd(30);
            linkedList.InsertElemetAtEnd(70);
            linkedList.InsertNode(56, 40);

            /// Act
            bool result = linkedList.SearchKey(50);

            /// Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// UC9 Test Case 9.1
        /// Givens the element to insert in linkedist and need to find size it should returntrue.
        /// </summary>
        [TestMethod]
        public void GivenElementToInsertInLinkedistAndNeedToFindSize_ItShouldReturntrue()
        {
            /// Arrange
            int excepted = 3;
            linkedList.InsertElemetAtEnd(56);
            linkedList.InsertElemetAtEnd(30);
            linkedList.InsertElemetAtEnd(40);
            linkedList.InsertElemetAtEnd(70);
            linkedList.DeleteNodeAtGivenPosition(40);

            /// Act
            int result = linkedList.Size();

            /// Assert
            Assert.AreEqual(excepted, result);
        }

        /// <summary>
        /// UC9 Test Case 9.2
        /// Givens the element to insert in linkedist and need to find size it should return false.
        /// </summary>
        [TestMethod]
        public void GivenElementToInsertInLinkedistAndNeedToFindSize_ItShouldReturnFalse()
        {
            /// Arrange
            int excepted = 2;
            linkedList.InsertElemetAtEnd(56);
            linkedList.InsertElemetAtEnd(30);
            linkedList.InsertElemetAtEnd(40);
            linkedList.InsertElemetAtEnd(70);
            linkedList.DeleteNodeAtGivenPosition(40);

            /// Act
            int result = linkedList.Size();

            /// Assert
            Assert.AreEqual(excepted, result);
        }
    }
}
