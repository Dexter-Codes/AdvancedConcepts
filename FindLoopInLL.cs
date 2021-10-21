using System;
using System.Collections.Generic;

namespace AdvancedConcepts
{
    public class FindLoopInLL
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
            temp.next = head;
            head = temp;
            return head;
        }

        static void PrintLL(Node node)
        {
            while(node!=null)
            {
                Console.WriteLine($"{node.data}");
                node = node.next;
            }
        }

        static bool FindLoop(Node node)
        {
            HashSet<Node> s = new HashSet<Node>();

            while (node!=null)
            {
                if(s.Contains(node.next))
                {
                    return true;
                }
                else
                {
                    s.Add(node.next);
                }
                node = node.next;
            }
            return false;
        }

        //public static void Main(string[] args)
        //{
        //    Node head=null;
        //    head=PushData(20,head);
        //    head = PushData(4, head);
        //    head = PushData(15, head);
        //    head = PushData(10, head);

        //    head.next.next.next = head;

        //    //PrintLL(head);

        //    var isloop=FindLoop(head);
        //    if(isloop)
        //    {
        //        Console.WriteLine("The LL has a loop");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No loop found");
        //    }
        //}

    }
}
