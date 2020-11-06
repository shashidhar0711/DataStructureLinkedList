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
            /// printing all elements
            linkedList.AddingElementsAtFrontEnd(70);
            linkedList.AddingElementsAtFrontEnd(30);
            linkedList.AddingElementsAtFrontEnd(56);
            linkedList.Display();
        }
    }
}
