using System;

namespace DataStructureLinkedList
{
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List");
            LinkedList linkedList = new LinkedList();
            /// Adding elements into linkedlist and 
            /// printing all elements
            linkedList.InsertElemetAtEnd(56);
            linkedList.InsertElemetAtEnd(30);
            linkedList.InsertElemetAtEnd(70);
            linkedList.Display();

            /// Deleting element in linked list 
            /// then, finding the size and,
            /// printing all elements
            Console.WriteLine("----------------------------");
            linkedList.DeleteNodeAtGivenPosition(30);
            Console.WriteLine(linkedList.Size());
            linkedList.Display();
        }
    }
}
