// int grade1 = 90;
// int grade2 = 85;
// int grade3 = 78;
// int grade4 = 92;
// int grade5 = 88;

// int[] grades = new int[5]; // creates an array of 5 integers
// grades[0] = 90; // first element
// grades[1] = 85;

// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine("Index " + i + " = " + numbers[i]);
// }
// int[,] grades = new int[2, 3]
// {
//     {90, 85, 88}, // Student 1
//     {75, 80, 95}  // Student 2
// };

// for (int i = 0; i < 2; i++) // students (rows)
// {
//     Console.Write("Student " + (i+1) + ": ");
//     for (int j = 0; j < 3; j++) // subjects (columns)
//     {
//         Console.Write(grades[i, j] + " ");
//     }
//     Console.WriteLine();
// }


// int[][] jaggedGrades = new int[3][];
// jaggedGrades[0] = new int[] {90, 85};        // Student 1 → 2 subjects
// jaggedGrades[1] = new int[] {75, 80, 95};    // Student 2 → 3 subjects
// jaggedGrades[2] = new int[] {60, 70, 85, 90}; // Student 3 → 4 subjects

// for (int i = 0; i < jaggedGrades.Length; i++)
// {
//     Console.Write("Student " + (i+1) + ": ");
//     for (int j = 0; j < jaggedGrades[i].Length; j++)
//     {
//         Console.Write(jaggedGrades[i][j] + " ");
//     }
//     Console.WriteLine();
// }

// foreach (int val in numbers)
// {
//     Console.WriteLine(val);
// }

// int[] arr = {1, 2, 3, 4, 0};
// int pos = 2; 
// int val = 99;

// for (int i = arr.Length-1; i > pos; i--)
//     arr[i] = arr[i-1];
// arr[pos] = val;

// int[] arr = {1, 2, 3, 4, 5};
// int pos = 2;

// for (int i = pos; i < arr.Length - 1; i++)
//     arr[i] = arr[i+1];

// int[] arr = {10, 20, 30, 40};
// int search = 30;
// bool found = false;

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] == search)
//     {
//         Console.WriteLine("Found at index " + i);
//         found = true;
//         break;
//     }
// }
// if (!found) Console.WriteLine("Not found");

// string word = "Hello";
// Console.WriteLine(word[0]);   // H
// Console.WriteLine(word.Length); // 5


// string word = "World";
// char[] letters = word.ToCharArray();

// foreach (char c in letters)
// {
//     Console.WriteLine(c);
// }
