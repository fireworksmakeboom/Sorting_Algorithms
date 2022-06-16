using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDs;

static class QuickSort
{
    public static void Sort(int[] array, int p, int r)
    {
        if (p < r)
        {
            int q = Partition(array, p, r);
            Sort(array, p, q - 1);
            Sort(array, q + 1, r);
        }
    }

    private static int Partition(int[] array, int p, int r)
    {
        int x = array[r];
        int i = p - 1;
        int tempInt = 0;

        for (int j = p; j < r; j++)
        {
            if (array[j] <= x)
            {
                i++;

                tempInt = array[j];
                array[j] = array[i];
                array[i] = tempInt;
            }
        }
        tempInt = array[i + 1];
        array[i + 1] = array[r];
        array[r] = tempInt;

        return i + 1;
    }
}

