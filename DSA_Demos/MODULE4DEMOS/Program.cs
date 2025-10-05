
//_____________________TREE EXAMPLE _____________________   

// using System;

// class Node
// {
//     public int Data;
//     public Node Left;
//     public Node Right;

//     public Node(int data)
//     {
//         Data = data;
//         Left = Right = null;
//     }
// }

// class BinaryTree
// {
//     // Inorder Traversal (Left → Root → Right)
//     public void Inorder(Node root)
//     {
//         if (root == null) return;

//         Inorder(root.Left);
//         Console.Write(root.Data + " → ");
//         Inorder(root.Right);
//     }

//     // Preorder Traversal (Root → Left → Right)
//     public void Preorder(Node root)
//     {
//         if (root == null) return;

//         Console.Write(root.Data + " → ");
//         Preorder(root.Left);
//         Preorder(root.Right);
//     }

//     // Postorder Traversal (Left → Right → Root)
//     public void Postorder(Node root)
//     {
//         if (root == null) return;

//         Postorder(root.Left);
//         Postorder(root.Right);
//         Console.Write(root.Data + " → ");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Build TREE 1
//         Node root = new Node(8);
//         root.Left = new Node(3);
//         root.Right = new Node(10);
//         root.Left.Left = new Node(1);
//         root.Left.Right = new Node(6);
//         root.Left.Right.Left = new Node(4);
//         root.Left.Right.Right = new Node(7);
//         root.Right.Right = new Node(14);
//         root.Right.Right.Left = new Node(13);

//         BinaryTree tree = new BinaryTree();

//         Console.WriteLine("Inorder Traversal:");
//         tree.Inorder(root);
//         Console.WriteLine("END");

//         Console.WriteLine("\nPreorder Traversal:");
//         tree.Preorder(root);
//         Console.WriteLine("END");

//         Console.WriteLine("\nPostorder Traversal:");
//         tree.Postorder(root);
//         Console.WriteLine("END");
//     }
// }
//_____________________TREE EXAMPLE _____________________

//_____________________GRAPH EXAMPLE _____________________( this part of the lesson will have its own explaination module for the whole module)
using System;
using System.Collections.Generic;

class Graph
{
    // Dictionary where key = node, value = list of adjacent nodes (neighbors)
    private Dictionary<string, List<string>> adjList;

    public Graph()
    {
        // Initialize adjacency list when a new graph is created
        adjList = new Dictionary<string, List<string>>();
    }

    // Add a node (if you are not already in graph)
    public void AddNode(string node)
    {
        // Only add the node if it does not exist
        if (!adjList.ContainsKey(node))
        {
            adjList[node] = new List<string>();
        }
    }

    // Add a directed edge :p
    public void AddEdge(string from, string to)
    {
        // Ensure both nodes exist before adding an edge
        if (!adjList.ContainsKey(from)) AddNode(from);
        if (!adjList.ContainsKey(to)) AddNode(to);

        // Add 'to' node into adjacency list of 'from'
        adjList[from].Add(to);
    }

    // Depth-First Search (recursive) (make a snack if you are hungry)
    public void DFS(string start)
    {
        // Keep track of visited nodes so we don’t visit them twice
        HashSet<string> visited = new HashSet<string>();
        Console.Write("DFS Order: ");
        DFSHelper(start, visited);
        Console.WriteLine("END");
    }

    // Recursive DFS helper method
    private void DFSHelper(string node, HashSet<string> visited)
    {
        // Stop if node already visited
        if (visited.Contains(node)) return;

        // Visit the current node
        Console.Write(node + " → ");
        visited.Add(node);

        // Recursively visit all neighbors
        foreach (var neighbor in adjList[node])
        {
            DFSHelper(neighbor, visited);
        }
    }

    // Breadth-First Search (using queue) (drink water i guess)
    public void BFS(string start)
    {
        HashSet<string> visited = new HashSet<string>();  // Track visited nodes
        Queue<string> queue = new Queue<string>();        // Queue to control order of visiting

        // Start with the given node
        visited.Add(start);
        queue.Enqueue(start);

        Console.Write("BFS Order: ");
        while (queue.Count > 0)
        {
            // Remove from front of queue
            string node = queue.Dequeue();
            Console.Write(node + " → ");

            // Add all unvisited neighbors into the queue
            foreach (var neighbor in adjList[node])
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }
        }
        Console.WriteLine("END");
    }

    // Print adjacency list (you are learning keep going)
    public void PrintGraph()
    {
        Console.WriteLine("Adjacency List:");
        foreach (var node in adjList)
        {
            Console.Write(node.Key + " → ");
            Console.WriteLine(string.Join(", ", node.Value));
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Graph g = new Graph();

        // Build your graph (A–F) (almost there you can do it)
        g.AddEdge("A", "B");
        g.AddEdge("A", "C");
        g.AddEdge("B", "C");
        g.AddEdge("B", "D");
        g.AddEdge("B", "E");
        g.AddEdge("C", "E");
        g.AddEdge("E", "D");
        g.AddEdge("D", "F");
        g.AddEdge("E", "F");

        // Print adjacency list to visualize graph
        g.PrintGraph();

        // Run Depth-First Search starting at A
        g.DFS("A");

        // Run Breadth-First Search starting at A
        g.BFS("A");
    }
}
