using Algorithms.ArrayHelper;

namespace Algorithms.Sorting
{
    public static class SelectiveSorting
    {
        //Simple sorting where on each element
        //program trying to find smallest end if find swap them
        //it's unstable
        //but speed is optimal
        //good for sorting primitive values
        public static int[] SelectiveSort(this int[] array)
        {
            if (array == null)
                throw new ArgumentNullException("Array is null!");

            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                        minIndex = j;
                    Counter.CounterValue++;

                }
                array.Swap(minIndex, i);

                Counter.CounterValue++;

            }

            return array;
        }
    }
}
