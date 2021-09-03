using System;

namespace Algorithms_DataStruct_Lib
{
    public class Sorting
    {
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
