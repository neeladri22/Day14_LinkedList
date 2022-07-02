using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Linked lIst of 56, 30 and 70");
            Program program = new Program();
            Console.WriteLine("Creating linked list by adding Data in the First Position ");
            program.AddFirst(56);
            program.AddFirst(30);
            program.AddFirst(70);
            program.DiplayData();

        }
        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
            }
        }

        public Node head;

        public bool AddFirst(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                return true;
            }
            node.next = head;
            head = node;
            return true;
        }
        public void DiplayData()
        {
            if (head == null)
            {
                Console.WriteLine("Linkedlist data is Empty");
            }
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public bool AddLast(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                return true;
            }
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
            return true;
        }
    }
}
