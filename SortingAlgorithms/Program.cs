using Algorithms;

int[] unsortedArray = new int[25];
int[] arrayCopy = new int[25];

Random random = new Random();

for (int i = 0; i < unsortedArray.Length; i++)
{
    unsortedArray[i] = random.Next(1, 100);
}

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
Console.WriteLine("\n\nUnsortiert: ");
Array.ForEach(arrayCopy, i => Console.Write($"{i}, "));