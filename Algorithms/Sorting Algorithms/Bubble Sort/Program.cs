using System;

namespace Sorting
{
    public class Bubble_Sort
    {
        static void Main(string[] args)
        {
           
        }

        public static void BubbleSort(int[] array)
        {
            for (int partIndex = array.Length-1;partIndex>0;partIndex--)
            {
                for (int i = 0; i <partIndex; i++)
                {
                    if (array[i] > array[i+1])
                    {
                        Swap(array, i, i+1);
                    }
                }
            }
            // this part is not part of the algorithm
            foreach (var item in array)
            {
                Console.WriteLine(item);
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
