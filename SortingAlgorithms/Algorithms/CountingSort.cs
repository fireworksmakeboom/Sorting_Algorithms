using System;

namespace AlgDs;

static class CountingSort
{
    public static int[] Sort(int[] array, int highestValue)
    {
        int[] sortedArray = new int[array.Length];
        Sort(array, sortedArray, highestValue);
        return sortedArray;
    }

    public static void Sort(int[] inputArray, int[] outputArray, int highestValue)
    {
        int[] valueArray = new int[highestValue + 1];

        for (int i = 0; i < valueArray.Length; i++)
        {
            valueArray[i] = 0;
        }
        for (int i = 0; i < inputArray.Length; i++)
        {
            valueArray[inputArray[i]]++;
        }
        for (int i = 1; i <= highestValue; i++)
        {
            valueArray[i] += valueArray[i - 1];
        }

        for (int i = inputArray.Length - 1; i >= 0; i--)
        {
            outputArray[valueArray[inputArray[i]] - 1] = inputArray[i];
            valueArray[inputArray[i]]--;
        }
    }

    /// <summary>
    /// Counting Sort according to digits at position in base (radix)
    /// </summary>
    /// <param name="digit">position in int from the right starting at 0</param>
    /// <param name="radix">base of the number system used</param>
    public static void DigitSort(int[] inputArray, int[] outputArray, int digit, int radix)
    {
        int[] valueArray = new int[radix];
        int digitOfArray;

        for (int i = 0; i < valueArray.Length; i++)
        {
            valueArray[i] = 0;
        }
        for (int i = 0; i < inputArray.Length; i++)
        {
            // Calculates the digit of the number in the array by moving it right digit-times, then calculating mod base
            digitOfArray = (inputArray[i] / (int)Math.Pow(radix, digit)) % radix;
            valueArray[digitOfArray]++;
        }
        for (int i = 1; i < radix; i++)
        {
            valueArray[i] += valueArray[i - 1];
        }

        for (int i = inputArray.Length - 1; i >= 0; i--)
        {
            digitOfArray = (inputArray[i] / (int)Math.Pow(radix, digit)) % radix;
            outputArray[valueArray[digitOfArray] - 1] = inputArray[i];
            valueArray[digitOfArray]--;
        }
    }
}

