// using System;
// using System.Collections.Generic;
// using System.Diagnostics;

// class Program
// {
//     // ========================
//     // Array Demo
//     // ========================
//     static void ArrayDemo()
//     {
//         Console.WriteLine("\n--- Arrays Demo ---");
//         int[] arr = { 10, 20, 30, 40 };
//         Console.WriteLine("Initial Array: " + string.Join(", ", arr));

//         var sw = Stopwatch.StartNew();
//         Console.WriteLine("Access First Element (O(1)): " + arr[0]);
//         sw.Stop();
//         Console.WriteLine($"Time: {sw.ElapsedTicks} ticks");

//         sw.Restart();
//         // Simulate "unshift" by inserting at the beginning
//         List<int> list = new List<int>(arr);
//         list.Insert(0, 5);
//         arr = list.ToArray();
//         sw.Stop();
//         Console.WriteLine("After unshift (insert at start): " + string.Join(", ", arr));
//         Console.WriteLine($"Time: {sw.ElapsedTicks} ticks");

//         sw.Restart();
//         // Simulate "splice" by removing index 2
//         list.RemoveAt(2);
//         arr = list.ToArray();
//         sw.Stop();
//         Console.WriteLine("After splice (remove index 2): " + string.Join(", ", arr));
//         Console.WriteLine($"Time: {sw.ElapsedTicks} ticks");

//         Console.WriteLine("👉 Notice: Arrays allow fast random access (O(1)), but inserting/removing at start/middle shifts elements (O(n)).");
//         Console.WriteLine("--- End of Array Demo ---\n");
//     }

//     // ========================
//     // Linked List Demo
//     // ========================
//     class Node
//     {
//         public int Data;
//         public Node Next;
//         public Node(int data) { Data = data; }
//     }

//     class LinkedList
//     {
//         public Node Head;

//         public void Append(int data)
//         {
//             Node newNode = new Node(data);
//             if (Head == null)
//             {
//                 Head = newNode;
//                 return;
//             }
//             Node temp = Head;
//             while (temp.Next != null)
//                 temp = temp.Next;
//             temp.Next = newNode;
//         }

//         public void Display()
//         {
//             Node temp = Head;
//             while (temp != null)
//             {
//                 Console.Write(temp.Data + " -> ");
//                 temp = temp.Next;
//             }
//             Console.WriteLine("null");
//         }
//     }

//     static void LinkedListDemo()
//     {
//         Console.WriteLine("\n--- Linked List Demo ---");
//         var ll = new LinkedList();
//         ll.Append(10);
//         ll.Append(20);
//         ll.Append(30);

//         var sw = Stopwatch.StartNew();
//         ll.Display();
//         sw.Stop();
//         Console.WriteLine($"Display Time: {sw.ElapsedTicks} ticks");

//         Console.WriteLine("👉 Notice: Each node stores data + pointer to the next node.");
//         Console.WriteLine("👉 Unlike arrays, there are no indexes. To find something, you must traverse from the head (O(n)).");
//         Console.WriteLine("--- End of Linked List Demo ---\n");
//     }

//     // ========================
//     // Stack Demo
//     // ========================
//     static void StackDemo()
//     {
//         Console.WriteLine("\n--- Stack Demo ---");
//         Stack<int> stack = new Stack<int>();

//         var sw = Stopwatch.StartNew();
//         stack.Push(1);
//         stack.Push(2);
//         stack.Push(3);
//         sw.Stop();
//         Console.WriteLine($"Push Operations (O(1)) in {sw.ElapsedTicks} ticks");
//         Console.WriteLine("Stack after pushes: " + string.Join(", ", stack));

//         sw.Restart();
//         int popped = stack.Pop();
//         sw.Stop();
//         Console.WriteLine($"Pop Operation (O(1)) in {sw.ElapsedTicks} ticks");
//         Console.WriteLine("Popped: " + popped);
//         Console.WriteLine("Stack now: " + string.Join(", ", stack));

//         Console.WriteLine("👉 Notice: Stack follows Last In, First Out (LIFO), like stacking plates.");
//         Console.WriteLine("--- End of Stack Demo ---\n");
//     }

//     // ========================
//     // Queue Demo
//     // ========================
//     static void QueueDemo()
//     {
//         Console.WriteLine("\n--- Queue Demo ---");
//         Queue<string> queue = new Queue<string>();

