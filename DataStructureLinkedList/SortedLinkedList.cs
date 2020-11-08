using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureLinkedList
{
    public class SortedLinkedList<T> where T : IComparable<T>
    {
        public Node<T> head = null;

        /// <summary>
        /// Node class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class Node<T>
        {
            public T data;
            public Node<T> next;

            /// <summary>
            /// Intialize a new Instance
            /// </summary>
            /// <param name="value"></param>
            public Node(T value)
            {
                data = value;
                next = null;
            }
        }

        /// <summary>
        /// Adding node in to linked list
        /// </summary>
        /// <param name="data"></param>
        public void AddNode(T data)
        {
            /// Create a new node  
            Node<T> newNode = new Node<T>(data);

            /// Checks if the list is empty  
            /// it it is empty this head node will point to newNode
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<T> temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                /// By adding new elements at the rear end and,
                /// temp.next will point to new node 
                temp.next = newNode;
            }
        }

        /// <summary>
        /// Sorting nodes of the list in ascending order  
        /// </summary>
        public void SortList()
        {
            /// Node temp will point to head  
            Node<T> temp = head;
            Node<T> tempTwo = null;

            if (head == null)
            {
                return;
            }
            else
            {
                while (temp != null)
                {
                    /// Node index will point to node next to temp  
                    tempTwo = temp.next;

                    while (tempTwo != null)
                    {
                        /// If temp data is greater than tempTwo data then,
                        /// swap the data
                        if (temp.data.CompareTo(tempTwo.data) > 0)
                        {
                            T tempVar = temp.data;
                            temp.data = tempTwo.data;
                            tempTwo.data = tempVar;
                        }
                        /// incrementing tempTwo
                        tempTwo = tempTwo.next;
                    }
                    /// incrementing temp
                    temp = temp.next;
                }
            }
        }

        /// <summary>
        /// Display all elements
        /// </summary>
        public void Display()
        {
            /// Node current will point to head  
            Node<T> temp = head;

            /// if does have elements it will prints or else 
            /// unable to print 
            if (head == null)
            {
                Console.WriteLine("List is empty unable to show");
                return;
            }
            while (temp != null)
            {
                /// Prints each node by incrementing temp  
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
