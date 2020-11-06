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
        internal void Add(int data)
        {
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

            if (temp == null)
            {
                Console.WriteLine("linkedlist is emty");
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
