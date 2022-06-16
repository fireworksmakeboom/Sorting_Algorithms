using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDs;
static class MergeSort
{
    public static void Sort(int[] array, int p, int r)
    {
        // Split the Arrays into subarrays (without actually creating arrays, just changing the index the algorithm looks at) until there is only one element
        // Single element arrays are automatically sorted
        // Visualization here: https://upload.wikimedia.org/wikipedia/commons/thumb/e/e6/Merge_sort_algorithm_diagram.svg/330px-Merge_sort_algorithm_diagram.svg.png
        if (p < r)
        {
            // calculate midpoint
            int q = p + (r - p) / 2;

            // recursively do array
            Sort(array, p, q);
            Sort(array, q + 1, r);

            // Merge sorted arrays
            Merge(array, p, q, r);
        }
    }

    private static void Merge(int[] array, int p, int q, int r)
    {
        // Create the left stacks array
        int leftLength = q - p + 1;
        int[] left = new int[leftLength];
        for (int k = 0; k < leftLength; k++)
        {
            left[k] = array[p + k];
        }

        // create right stacks array
        int rightLength = r - q;
        int[] right = new int[rightLength];
        for (int k = 0; k < rightLength; k++)
        {
            right[k] = array[q + 1 + k];
        }

        int i = 0;
        int j = 0;
        // Not from arrayIndex 0 but from the array index that the current subarray starts at (p)
        int arrayIndex = p;

        // While both stacks arent "empty"
        while (i < leftLength && j < rightLength)
        {
            // Take the smaller element and write it to the current array index. 
            // Raise the current arrayIndex and the index of the stack the element got taken off of by 1
            if (left[i] <= right[j])
            {
                array[arrayIndex] = left[i];
                i++;
            }
            else
            {
                array[arrayIndex] = right[j];
                j++;
            }
            arrayIndex++;
        }

        // After one stack is "empty" copy the rest of the other stack onto the main array to complete the merge.
        for (; i < leftLength; i++, arrayIndex++)
        {
            array[arrayIndex] = left[i];
        }

        for (; j < rightLength; j++, arrayIndex++)
        {
            array[arrayIndex] = right[j];
        }
    }
}

