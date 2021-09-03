using System;

namespace Sorting
{
    public class Selection_Sort
    {

        static void Main(string[] args)
        {
            int[] numbers = { 1, 4, 1, 34, 54, 12, 6, 88, 0 };
            SelectionSort(numbers);
        }

        public static void SelectionSort(int[] array)
        {
            for (int partIndex = array.Length-1; partIndex > 0; partIndex--)
            {
                int largestAt = 0;

                for (int i = 1; i <= partIndex; i++)
                {
                    if (array[i] > array[largestAt])
                    {
                        largestAt = i;
                    }
                }

                Swap(array,largestAt,partIndex);
            }

            // not related to algorithm
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
            {
                return;
            }
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
