using System;
namespace AdvancedConcepts
{
    public class BSTree
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
        }

        static BSTNode InsertData(BSTNode head,int data)
        {
            if(head==null)
            {
                BSTNode temp = new BSTNode(data);
                head = temp;
                return head;
            }

            if(head.data >=data)
            {
                head.left = InsertData(head.left, data);
            }
            if(head.data <data)
            {
                head.right = InsertData(head.right, data);
            }

            return head;
        }

        static void PrintTree(BSTNode head)
        {
            if(head==null)
            {
                return;
            }
            PrintTree(head.left);
            Console.WriteLine($"{head.data}");
            PrintTree(head.right);
        }

        static bool FindInBST(int num,BSTNode head)
        {
            if(head==null)
            {
                return false;
            }
            if(head.data==num)
            {                
                return true;
            }
            else
            {
                if(head.data >= num)
                {
                    return FindInBST(num, head.left);
                }
                else
                {
                    return FindInBST(num, head.right);
                }
            }
        }

        static BSTNode DeleteData(BSTNode head,int data)
        {
            if (head==null)
            {
                return head;
            }
            else if(head.data> data)
            {
                    head.left=DeleteData(head.left, data);
            }
            else if(head.data < data)
            {
                    head.right=DeleteData(head.right, data);
            }
            else
            {
                //found the value
                // case 1: no child               
                if(head.left==null && head.right==null)
                {
                    head = null;
                }
                // case 2: one child
                else if(head.left==null)
                {
                    BSTNode temp=head;
                    head = head.right;
                    temp = null;
                }
                else if(head.right==null)
                {
                    BSTNode temp = head;
                    head = head.left;
                    temp = null;
                }
                // case 3: two child
                else
                {
                    BSTNode temp = FindMin(head.right);
                    head.data = temp.data;
                    head.right=DeleteData(head.right, head.data);
                }

            }
            return head;
        }

        static BSTNode FindMin(BSTNode bST)
        {
            while(bST.left!=null)
            {
                bST = bST.left;
            }
            return bST;
        }

        static int FindMaxVal(BSTNode bST)
        {
            while(bST.right!=null)
            {
                bST = bST.right;
            }
            return bST.data;
        }

        static int FindMinVal(BSTNode bST)
        {
            while(bST.left!=null)
            {
                bST = bST.left;
            }
            return bST.data;
        }

        static void FindEvenNode(BSTNode bST)
        {            
            if(bST!=null)
            {
                if(bST.data%2==0)
                {
                    Console.WriteLine($"{bST.data}");
                }
                FindEvenNode(bST.left);
                FindEvenNode(bST.right);
            }
        }

        //public static void Main(string[] args)
        //{
        //    BSTNode head = null;

        //    //head = InsertData(head, 1);
        //    //head = InsertData(head, 23);
        //    //head = InsertData(head, 54);
        //    //head = InsertData(head, 78);
        //    //head = InsertData(head, 99);
        //    //head = InsertData(head, 39);
        //    //head = InsertData(head, 45);
        //    //head = InsertData(head, 77);

        //    head = InsertData(head, 5);
        //    head = InsertData(head, 3);
        //    head = InsertData(head, 2);
        //    head = InsertData(head, 4);
        //    head = InsertData(head, 7);
        //    head = InsertData(head, 6);
        //    head = InsertData(head, 8);

        //    Console.WriteLine("The BST:");
        //    PrintTree(head);
        //    /*Console.WriteLine("Find the number to find in tree");
        //    var num=Console.ReadLine();s

        //    var isfound=FindInBST(Convert.ToInt32(num),head);
        //    if(isfound)
        //    {
        //        Console.WriteLine(" Number Found");
        //    }
        //    else
        //        Console.WriteLine(" Number not Found"); */
        //    //PrintTree(head);

        //    /* Console.WriteLine("Enter the number to be deleted");
        //     var num = Console.ReadLine();

        //     head=DeleteData(head, Convert.ToInt32(num));
        //     Console.WriteLine("After deletion, BST:");
        //     PrintTree(head); */

        //    /* int min = FindMinVal(head);
        //    int max = FindMaxVal(head);

        //    Console.WriteLine($"Min & Max Sum:{min+max}");
        //    Console.WriteLine($"Min & Max Product:{min*max}"); */

        //    Console.WriteLine("Even node in the tree:");
        //    FindEvenNode(head);
        //}
    }
}
