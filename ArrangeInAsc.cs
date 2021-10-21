using System;
namespace AdvancedConcepts
{
    public class ArrangeInAsc
    {
        public static void Main()
        {
            int[] temp = new int[10];

            for(int i=0;i<10;i++)
            {
                temp[i] = 100 - i;
            }

            SortArray(temp);
            PrintArray(temp);

        }

        static void PrintArray(int[] adj)
        {
            foreach (var item in adj)
            {
                Console.Write(" -> " + item);
            }
        }

        static void SortArray(int[] temp)
        {
            for(int i=0;i<temp.Length;i++)
            {
                for(int j=0;j< temp.Length; j++)
                {
                    if(temp[i]<temp[j])
                    {
                        int k = temp[j];
                        int l = temp[i];

                        temp[j] = l;
                        temp[i] = k;
                    }
                }
            }
        }
    }
}
