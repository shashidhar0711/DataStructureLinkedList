using System;

namespace DataStructureLinkedList
{
    class Program
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
            linkedList.InsertNodeAtEnd(70);
            linkedList.InsertNodeAtEnd(30);

            /// Inserting element at given position
            /// printing all elements
            linkedList.InsertAtRandom(1,56);
            linkedList.Display();
        }
    }
}
