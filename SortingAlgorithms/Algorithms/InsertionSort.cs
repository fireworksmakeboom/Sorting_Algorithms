using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms;
static class InsertionSort
{
    public static void Sort(int[] array)
    {
        // For every element of the array that is not the first array element
        for (int i = 1; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;

            // Go through every element to the left of the current index until smaller element is found and if element is bigger copy it one field to the right
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            // "Insert" key into found spot
            array[j + 1] = key;
        }
    }
}

