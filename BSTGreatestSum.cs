using System;
namespace AdvancedConcepts
{
    public class BSTGreatestSum
    {
        public class BSTNode
        {
            public int data;
            public BSTNode left;
            public BSTNode right;

            public BSTNode(int x)
            {
                data = x;
                left = null;
                right = null;
            }

            static BSTNode InsertData(BSTNode head, int data)
            {
                if (head == null)
                {
                    BSTNode temp = new BSTNode(data);
                    head = temp;
                    return head;
                }

                if (head.data >= data)
                {
                    head.left = InsertData(head.left, data);
                }
                if (head.data < data)
                {
                    head.right = InsertData(head.right, data);
                }

                return head;
            }

            static void PrintTree(BSTNode head)
            {
                if (head == null)
                {
                    return;
                }
                PrintTree(head.left);
                Console.WriteLine($"{head.data}");
                PrintTree(head.right);
            }

            static void TransformTree(BSTNode node,int sum)
            {
                if(node==null)
                return ;

                TransformTree(node.right, sum);
                sum = sum + node.data;
                node.data = sum-node.data;
                TransformTree(node.left, sum);

            }

            //public static void Main(string[] args)
            //{
            //    BSTNode head = null;
            //    int sum = 0;
            //    head = InsertData(head, 5);
            //    head = InsertData(head, 3);
            //    head = InsertData(head, 2);
            //    head = InsertData(head, 4);
            //    head = InsertData(head, 7);
            //    head = InsertData(head, 6);
            //    head = InsertData(head, 8);

            //    Console.WriteLine("The BST:");
            //    PrintTree(head);

            //    TransformTree(head,sum);
            //    Console.WriteLine("The greatest sum BST:");
            //    PrintTree(head);
            //}
        }
    }
}
