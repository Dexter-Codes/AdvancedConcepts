using System;
using System.Collections.Generic;

namespace AdvancedConcepts
{
    public class BipartiteGraphDFS
    {
        public static int V = 7;
        public static List<int>[] adj = new List<int>[V];
        public static int[] color = new int[V];
        public static bool[] visited=new bool[V];

        public static void AddEdge(List<int>[] vs,int u,int v)
        {
            vs[u].Add(v);
        }

        public static bool DFS(int x)
        {
            foreach(int y in adj[x])
            {
                if(!visited[y])
                {
                    visited[y] = true;
                    color[y] = 1 - color[x];
                    if (!DFS(y))
                        return false;

                }
                else if(color[y]==color[x])
                {
                    return false;
                }
            }
            return true;
        }


        //public static void Main()
        //{
        //    for(int i=0;i<V;i++)
        //    {
        //        adj[i] = new List<int>();
        //        color[i] = -1;
        //    }


        //    AddEdge(adj,0, 1);
        //    AddEdge(adj,0, 2);
        //    AddEdge(adj,1, 2);
        //    AddEdge(adj,2, 3);

        //    visited[2] = true;
        //    color[2] = 0;


        //    bool val=DFS(2);
        //    if(val)
        //    {
        //        Console.WriteLine("Graph is Bipartite");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Graph is not Bipartite");
        //    }    
        //}
    }
}
