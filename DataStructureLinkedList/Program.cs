using System;

namespace DataStructureLinkedList
{
    class Program
    {
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

            /// Prints index by using search key operation
            Console.WriteLine("----------------------------");

            /// Adding the node at particular position and,
            /// printing all elements
            linkedList.InsertNode(70 ,40);
            linkedList.Display();
            
        }
    }
}
