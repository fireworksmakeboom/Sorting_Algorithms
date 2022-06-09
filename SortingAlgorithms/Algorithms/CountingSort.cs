using System;

namespace Algorithms;

static class CountingSort
{
    public static int[] Sort(int[] array, int highestValue)
    {
        int[] sortedArray = new int[array.Length];
        int[] valueArray = new int[highestValue + 1];

        for (int i = 0; i < valueArray.Length; i++)
        {
            valueArray[i] = 0;
        }
        for (int i = 0; i < array.Length; i++)
        {
            valueArray[array[i]]++;
        }
        for (int i = 1; i <= highestValue; i++)
        {
            valueArray[i] += valueArray[i - 1];
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            sortedArray[valueArray[array[i]] - 1] = array[i];
            valueArray[array[i]]--;
        }

        return sortedArray;
    }
}

