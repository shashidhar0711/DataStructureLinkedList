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
            Console.WriteLine("Welcome to linked list");

            LinkedList linkedList = new LinkedList();

            /// Insert elements at end
            linkedList.InsertElemetAtEnd(56);
            linkedList.InsertElemetAtEnd(30);
            linkedList.InsertElemetAtEnd(70);

            /// Deleting the element at front end
            /// printing all element
            linkedList.DeleteAtFrontEnd();
            linkedList.Display();
        }
    }
}
