using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureLinkedList
{
    class LinkedList
    {
        internal Node head;

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
