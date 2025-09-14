// Program.cs
// Module 2 demos: Arrays & Strings + Grade Manager + console animations
// Paste into Programiz C# online compiler or into a .NET Console app and run.

using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    // -------------------------
    // Simple console animations
    // -------------------------
    static void TypeWrite(string text, int msPerChar = 15)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(msPerChar);
        }
        Console.WriteLine();
    }

    static void Spinner(int ms = 600)
    {
        char[] seq = new char[] { '|', '/', '-', '\\' };
        int steps = Math.Max(1, ms / 80);
        for (int i = 0; i < steps; i++)
        {
            Console.Write("\r" + seq[i % seq.Length] + " ");
            Thread.Sleep(80);
        }
        Console.Write("\r  \r");
    }

    static void ProgressBar(int percent, int width = 30)
    {
        int filled = (int)Math.Round(percent / 100.0 * width);
        Console.Write("[");
        Console.Write(new string('#', filled));
        Console.Write(new string('-', Math.Max(0, width - filled)));
        Console.Write($"] {percent}%\r");
    }

    static void Pause() {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }

    // -------------------------
    // Isolated Demos (bite-sized)
    // -------------------------
    static void Demo_WhileSimple()
    {
        Console.Clear();
        TypeWrite("Demo: while loop with user input (type 'exit' to stop)\n", 8);
        string input = "";
        while (input != "exit")
        {
            Console.Write("Enter text (or 'exit'): ");
            input = Console.ReadLine() ?? "";
            if (input != "exit")
                Console.WriteLine("You wrote: " + input);
        }
        TypeWrite("While loop ended.", 8);
        Pause();
    }

    static void Demo_CollectGradesUntilStop()
    {
        Console.Clear();
        TypeWrite("Demo: Collect grades until user types 'stop'\n", 8);
        List<int> grades = new List<int>();
        string input = "";
        while (true)
        {
            Console.Write("Enter grade (or 'stop'): ");
            input = Console.ReadLine() ?? "";
            if (input.Trim().ToLower() == "stop") break;
            if (int.TryParse(input, out int g))
            {
                grades.Add(g);
                Console.WriteLine("Added: " + g);
            }
            else Console.WriteLine("Not a valid number, try again.");
        }
        Console.WriteLine("\nAll grades: " + (grades.Count == 0 ? "(none)" : string.Join(", ", grades)));
        Pause();
    }

    static void Demo_ArrayFixedInput()
    {
        Console.Clear();
        TypeWrite("Demo: Fixed-size array input (3 entries)\n", 8);
        int[] grades = new int[3];
        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write($"Enter grade {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out grades[i]))
            {
                Console.Write("Invalid. Enter an integer: ");
            }
        }
        Console.WriteLine("You entered: " + string.Join(", ", grades));
        Pause();
    }

    static void Demo_SearchArray()
    {
        Console.Clear();
        TypeWrite("Demo: Linear search in an array\n", 8);
        string[] names = { "Vince", "Vina", "Yolo", "Mark", "Max" };
        Console.WriteLine("Names: " + string.Join(", ", names));
        Console.Write("Enter name to search: ");
        string search = Console.ReadLine() ?? "";
        bool found = false;
        foreach (string name in names)
        {
            if (name.Equals(search, StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                break;
            }
        }
        Console.WriteLine(found ? $"Found {search}." : $"{search} not found.");
        Pause();
    }

    static void Demo_StringsAsChars()
    {
        Console.Clear();
        TypeWrite("Demo: Strings as character sequences\n", 8);
        string word = "HELLO";
        Console.WriteLine("Word: " + word);
        Console.WriteLine("Characters:");
        foreach (char c in word)
            Console.WriteLine(c);
        Pause();
    }

    // -------------------------
    // Array Operations (explain + simulate insert/delete)
    // -------------------------
    static void Demo_ArrayOps()
    {
        Console.Clear();
        TypeWrite("Demo: Array operations - access, traversal, search, insert simulation, delete simulation\n", 8);

        int[] arr = { 10, 20, 30, 40 };
        Console.WriteLine("Initial array: " + string.Join(", ", arr));
        // Access O(1)
        Console.WriteLine("\nAccess arr[0] (O(1)): " + arr[0]);

        // Traversal O(n)
        Console.WriteLine("\nTraversal (O(n)):");
        foreach (int v in arr) Console.Write(v + " ");
        Console.WriteLine();

        // Search O(n)
        int key = 30;
        Console.WriteLine($"\nSearch for {key} (O(n)):");
        bool found = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key) { Console.WriteLine($"Found at index {i}"); found = true; break; }
        }
        if (!found) Console.WriteLine("Not found.");

        // Insert simulation -> create new array with extra slot (O(n))
        Console.WriteLine("\nInsert 5 at start (simulate unshift) (O(n)):");
        List<int> list = new List<int>(arr);
        list.Insert(0, 5);
        arr = list.ToArray();
        Console.WriteLine("After insert: " + string.Join(", ", arr));

        // Delete simulation -> remove index 2 (O(n))
        Console.WriteLine("\nRemove element at index 2 (simulate splice) (O(n)):");
        list.RemoveAt(2);
        arr = list.ToArray();
        Console.WriteLine("After delete: " + string.Join(", ", arr));

        Pause();
    }

    // -------------------------
    // 2D and Jagged array demos
    // -------------------------
    static void Demo_2DAndJagged()
    {
        Console.Clear();
        TypeWrite("Demo: 2D arrays (matrix) and jagged arrays\n", 8);

        // 2D
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
        Console.WriteLine("2D array (matrix):");
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
                Console.Write(matrix[r, c] + " ");
            Console.WriteLine();
        }

        // Jagged
        Console.WriteLine("\nJagged array:");
        int[][] jagged = new int[2][];
        jagged[0] = new int[] { 1, 2 };
        jagged[1] = new int[] { 3, 4, 5 };
        for (int i = 0; i < jagged.Length; i++)
        {
            Console.WriteLine("Row " + i + ": " + string.Join(", ", jagged[i]));
        }

        Pause();
    }

    // -------------------------
    // Master Grade Manager (capstone for Module 2)
    // interactive and demonstrates Big O points
    // -------------------------
    static void Demo_GradeManager()
    {
        Console.Clear();
        TypeWrite("=== Grade Manager (interactive) ===\n", 6);
        TypeWrite("This demo shows: access (O(1)), traversal/search (O(n)), nested combos (O(n^2))\n", 6);
        TypeWrite("You can choose to use sample data or enter your own.\n", 6);

        string[] sampleNames = { "Vince", "Vina", "Yolo", "Mark", "Max" };
        int[] sampleAges = { 20, 19, 21, 22, 20 };
        int[] sampleGrades = { 85, 90, 70, 88, 95 };

        Console.Write("Use sample data? (y/n): ");
        string useSample = (Console.ReadLine() ?? "y").Trim().ToLower();

        List<string> names = new List<string>();
        List<int> ages = new List<int>();
        List<int> grades = new List<int>();

        if (useSample == "y")
        {
            names.AddRange(sampleNames);
            ages.AddRange(sampleAges);
            grades.AddRange(sampleGrades);
        }
        else
        {
            // enter N students
            Console.Write("How many students? ");
            int n = 0;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) Console.Write("Enter a positive integer: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Name {i + 1}: ");
                names.Add(Console.ReadLine() ?? "");
                Console.Write($"Age {i + 1}: ");
                ages.Add(int.Parse(Console.ReadLine() ?? "0"));
                Console.Write($"Grade {i + 1}: ");
                grades.Add(int.Parse(Console.ReadLine() ?? "0"));
            }
        }

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Grade Manager Menu ===");
            Console.WriteLine("1. Show all students (Traversal O(n))");
            Console.WriteLine("2. Show first and last (Access O(1))");
            Console.WriteLine("3. Average, highest, lowest (O(n))");
            Console.WriteLine("4. Search by name (O(n))");
            Console.WriteLine("5. Add student (Insert simulation O(n))");
            Console.WriteLine("6. Delete student by index (Delete simulation O(n))");
            Console.WriteLine("7. Handshake pairs (O(n^2))");
            Console.WriteLine("8. Uppercase names (string op)");
            Console.WriteLine("9. Demo animation: Loading bar");
            Console.WriteLine("0. Exit to main menu");
            Console.Write("Choice: ");
            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\nAll students:");
                    for (int i = 0; i < names.Count; i++)
                    {
                        Console.WriteLine($"{i}: {names[i]} (Age {ages[i]}, Grade {grades[i]})");
                    }
                    Pause();
                    break;

                case "2":
                    if (names.Count == 0) Console.WriteLine("No students.");
                    else
                    {
                        Console.WriteLine("First: " + names[0]);
                        Console.WriteLine("Last: " + names[names.Count - 1]);
                    }
                    Pause();
                    break;

                case "3":
                    if (grades.Count == 0) { Console.WriteLine("No grades."); Pause(); break; }
                    int sum = 0;
                    int hi = grades[0], lo = grades[0];
                    foreach (int g in grades)
                    {
                        sum += g;
                        if (g > hi) hi = g;
                        if (g < lo) lo = g;
                    }
                    double avg = sum / (double)grades.Count;
                    Console.WriteLine($"Average: {avg:F2}, Highest: {hi}, Lowest: {lo}");
                    Pause();
                    break;

                case "4":
                    Console.Write("Enter name to search: ");
                    string sname = Console.ReadLine() ?? "";
                    bool found = false;
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (names[i].Equals(sname, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"Found at index {i}: {names[i]} (Age {ages[i]}, Grade {grades[i]})");
                            found = true;
                            break;
                        }
                    }
                    if (!found) Console.WriteLine("Not found.");
                    Pause();
                    break;

                case "5":
                    Console.Write("New student name: ");
                    names.Add(Console.ReadLine() ?? "");
                    Console.Write("Age: ");
                    ages.Add(int.Parse(Console.ReadLine() ?? "0"));
                    Console.Write("Grade: ");
                    grades.Add(int.Parse(Console.ReadLine() ?? "0"));
                    Console.WriteLine("Student added.");
                    Pause();
                    break;

                case "6":
                    Console.Write("Enter index to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int idx) && idx >= 0 && idx < names.Count)
                    {
                        names.RemoveAt(idx); ages.RemoveAt(idx); grades.RemoveAt(idx);
                        Console.WriteLine("Deleted.");
                    }
                    else Console.WriteLine("Invalid index.");
                    Pause();
                    break;

                case "7":
                    Console.WriteLine("\nHandshake pairs (each pair once):");
                    for (int i = 0; i < names.Count; i++)
                        for (int j = i + 1; j < names.Count; j++)
                            Console.WriteLine($"{names[i]} shakes hands with {names[j]}");
                    Pause();
                    break;

                case "8":
                    Console.WriteLine("\nUppercase names:");
                    foreach (string nm in names) Console.WriteLine(nm.ToUpper());
                    Pause();
                    break;

                case "9":
                    Console.WriteLine("\nLoading demonstration:");
                    for (int p = 0; p <= 100; p += 10)
                    {
                        ProgressBar(p);
                        Thread.Sleep(120);
                    }
                    Console.WriteLine();
                    Pause();
                    break;

                case "0":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    Pause();
                    break;
            }
        }
    }

    // -------------------------
    // Main menu (combines everything)
    // -------------------------
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Module 2: Arrays & Strings - Demos ===");
            Console.WriteLine("1. while-loop input demo");
            Console.WriteLine("2. collect numbers until 'stop'");
            Console.WriteLine("3. fixed-size array input");
            Console.WriteLine("4. linear search demo");
            Console.WriteLine("5. strings as chars demo");
            Console.WriteLine("6. array operations (access/traverse/search/insert/delete)");
            Console.WriteLine("7. 2D and jagged arrays");
            Console.WriteLine("8. Grade Manager (master demo - interactive)");
            Console.WriteLine("9. Quick animation: spinner");
            Console.WriteLine("0. Exit");
            Console.Write("Choose demo: ");
            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1": Demo_WhileSimple(); break;
                case "2": Demo_CollectGradesUntilStop(); break;
                case "3": Demo_ArrayFixedInput(); break;
                case "4": Demo_SearchArray(); break;
                case "5": Demo_StringsAsChars(); break;
                case "6": Demo_ArrayOps(); break;
                case "7": Demo_2DAndJagged(); break;
                case "8": Demo_GradeManager(); break;
                case "9": Spinner(800); Console.WriteLine("Done."); Pause(); break;
                case "0": TypeWrite("Exiting Module 2 demos. Goodbye!", 8); Thread.Sleep(300); return;
                default: Console.WriteLine("Invalid choice."); Pause(); break;
            }
        }
    }
}
