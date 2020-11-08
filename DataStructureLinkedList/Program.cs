using System;

namespace DataStructureLinkedList
{
    public class Program
    {
        /// <summary>
        /// Entry point of application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List");
            SortedLinkedList<int> sortedLinkedList = new SortedLinkedList<int>();
            /// Adding elements in to linkedlist
            sortedLinkedList.AddNode(56);
            sortedLinkedList.AddNode(30);
            sortedLinkedList.AddNode(40);
            sortedLinkedList.AddNode(70);

            sortedLinkedList.Display();
            /// sorting elemenst of list in ascendig order
            /// printing all elements
            sortedLinkedList.SortList();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Elements are Sorted in Ascending order");
            sortedLinkedList.Display();
        }
    }
}
