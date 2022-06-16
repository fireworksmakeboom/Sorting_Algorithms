using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDs;
class HeapSort
{
    int[] heap;
    int heapLength;

    public HeapSort(int[] array)
    {
        heap = array;
        heapLength = array.Length;
    }
    public void Sort()
    {
        BuildMaxHeap();
        for (int i = heapLength; i > 0; i--, heapLength--)
        {
            int tempInt = heap[0];
            heap[0] = heap[i - 1];
            heap[i - 1] = tempInt;
            Max_Heapify(0);
        }
    }
    public static void Sort(int[] array)
    {
        new HeapSort(array).Sort();
    }
    public void BuildMaxHeap()
    {
        int LastRoot = heapLength / 2;

        for (int i = LastRoot; i >= 0; i--)
        {
            Max_Heapify(i);
        }
    }
    public int Left(int rootIndex) => rootIndex * 2 + 1;
    public int Right(int rootIndex) => rootIndex * 2 + 2;

    private void Max_Heapify(int rootIndex)
    {
        int leftIndex = Left(rootIndex);
        int rightIndex = Right(rootIndex);
        int max = rootIndex;

        if ((leftIndex < (heapLength - 1)) && heap[leftIndex] > heap[rootIndex])
        {
            max = leftIndex;
        }
        if ((rightIndex < (heapLength - 1)) && heap[rightIndex] > heap[max])
        {
            max = rightIndex;
        }
        if (max != rootIndex)
        {
            int tempInt = heap[max];
            heap[max] = heap[rootIndex];
            heap[rootIndex] = tempInt;

            Max_Heapify(max);
        }
    }
}

