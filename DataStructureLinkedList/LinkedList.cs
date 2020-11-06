using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureLinkedList
{
    class LinkedList
    {
        internal Node head;

        /// <summary>
        /// Inserts the node at end.
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
        /// Inserts the specified position.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        internal void InsertAtRandom(int position, int data)
        {
            Node node = new Node(data);

            if (position < 0)
            {
                Console.WriteLine("Not Possible to Add");
            }
            else if (position == 0)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;
                while (position > 1)
                {
                    temp = temp.next;
                    position--;
                }

                node.next = temp.next;
                temp.next = node;
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
