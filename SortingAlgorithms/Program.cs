using Algorithms;

int[] unsortedArray = new int[25];
int[] arrayCopy = new int[25];
int maxNum = 0;

Random random = new Random();

for (int i = 0; i < unsortedArray.Length; i++)
{
    unsortedArray[i] = random.Next(1, 1000);

    if (unsortedArray[i] > maxNum) 
        maxNum = unsortedArray[i];
}

//unsortedArray = new int[] {62, 11, 28, 62, 64, 57, 93, 13, 44, 17, 98, 55, 24, 40, 20, 5, 76, 70, 55, 98, 37, 83, 27, 4, 24};

Console.WriteLine("Unsortiert: ");
Array.ForEach(unsortedArray, i => Console.Write($"{i}, "));

Array.Copy(unsortedArray, arrayCopy, 25);
InsertionSort.Sort(arrayCopy);
Console.WriteLine("\nSortiert Insertionsort: ");
Array.ForEach(arrayCopy, i => Console.Write($"{i}, "));

Array.Copy(unsortedArray, arrayCopy, 25);
SelectionSort.Sort(arrayCopy);
Console.WriteLine("\nSortiert Selectionsort: ");
Array.ForEach(arrayCopy, i => Console.Write($"{i}, "));

Array.Copy(unsortedArray, arrayCopy, 25);
MergeSort.Sort(arrayCopy, 0, unsortedArray.Length - 1);
Console.WriteLine("\nSortiert Mergesort: ");
Array.ForEach(arrayCopy, i => Console.Write($"{i}, "));

Array.Copy(unsortedArray, arrayCopy, 25);
HeapSort.Sort(arrayCopy);
Console.WriteLine("\nSortiert Heapsort: ");
Array.ForEach(arrayCopy, i => Console.Write($"{i}, "));

Array.Copy(unsortedArray, arrayCopy, 25);
QuickSort.Sort(arrayCopy, 0, unsortedArray.Length - 1);
Console.WriteLine("\nSortiert Quicksort: ");
Array.ForEach(arrayCopy, i => Console.Write($"{i}, "));

Array.Copy(unsortedArray, arrayCopy, 25);
arrayCopy = CountingSort.Sort(arrayCopy, maxNum);
Console.WriteLine("\nSortiert Counting Sort: ");
Array.ForEach(arrayCopy, i => Console.Write($"{i}, "));

Array.Copy(unsortedArray, arrayCopy, 25);
Console.WriteLine("\n\nUnsortiert: ");
Array.ForEach(arrayCopy, i => Console.Write($"{i}, "));

