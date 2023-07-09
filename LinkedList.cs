using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure_linkedlist
{
    internal class LinkedList
    {
        private Node head;
        public LinkedList() 
        {
            head = null;
        }
        public void Insert(int data)
        {
            Node newNode = new Node(data);
            // 1. empty linkedlist. Head is null
            if (head == null)
            {
                head = newNode;
            }
            //when items added to the end
            else
            {
                Node currentNode = head;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;

                }
                currentNode.next = newNode;
            }
        }
        public void display() 
        {
            Node node = head;
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }
    }
}
