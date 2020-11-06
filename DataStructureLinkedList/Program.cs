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

            /// Insert elements at position end 
            linkedList.InsertNodeAtEnd(56);
            linkedList.InsertNodeAtEnd(30);
            linkedList.InsertNodeAtEnd(70);

            /// Printing all the elements
            linkedList.Display();
        }
    }
}
