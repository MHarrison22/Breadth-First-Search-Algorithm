using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BreadthFirstSearch
{
    public class BFS {         
        static void Main()
        {
            // Initialize the tree, see image for visual representation
            // Assumes nodes are added in order

            // Uses same tree as my depth first search algorithm example
            var t = new Tree();
            t.AddNode(1, 2);
            t.AddNode(1, 3);
            t.AddNode(2, 4);
            t.AddNode(3, 5);
            t.AddNode(3, 6);
            t.AddNode(4, 7);
            t.AddNode(5, 7);
            t.AddNode(5, 8);
            t.AddNode(5, 6);
            t.AddNode(8, 9);
            t.AddNode(8, 10);
            t.AddNode(9, 10);


            Console.WriteLine("Enter a node to search (1-10)");

            var query = int.Parse(Console.ReadLine());
            var timer = Stopwatch.StartNew();
            var queue = new Queue<KeyValuePair<int, HashSet<int>>>();

            Console.WriteLine();
            Console.WriteLine("Searching...");

            foreach (var m in t.NeighborList)
                queue.Enqueue(m);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.WriteLine(current.Key.ToString());
                if (current.Key == query)
                {
                    timer.Stop();
                    Console.WriteLine();
                    Console.WriteLine("Found: " + current.Key.ToString() + " in " + timer.ElapsedMilliseconds + "ms");
                    Console.ReadLine();
                    return;
                }
            }
        }
    }
}
