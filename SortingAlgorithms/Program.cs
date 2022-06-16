using AlgDs;

int arrayLength = 25;
int[] unsortedArray = new int[arrayLength];
int[] arrayCopy = new int[arrayLength];
int maxNum = 0;
int digits = 4;
int upperBound = (int)Math.Pow(10, digits - 1);
int radix = 10;

Random random = new Random();

for (int i = 0; i < unsortedArray.Length; i++)
{

    unsortedArray[i] = random.Next(1, upperBound);

    if (unsortedArray[i] > maxNum) 
        maxNum = unsortedArray[i];
}

//unsortedArray = new int[] {62, 11, 28, 62, 64, 57, 93, 13, 44, 17, 98, 55, 24, 40, 20, 5, 76, 70, 55, 98, 37, 83, 27, 4, 24};
Console.WriteLine("Unsortiert: ");
Array.ForEach(unsortedArray, i => Console.Write($"{i}, "));

Array.Copy(unsortedArray, arrayCopy, arrayLength);
InsertionSort.Sort(arrayCopy);
Console.WriteLine("\nSortiert Insertionsort: ");
Array.ForEach(arrayCopy, i => Console.Write($"{i}, "));

Array.Copy(unsortedArray, arrayCopy, arrayLength);
SelectionSort.Sort(arrayCopy);
Console.WriteLine("\nSortiert Selectionsort: ");
Array.ForEach(arrayCopy, i => Console.Write($"{i}, "));

Array.Copy(unsortedArray, arrayCopy, arrayLength);
MergeSort.Sort(arrayCopy, 0, unsortedArray.Length - 1);
Console.WriteLine("\nSortiert Mergesort: ");
Array.ForEach(arrayCopy, i => Console.Write($"{i}, "));

Array.Copy(unsortedArray, arrayCopy, arrayLength);
HeapSort.Sort(arrayCopy);
Console.WriteLine("\nSortiert Heapsort: ");
Array.ForEach(arrayCopy, i => Console.Write($"{i}, "));

Array.Copy(unsortedArray, arrayCopy, arrayLength);
QuickSort.Sort(arrayCopy, 0, unsortedArray.Length - 1);
Console.WriteLine("\nSortiert Quicksort: ");
Array.ForEach(arrayCopy, i => Console.Write($"{i}, "));

Array.Copy(unsortedArray, arrayCopy, arrayLength);
arrayCopy = CountingSort.Sort(arrayCopy, maxNum);
Console.WriteLine("\nSortiert Counting Sort: ");
Array.ForEach(arrayCopy, i => Console.Write($"{i}, "));

Array.Copy(unsortedArray, arrayCopy, arrayLength);
arrayCopy = RadixSort.Sort(arrayCopy, digits, radix);
Console.WriteLine("\nSortiert Radix Sort: ");
Array.ForEach(arrayCopy, i => Console.Write($"{i}, "));

Array.Copy(unsortedArray, arrayCopy, arrayLength);
Console.WriteLine("\n\nUnsortiert: ");
Array.ForEach(arrayCopy, i => Console.Write($"{i}, "));


/// <summary>
/// Data Structures
/// </summary>
Console.WriteLine("\n\n\n Data Structures:");
Console.WriteLine("Binary search tree:");
BinarySearchTree<int> tree = new BinarySearchTree<int>();
TreeNode<int> node = null;
Shuffler shuffler = new Shuffler();
List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
shuffler.Shuffle(list);

foreach(int i in list)
{
    node = new TreeNode<int>(i, random.Next(0, 100));
    tree.Insert(node);
    tree.PrintTreeInorder();
}

Console.WriteLine("\n"); 

foreach(int i in list)
{
    node = tree.Search(i);
    if (node != null)
    {
        tree.Delete(node);
        tree.PrintTreeInorder();
    }
}