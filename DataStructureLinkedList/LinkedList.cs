using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureLinkedList
{
    public class LinkedList
    {
        internal Node head;

        /// <summary>
        /// Adds the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        internal void InsertNodeAtEnd(int data)
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
