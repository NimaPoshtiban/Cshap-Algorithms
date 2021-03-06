using Algorithms.Sorting_Algorithms.BubbleSort;
using Algorithms.Sorting_Algorithms.SelectionSort;
using NUnit.Framework;
using System;

namespace Algorithms_Tests
{
    [TestFixture]
    public class SortingTests
    {
        private static int[][] Samples()
        {
            int[][] samples = new int[9][];
            samples[0] = new[] { 1 };
            samples[1] = new[] { 2, 1 };
            samples[2] = new[] { 2, 1, 3 };
            samples[3] = new[] { 1, 1, 1 };
            samples[4] = new[] { 2, -1, 3, 3 };
            samples[5] = new[] { 4, -5, 3, 3 };
            samples[6] = new[] { 0, -5, 3, 3 };
            samples[7] = new[] { 0, -5, 3, 0 };
            samples[8] = new[] { 3, 2, 5, 5, 1, 0, 7, 8 };

            return samples;
        }

        private void RunTestForSortingAlgorithm(Action<int[]> sort)
        {
            foreach (var sample in Samples())
            {
                sort(sample);
                CollectionAssert.IsOrdered(sample);
                PrintOut(sample);
            }
        }

        private static void PrintOut(int[] array)
        {
            TestContext.WriteLine("-----Trace-----\n");
            foreach (var element in array)
            {
                TestContext.Write(element + " ");
            }
            TestContext.WriteLine("\n-------------\n");
        }

        [Test]
        public void BubbleSort_ValidInput_SortedInput()
        {
            RunTestForSortingAlgorithm(BubbleSort.Bubble_Sort);
        }
        [Test]
        public void SelectionSort_ValidInput_SortedInput()
        {
            RunTestForSortingAlgorithm(SelectionSort.Selection_Sort);
        }
    }
}
