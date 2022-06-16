using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDs;
static class RadixSort
{
    public static int[] Sort(int[] array, int highestDigit, int radix)
    {
        int[] sortedArray = new int[array.Length];
        int[] tempArray;

        for (int i = 0; i < highestDigit; i++)
        {
            CountingSort.DigitSort(array, sortedArray, i, radix);

            tempArray = sortedArray;
            sortedArray = array;
            array = tempArray;
        }

        return array;
    }
}
