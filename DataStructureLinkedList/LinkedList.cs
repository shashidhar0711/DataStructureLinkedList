using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureLinkedList
{
    public class LinkedList
    {
        public Node head;

        /// <summary>
        /// Addings the elements at front end.
        /// </summary>
        /// <param name="data">The data.</param>
        public void AddingElementsAtFrontEnd(int data)
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
        public void InsertElemetAtEnd(int data)
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
            Console.WriteLine("Inserted in to linked list {0} :" + node.data);
        }

        /// <summary>
        /// Deletes at front end.
        /// </summary>
        public void DeleteAtFrontEnd()
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
        /// Deletes at rear end.
        /// </summary>
        public void DeleteAtRearEnd()
        {
            if (head == null)
            {
                Console.WriteLine("Empty LinkedList");
                return;
            }
            else
            {
                Node temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }

                Console.WriteLine("Element deleted");
                temp.next = null;
            }
        }

        /// <summary>
        /// Searching the specified search key.
        /// </summary>
        /// <param name="searchKey">The search key.</param>
        /// <returns></returns>
        public bool SearchKey(int searchKey)
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                /// If data exist it will return count
                /// if dose not exist, it will return negative count ie -1
                if (temp.data == searchKey)
                {
                    //return count;
                    return true;
                }
                count++;
                temp = temp.next;
            }
            return false;
        }

        /// <summary>
        /// Searches the index key.
        /// </summary>
        /// <param name="searchKey">The search key.</param>
        /// <returns></returns>
        public int SearchIndexKey(int searchKey)
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                /// If data exist it will return count
                /// if dose not exist, it will return negative count ie -1
                if (temp.data == searchKey)
                {
                    return count;
                }
                count++;
                temp = temp.next;
            }
            return -1;
        }

        /// <summary>
        /// Inserts at particular position.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="newData">The new data.</param>
        public void InsertNode(int key, int newData)
        {
            int keyFound = SearchIndexKey(key);
            if (keyFound == -1)
            {
                Console.WriteLine("No such element {0} found ", key);
            }
            else
            {
                /// Creating a new node 
                Node newNode = new Node(newData);
                Node temp = head;
                for (int index = 1; index < keyFound; index++)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
            }
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
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