//         var sw = Stopwatch.StartNew();
//         queue.Enqueue("A");
//         queue.Enqueue("B");
//         queue.Enqueue("C");
//         sw.Stop();
//         Console.WriteLine($"Enqueue Operations (O(1)) in {sw.ElapsedTicks} ticks");
//         Console.WriteLine("Queue after enqueues: " + string.Join(", ", queue));

//         sw.Restart();
//         string removed = queue.Dequeue();
//         sw.Stop();
//         Console.WriteLine($"Dequeue Operation (O(1)) in {sw.ElapsedTicks} ticks");
//         Console.WriteLine("Dequeued: " + removed);
//         Console.WriteLine("Queue now: " + string.Join(", ", queue));

//         Console.WriteLine("👉 Notice: Queue follows First In, First Out (FIFO), like people in a waiting line.");
//         Console.WriteLine("--- End of Queue Demo ---\n");
//     }

//     // ========================
//     // Menu
//     // ========================
//     static void ShowMenu()
//     {
//         while (true)
//         {
//             Console.WriteLine("================================");
//             Console.WriteLine(" Select a Data Structure Demo ");
//             Console.WriteLine("================================");
//             Console.WriteLine("1. Arrays");
//             Console.WriteLine("2. Linked List");
//             Console.WriteLine("3. Stack");
//             Console.WriteLine("4. Queue");
//             Console.WriteLine("5. Exit");
//             Console.WriteLine("================================");
//             Console.Write("Enter choice: ");
//             string choice = Console.ReadLine();

//             switch (choice)
//             {
//                 case "1":
//                     ArrayDemo();
//                     break;
//                 case "2":
//                     LinkedListDemo();
//                     break;
//                 case "3":
//                     StackDemo();
//                     break;
//                 case "4":
//                     QueueDemo();
//                     break;
//                 case "5":
//                     Console.WriteLine("Exiting...");
//                     return;
//                 default:
//                     Console.WriteLine("Invalid choice, try again.");
//                     break;
//             }
//         }
//     }

//     static void Main()
//     {
//         ShowMenu();
//     }
// }

using System;

// class BigODemo
// {
//     static void Main()
//     {
//         int[] arr = new int[1000000];
//         for (int i = 0; i < arr.Length; i++) arr[i] = i;

//         // O(1) Access
//         Console.WriteLine("Access element at index 500000: " + arr[500000]);

//         // O(n) Traversal
//         int sum = 0;
//         foreach (int num in arr) sum += num;
//         Console.WriteLine("Sum of array: " + sum);
//     }
// }

// Example: storing student ages in an array

// int[] numbers = { 1, 2, 3, 4, 5 };

// Console.WriteLine("First element: " + numbers[0]); // O(1)
// Console.WriteLine("Last element: " + numbers[numbers.Length - 1]); // O(1)

// // Traversing all elements
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
// }



// int[] ages = { 18, 19, 20, 21, 22 };


// foreach (int age in ages)
// {
//     Console.WriteLine(age);
// }


// int[] numbers = { 1, 2, 3, 4, 5 };

// Console.WriteLine("First element: " + numbers[0]); 
// Console.WriteLine("Last element: " + numbers[numbers.Length - 1]); 


// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
// }

// class Node
// {
//     public string data;
//     public Node? left, right; // ✅ nullable children

//     public Node(string value)
//     {
//         data = value;
//         left = right = null;
//     }
// }

// class TreeDemo
// {
//     static void Main()
//     {
//         Node root = new Node("Root");
//         root.left = new Node("Left Child");
//         root.right = new Node("Right Child");

//         Console.WriteLine("Root: " + root.data);
//         Console.WriteLine("Left: " + root.left.data);
//         Console.WriteLine("Right: " + root.right.data);
//     }
// }

// using System.Collections.Generic;

// Stack<string> books = new Stack<string>();

// books.Push("Book 1");
// books.Push("Book 2");
// books.Push("Book 3");

// Console.WriteLine("Top of stack: " + books.Peek()); // Book 3
// Console.WriteLine("Removed: " + books.Pop()); // Book 3
// Console.WriteLine("Now top: " + books.Peek()); // Book 2
