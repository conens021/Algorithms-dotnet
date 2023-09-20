using Algorithms.ArrayHelper;

namespace Algorithms.Sorting
{
    public static class MergeSorting
    {
        public static void MergeSort(this int[] array)
        {
            if (array == null) throw new ArgumentNullException("Array cannot be null!");

            int n = array.Length;

            if (n <= 1) return;

            int midIndex = n / 2;

            int[] left = new int[midIndex];
            int[] right = new int[n - midIndex];

            for (int i = 0; i < midIndex; i++)
            {
                left[i] = array[i];
                Counter.CounterValue++;
            }

            for (int i = midIndex; i < n; i++)
            {
                right[i - midIndex] = array[i];
                Counter.CounterValue++;
            }

            MergeSort(left);
            MergeSort(right);

            MergeLists(array, left, right);
        }

        public static void MergeLists(int[] array, int[] left, int[] right)
        {
            int i = 0;
            int k = 0;
            int j = 0;

            while (k < left.Length && j < right.Length)
            {

                if (left[k] <= right[j])
                {
                    array[i] = left[k];
                    k++;
                }
                else
                {
                    array[i] = right[j];
                    j++;
                }

                i++;
                Counter.CounterValue++;
            }


            while (k < left.Length)
            {
                array[i] = left[k];
                k++;
                i++;
                Counter.CounterValue++;
            }

            while (j < right.Length)
            {
                array[i] = right[j];
                j++;
                i++;
                Counter.CounterValue++;
            }
        }
    }
}
