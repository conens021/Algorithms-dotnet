using Algorithms.ArrayHelper;

namespace Algorithms.Sorting
{
    public static class BubbleSorting
    {
        public static int[] BubbleSort(this int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                        array.Swap(j, j + 1);
                    Counter.CounterValue++;
                }
                Counter.CounterValue++;
            }

            return array;
        }

        public static int[] BubbleSortOpt(this int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swap = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        array.Swap(j, j + 1);
                        swap = true;
                    }
                    Counter.CounterValue++;


                }
                Counter.CounterValue++;

                if (!swap) break;
            }

            return array;
        }
    }
}
