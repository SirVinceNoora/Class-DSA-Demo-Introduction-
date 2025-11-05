// using System;

// class LinearSearch {
//     static int LinearSearchAlgo(int[] arr, int key) {
//         for (int i = 0; i < arr.Length; i++) {
//             if (arr[i] == key)
//                 return i; // Found
//         }
//         return -1; // Not found
//     }

//     static void Main() {
//         int[] numbers = { 12, 45, 67, 23, 89, 34 };
//         int key = 23;

//         int result = LinearSearchAlgo(numbers, key);

//         if (result != -1)
//             Console.WriteLine($"Element found at index {result}");
//         else
//             Console.WriteLine("Element not found.");
//     }
// }


// using System;

// class BinarySearch {
//     static int BinarySearchAlgo(int[] arr, int key) {
//         int low = 0, high = arr.Length - 1;

//         while (low <= high) {
//             int mid = (low + high) / 2;

//             if (arr[mid] == key)
//                 return mid;
//             else if (arr[mid] < key)
//                 low = mid + 1;
//             else
//                 high = mid - 1;
//         }
//         return -1;
//     }

//     static void Main() {
//         int[] numbers = { 10, 20, 30, 40, 50, 60, 70 };
//         int key = 50;

//         int result = BinarySearchAlgo(numbers, key);

//         if (result != -1)
//             Console.WriteLine($"Element found at index {result}");
//         else
//             Console.WriteLine("Element not found.");
//     }
// }


//_______________________________SORTING______________________________

////____________________________________________________USER INPUT AND SORTING OPTIONS(dont de-comment this line))
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("=== Sorting Algorithms in C# ===\n");

//         // Get user input array
//         Console.Write("Enter numbers separated by commas: ");
//         string input = Console.ReadLine();
//         int[] arr = Array.ConvertAll(input.Split(','), int.Parse);

//         // Display sorting options
//         Console.WriteLine("\nChoose a sorting algorithm:");
//         Console.WriteLine("[1] Bubble Sort");
//         Console.WriteLine("[2] Selection Sort");
//         Console.WriteLine("[3] Insertion Sort");
//         Console.WriteLine("[4] Quick Sort");
//         Console.WriteLine("[5] Merge Sort");
//         Console.WriteLine("[6] Heap Sort");
//         Console.Write("\nEnter your choice (1–6): ");
//         int choice = int.Parse(Console.ReadLine());

//         // Clone the array to avoid modifying original
//         int[] sortedArray = (int[])arr.Clone();

//         switch (choice)
//         {
//             case 1:
//                 BubbleSort(sortedArray);
//                 Console.WriteLine("\nSorted using Bubble Sort:");
//                 break;
//             case 2:
//                 SelectionSort(sortedArray);
//                 Console.WriteLine("\nSorted using Selection Sort:");
//                 break;
//             case 3:
//                 InsertionSort(sortedArray);
//                 Console.WriteLine("\nSorted using Insertion Sort:");
//                 break;
//             case 4:
//                 QuickSort(sortedArray, 0, sortedArray.Length - 1);
//                 Console.WriteLine("\nSorted using Quick Sort:");
//                 break;
//             case 5:
//                 MergeSort(sortedArray, 0, sortedArray.Length - 1);
//                 Console.WriteLine("\nSorted using Merge Sort:");
//                 break;
//             case 6:
//                 HeapSort(sortedArray);
//                 Console.WriteLine("\nSorted using Heap Sort:");
//                 break;
//             default:
//                 Console.WriteLine("Invalid choice!");
//                 return;
//         }

//         Console.WriteLine(string.Join(", ", sortedArray));
//     }
////____________________________________________________USER INPUT AND SORTING OPTIONS (dont de-comment this line))


    // ========================
    // Sorting Algorithms
    // ========================

    // Bubble Sort
//     static void BubbleSort(int[] arr)
//     {
//         for (int i = 0; i < arr.Length - 1; i++)
//         {
//             for (int j = 0; j < arr.Length - i - 1; j++)
//             {
//                 if (arr[j] > arr[j + 1])
//                 {
//                     int temp = arr[j];
//                     arr[j] = arr[j + 1];
//                     arr[j + 1] = temp;
//                 }
//             }
//         }
//     }

//     // Selection Sort
//     static void SelectionSort(int[] arr)
//     {
//         for (int i = 0; i < arr.Length - 1; i++)
//         {
//             int minIndex = i;
//             for (int j = i + 1; j < arr.Length; j++)
//             {
//                 if (arr[j] < arr[minIndex])
//                     minIndex = j;
//             }
//             int temp = arr[minIndex];
//             arr[minIndex] = arr[i];
//             arr[i] = temp;
//         }
//     }

//     // Insertion Sort
//     static void InsertionSort(int[] arr)
//     {
//         for (int i = 1; i < arr.Length; i++)
//         {
//             int key = arr[i];
//             int j = i - 1;
//             while (j >= 0 && arr[j] > key)
//             {
//                 arr[j + 1] = arr[j];
//                 j--;
//             }
//             arr[j + 1] = key;
//         }
//     }

//     // Quick Sort
//     static void QuickSort(int[] arr, int low, int high)
//     {
//         if (low < high)
//         {
//             int pi = Partition(arr, low, high);
//             QuickSort(arr, low, pi - 1);
//             QuickSort(arr, pi + 1, high);
//         }
//     }

//     static int Partition(int[] arr, int low, int high)
//     {
//         int pivot = arr[high];
//         int i = low - 1;
//         for (int j = low; j < high; j++)
//         {
//             if (arr[j] < pivot)
//             {
//                 i++;
//                 (arr[i], arr[j]) = (arr[j], arr[i]);
//             }
//         }
//         (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
//         return i + 1;
//     }

//     // Merge Sort
//     static void MergeSort(int[] arr, int left, int right)
//     {
//         if (left < right)
//         {
//             int mid = (left + right) / 2;
//             MergeSort(arr, left, mid);
//             MergeSort(arr, mid + 1, right);
//             Merge(arr, left, mid, right);
//         }
//     }

//     static void Merge(int[] arr, int left, int mid, int right)
//     {
//         int[] temp = new int[right - left + 1];
//         int i = left, j = mid + 1, k = 0;

//         while (i <= mid && j <= right)
//         {
//             if (arr[i] <= arr[j])
//                 temp[k++] = arr[i++];
//             else
//                 temp[k++] = arr[j++];
//         }

//         while (i <= mid) temp[k++] = arr[i++];
//         while (j <= right) temp[k++] = arr[j++];

//         for (i = left, k = 0; i <= right; i++, k++)
//             arr[i] = temp[k];
//     }

//     // Heap Sort
//     static void HeapSort(int[] arr)
//     {
//         int n = arr.Length;

//         for (int i = n / 2 - 1; i >= 0; i--)
//             Heapify(arr, n, i);

//         for (int i = n - 1; i >= 0; i--)
//         {
//             (arr[0], arr[i]) = (arr[i], arr[0]);
//             Heapify(arr, i, 0);
//         }
//     }

//     static void Heapify(int[] arr, int n, int i)
//     {
//         int largest = i;
//         int left = 2 * i + 1;
//         int right = 2 * i + 2;

//         if (left < n && arr[left] > arr[largest])
//             largest = left;
//         if (right < n && arr[right] > arr[largest])
//             largest = right;
//         if (largest != i)
//         {
//             (arr[i], arr[largest]) = (arr[largest], arr[i]);
//             Heapify(arr, n, largest);
//         }
//     }
// }
