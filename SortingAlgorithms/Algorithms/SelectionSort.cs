using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDs;
static class SelectionSort
{
    public static void Sort(int[] array)
    {
        // For every array element except the last
        for (int i = 0; i < array.Length - 1; i++)
        {
            int smallest = i;
            // Find the smallest element to the right of current index including current index
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[smallest])
                {
                    smallest = j;
                }
            }

            // If smallest index changed, change elements at current index with element at smallest index
            if (smallest != i)
            {
                int exchangeVar = array[i];
                array[i] = array[smallest];
                array[smallest] = exchangeVar;
            }
        }
    }
}

