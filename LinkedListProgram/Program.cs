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
            Program p = new Program();
            p.AddLast(56);
            p.AddLast(70);

            // insert the 30 in 1st Index (between 56 and 70)
            p.Insert(1, 30);
            p.DiplayData();
            /*
            Program program = new Program();
            Console.WriteLine("Creating  Linked list by adding Data in the Last Position ");
            program.AddLast(56);
            program.AddLast(30);
            program.AddLast(70);
            program.DiplayData();
            
           Program program = new Program();
           Console.WriteLine("Creating  Linked list by adding Data in the First Position ");
           program.AddFirst(70);
           program.AddFirst(30);
           program.AddFirst(56);
           program.DiplayData();

           
           Console.WriteLine("Creating Linked lIst of 56, 30 and 70");
           Program program = new Program();
           Console.WriteLine("Creating linked list by adding Data in the First Position ");
           program.AddFirst(56);
           program.AddFirst(30);
           program.AddFirst(70);
           program.DiplayData();
           */
        }
        // Creating Node
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

        // Creting Method to Add data in First position in the Linked list
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

        // Creating Method to Display the data in Linked lIst
        public void DiplayData()
        {
            if (head == null)
            {
                Console.WriteLine("Linkedlist is Empty");
            }
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        // Creating method to add data in Last postion in the Linked list
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

        // Creating Method to Insert the data in the required index position in the Linked list
        public bool Insert(int ind, int data)
        {
            Node n = new Node(data);
            if (ind == 0)
            {
                n.next = head.next;
                head = n;
                return true;
            }
            Node t = head, pre = null;
            while (ind > 0 && t != null)
            {
                ind--;
                pre = t;
                t = t.next;
            }
            if (ind == 0)
            {
                pre.next = n;
                n.next = t;
                return true;
            }
            else
            {
                Console.WriteLine("Index is not in range");
                return false;
            }
        }
    }
}
