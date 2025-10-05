// using System;
// class Program
// {
//     static void Main()
//     {
//         string userinput = "";
//         Console.WriteLine("Yes or No?");
//         userinput = Console.ReadLine();

//         if (userinput == "Yes")
//         {
//             Yes();
//         }else if (userinput == "No")
//         {
//             No();
//         }

//     }

//     static void Yes()
//     {
//         Console.WriteLine("You said yes");
//     }

//     static void No()
//     {
//         Console.WriteLine("You said no");

//     }
// }



// using System;

// class Program
// {
//     static void Main()
//     {
//         Node first = new Node(10);
//         Node second = new Node(20);

//         first.Next = second;

//         Console.WriteLine(first.Data + " -> " + first.Next.Data);
//     }
// }

// class Node
// {
//     public int Data;
//     public Node? Next;

//     public Node(int data)
//     {
//         Data = data;
//         Next = null;
//     }
// }
// _____________________________________________________________
using System;
class Node
{
	public int Data;
	public Node? Next;

	public Node(int data)
	{
		Data = data;
		Next = null;
	}
}
class Program
{
	static void Main()
	{
		SinglyLinkedList list = new SinglyLinkedList();
		list.InsertAtEnd(10);
		list.InsertAtEnd(20);
		list.InsertAtEnd(30);

		list.Display();
		list.DeleteFirst();
		list.Display();
	}
}



class SinglyLinkedList
{
    private Node? head;

    public SinglyLinkedList()
    {
        head = null;
    }

    public void InsertAtEnd(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void Display()
    {
        Node? current = head;
        while (current != null)
        {
            Console.Write(current.Data);
            if (current.Next != null)
                Console.Write(" -> ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    public void DeleteFirst()
    {
        if (head != null)
        {
            head = head.Next;
        }
    }
}
//___________________________________________________________________

// using System;
// using System.Collections.Generic;


// class UndoRedoNamesDemo
// {
//     static void Main()
//     {
//         Stack<string> undo = new Stack<string>();
//         Stack<string> redo = new Stack<string>();

//         Console.Write("How many names do you want to enter? ");
//         if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
//         {
//             Console.WriteLine("Invalid number. Exiting.");
//             return;
//         }

//         for (int i = 1; i <= count; i++)
//         {
//             Console.Write($"Enter name #{i}: ");
//             string name = Console.ReadLine();
//             undo.Push(name);
//         }

//         Console.WriteLine("\nNames entered. You can now type 'undo', 'redo', 'show', or 'exit'.");
//         while (true)
//         {
//             Console.Write("\nCommand: ");
//             string input = Console.ReadLine()?.Trim().ToLower();

//             if (input == "exit")
//                 break;
//             else if (input == "undo")
//             {
//                 if (undo.Count > 0)
//                 {
//                     string name = undo.Pop();
//                     redo.Push(name);
//                     Console.WriteLine($"Undid: {name}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Nothing to undo.");
//                 }
//             }
//             else if (input == "redo")
//             {
//                 if (redo.Count > 0)
//                 {
//                     string name = redo.Pop();
//                     undo.Push(name);
//                     Console.WriteLine($"Redid: {name}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Nothing to redo.");
//                 }
//             }
//             else if (input == "show")
//             {
//                 Console.WriteLine($"Undo stack (names): [{string.Join(", ", undo)}]");
//                 Console.WriteLine($"Redo stack (names): [{string.Join(", ", redo)}]");
//             }
//             else
//             {
//                 Console.WriteLine("Unknown command. Type 'undo', 'redo', 'show', or 'exit'.");
//             }
//         }
//     }
// }

// simple example _________________
// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Stack<string> plates = new Stack<string>();

//         plates.Push("Plate 1");
//         plates.Push("Plate 2");
//         plates.Push("Plate 3");

//         Console.WriteLine("Top plate: " + plates.Peek());   // Look at top

//         Console.WriteLine("Removing: " + plates.Pop());     // Remove top
//         Console.WriteLine("Now top: " + plates.Peek());

//         Console.WriteLine("All plates left:");
//         foreach (string p in plates)
//         {
//             Console.WriteLine(p);
//         }
//     }
// }

// another simple example sa queues _________________

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Queue<string> line = new Queue<string>();

//         line.Enqueue("Alice");
//         line.Enqueue("Bob");
//         line.Enqueue("Charlie");

//         Console.WriteLine("First in line: " + line.Peek());   // Look at front

//         Console.WriteLine("Serving: " + line.Dequeue());      // Serve first
//         Console.WriteLine("Next in line: " + line.Peek());

//         Console.WriteLine("People still waiting:");
//         foreach (string person in line)
//         {
//             Console.WriteLine(person);
//         }
//     }
// }


