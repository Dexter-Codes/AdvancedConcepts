using System;
namespace AdvancedConcepts
{
    public class InsertionToNode
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

        static Node PushData(int x,Node head)
        {
            Node temp = new Node(x);
            temp.next = head;
            head = temp;
            return head;
        }

        static Node InsertN(int x, int n, Node head)
        {
            Node temp1 = new Node(x);
            if(n==1)
            {
                temp1.next = head;
                head = temp1;
                return head;
            }
            if(head==null && n>1)
            {
                Console.WriteLine("Position not available currently for insertion");
                return head;
            }
            Node temp2=head;
            for(int i=1; i<n-1;i++)
            {
                if (temp2.next != null)
                {
                    temp2 = temp2.next;
                }
                else
                {
                    temp2.next = temp1;
                    return head;
                }
            }
            temp1.next = temp2.next;
            temp2.next = temp1;

            return head;
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

        //public static void Main(string[] args)
        //{
        //    Node head=null;

        //    /* head=PushData(7,head);

        //     head=PushData(9, head);

        //     head=PushData(23, head); */

        //    head = InsertN(4, 1, head);

        //    head = InsertN(20, 2,head);

        //    head = InsertN(34, 1, head);

        //    head = InsertN(67, 4, head);

        //    head = InsertN(15, 3, head);

        //    PrintNode(head);

        //}
    
    }
}
