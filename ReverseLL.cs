using System;
namespace AdvancedConcepts
{
    public class ReverseLL
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int x)
            {
                data = x;
                next = null;
            }
        }

        static Node PushData(int x, Node head)
        {
            Node temp = new Node(x);
            Node temp2=null;
            if (head == null)
            {
                temp.next = head;
                head = temp;
                return head;
            }
            else
            {
                temp2 = head;
                while(temp2.next!=null)
                {
                    temp2 = temp2.next;
                }
                temp2.next = temp;
                return head;
            }
        }

        static void PrintNode(Node head)
        {
            Node temp = head;

            while (temp != null)
            {
                Console.WriteLine($"{temp.data}");
                temp = temp.next;
            }
        }

        static Node ReverseList(Node head)
        {
            Node current, prev=null, next=null;
            current = head;

            while(current!=null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;               
            }
            head = prev;
            return head;
        }

        //public static void Main(string[] args)
        //{
        //     Node head = null;

        //     head=PushData(7,head);

        //     head=PushData(9, head);

        //     head=PushData(23, head);

        //     head=PushData(99, head);

        //     head=PushData(55,head);

        //     Console.WriteLine($"Printing Linked List...");
        //     PrintNode(head);

        //     head=ReverseList(head);
        //     Console.WriteLine($"Printing Reverse Linked List...");
        //     PrintNode(head);

        //}
    }
}
