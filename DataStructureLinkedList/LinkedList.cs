using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureLinkedList
{
    public class LinkedList
    {
        internal Node head;

        /// <summary>
        /// Addings the elements at front end.
        /// </summary>
        /// <param name="data">The data.</param>
        internal void AddingElementsAtFrontEnd(int data)
        {
            /// Creating refrence of object class
            Node node = new Node(data);

            /// if head is null creating a new node
            if (head == null)
            {
                head = new Node(data);
                return;
            }

            /// if not, let node.next point to the same place where head is pointing
            /// then head is pointing where  node is pointing.
            node.next = head;
            head = node;
        }

        /// <summary>
        /// Inserts the elemet at end.
        /// </summary>
        /// <param name="data">The data.</param>
        internal void InsertElemetAtEnd(int data)
        {

            /// Creating reference of objec class
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node Temp = head;

                while (Temp.next != null)
                {
                    Temp = Temp.next;
                }

                Temp.next = node;
            }
            Console.WriteLine("{0} inserted in to linked list " + node.data);
        }

        /// <summary>
        /// Deletes at front end.
        /// </summary>
        internal void DeleteAtFrontEnd()
        {
            if (head == null)
            {
                Console.WriteLine(" Empty!!");
                return;
            }
            else
            {
                Node temp = head;
                head = head.next;
            }
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;

            /// If temp is null ,it gives linked is empty
            /// If not, it will prints upto condition meets
            if (temp == null)
            {
                Console.WriteLine("linkedlist is empty");
                return;
            }

            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
    }
}
