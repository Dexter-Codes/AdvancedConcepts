using System;
using System.Collections.Generic;

namespace AdvancedConcepts
{
    public class GraphDFS
    {

        static void AddEdges(List<int>[] adj,int u,int v)
        {
            adj[u].Add(v);
            adj[v].Add(u);
        }

        static void dFS(List<int>[] adj,int x,bool[] visited)
        {
            visited[x] = true;
            Console.Write(x + " ");
            List<int> vadj = adj[x];
            foreach(var item in vadj)
            {
                if (!visited[item])
                    dFS(adj,item,visited);
            }
        }

        //public static void Main()
        //{
        //    int V = 7;
        //    List<int>[] adj = new List<int>[V];
        //    bool[] visited = new bool[V];

        //    for (int i=0;i<V;i++)
        //    {
        //        adj[i] = new List<int>();
        //    }

        //    AddEdges(adj, 0, 1);
        //    AddEdges(adj, 0, 2);
        //    AddEdges(adj, 1, 3);
        //    AddEdges(adj, 2, 4);
        //    AddEdges(adj, 3, 5);
        //    AddEdges(adj, 3, 9);
        //    AddEdges(adj, 4, 5);
        //    AddEdges(adj, 4, 6);


        //    dFS(adj,0,visited);
        //}
    }
}
