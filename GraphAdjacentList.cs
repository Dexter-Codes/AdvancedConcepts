using System;
using System.Collections.Generic;

namespace AdvancedConcepts
{
    public class GraphAdjacentList
    {

        static void AddEdge(LinkedList<int>[] adj, int u,int v)
        {
            adj[u].AddLast(v);
            adj[v].AddLast(u);
        }

        static void PrintGraph(LinkedList<int>[] adj)
        {
            for (int i = 0; i < adj.Length; i++)
            {
                Console.WriteLine("\nAdjacency list of vertex " + i);
                Console.Write("head");

                foreach (var item in adj[i])
                {
                    Console.Write(" -> " + item);
                }
                Console.WriteLine();
            }
        }

       //public static void Main(string[] args)
       // {
       //     int V = 5;
       //     LinkedList<int>[] adj = new LinkedList<int>[V];


       //     for(int i=0;i<V;i++)
       //     {
       //         adj[i] = new LinkedList<int>();
       //     }

       //     AddEdge(adj, 0, 1);
       //     AddEdge(adj, 0, 4);
       //     AddEdge(adj, 1, 3);
       //     AddEdge(adj, 2, 4);
       //     AddEdge(adj, 2, 3);
       //     AddEdge(adj, 3, 4);
       //     AddEdge(adj, 1, 2);

       //     PrintGraph(adj);
       // }
    }
}
