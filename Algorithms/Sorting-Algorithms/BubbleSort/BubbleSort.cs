using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting_Algorithms.BubbleSort
{
    public class BubbleSort
    {
        public static void Bubble_Sort(int[] array)
        {
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                for (int i = 0; i < partIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
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
