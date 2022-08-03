﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class QueueLinkedList
    {
        Node head = null;

        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                //node.next = head;

            }
            Console.WriteLine("{0} inserted into queue ", node.data);

        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;

            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void Dequeue()
        {
            Node temp = this.head;
            if (temp.next == null)
            {
                this.head = null;
            }
            while (temp.next != null)
            {
                if (temp.next.next != null)
                {
                    temp = temp.next;
                }
                else
                {
                    temp.next = null;
                    break;
                }
            }
        }
    }
}
