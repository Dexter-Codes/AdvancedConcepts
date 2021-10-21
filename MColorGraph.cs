using System;
using System.Collections.Generic;

namespace AdvancedConcepts
{
    //public class MColorGraph
    //{
    //    public static int V = 4;
    //    public static List<int>[] adj = new List<int>[V];
    //    public static int[] color = new int[V];
    //    public static bool[] visited = new bool[V];

    //    public static void AddEdge(List<int>[] vs, int u, int v)
    //    {
    //        vs[u].Add(v);
    //    }

    //   public static void ColorGraph(int m,int u)
    //   {
    //        //foreach (int v in adj[u])
    //        //{
    //        //    visited[u] = true;
    //        //    for (int i = 1; i <= m; i++)
    //        //    {
    //        //        color[u] = i;

    //        //        if (!visited[v])
    //        //            ColorGraph(m, v);

    //        //        if (!CheckSafeColor(u))
    //        //            color[u] = 0;
    //        //    }
    //        //}

    //        if (u == V)
    //        {

    //        }

    //        for (int i = 1; i <= m; i++)
    //        {
    //            color[i-1] = i;               
    //        }

    //    }

    //    public static bool CheckSafeColor(int u)
    //    {
    //        foreach(int v in adj[u])
    //        {
    //           if (color[u] == color[v])
    //           return false;
    //        }
    //        return true;
    //    }

    //    public static void PrintSolution()
    //    {
    //        for(int i=0;i<V;i++)
    //        {
    //            Console.WriteLine(" " + color[i]);
    //        }
    //    }

    //    public static void Main()
    //    {
    //        for (int i = 0; i < V; i++)
    //        {
    //            adj[i] = new List<int>();
    //            color[i] = 0;
    //        }

    //        int m = 3;

    //        AddEdge(adj, 0, 1);
    //        AddEdge(adj, 0, 2);
    //        AddEdge(adj, 0, 3);
    //        AddEdge(adj, 1, 2);
    //        AddEdge(adj, 2, 3);


    //        ColorGraph(m, 0);
    //          //  Console.WriteLine("Solution does not exist");

    //        PrintSolution();



    //    }
    //}



    class GFG
    {

        // Number of vertices in the graph
        static int V = 4;

        /* A utility function to print solution */
        static void printSolution(int[] color)
        {
            Console.WriteLine("Solution Exists:" +
                              " Following are the assigned colors ");
            for (int i = 0; i < V; i++)
                Console.Write("  " + color[i]);
            Console.WriteLine();
        }

        // check if the colored
        // graph is safe or not
        static bool isSafe(bool[,] graph, int[] color)
        {
            // check for every edge
            for (int i = 0; i < V; i++)
                for (int j = i + 1; j < V; j++)
                    if (graph[i, j] && color[j] == color[i])
                        return false;
            return true;
        }

        /* This function solves the m Coloring
        problem using recursion. It returns
        false if the m colours cannot be assigned,
        otherwise, return true and prints
        assignments of colours to all vertices.
        Please note that there may be more than
        one solutions, this function prints one
        of the feasible solutions.*/
        static bool graphColoring(bool[,] graph, int m,
                                  int i, int[] color)
        {
            // if current index reached end
            if (i == V)
            {

                // if coloring is safe
                if (isSafe(graph, color))
                {

                    // Print the solution
                    printSolution(color);
                    return true;
                }
                return false;
            }

            // Assign each color from 1 to m
            for (int j = 1; j <= m; j++)
            {
                color[i] = j;

                // Recur of the rest vertices
                if (graphColoring(graph, m, i + 1, color))
                    return true;

                color[i] = 0;
            }

            return false;
        }

        // Driver code 
    //    static void Main()
    //    {
    //        /* Create following graph and
    //        test whether it is 3 colorable
    //        (3)---(2)
    //        | / |
    //        | / |
    //        | / |
    //        (0)---(1)
    //        */
    //        bool[,] graph = {
    //    { false, true, true, true },
    //    { true, false, true, false },
    //    { true, true, false, true },
    //    { true, false, true, false },
    //};
    //        int m = 3; // Number of colors

    //        // Initialize all color values as 0.
    //        // This initialization is needed
    //        // correct functioning of isSafe()
    //        int[] color = new int[V];
    //        for (int i = 0; i < V; i++)
    //            color[i] = 0;

    //        if (!graphColoring(graph, m, 0, color))
    //            Console.WriteLine("Solution does not exist");
    //    }
    }

    // this code is contributed by divyeshrabadiya07.
}
