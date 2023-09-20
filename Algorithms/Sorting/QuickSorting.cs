namespace Algorithms.Sorting
{
    public static class QuickSorting
    {
        public static void QuickSort(this int[] array)
        {
            int n = array.Length;

            if (n <= 1) return;

            array.Sort(0, n - 1);
        }

        private static void Sort(this int[] array, int start, int end)
        {
            if (start < end)
            {
                int pIndex = array.Partition(start, end);

                array.Sort(start, pIndex - 1);
                array.Sort(pIndex + 1, end);
            }
        }

        private static int Partition(this int[] array, int start, int end)
        {
            Random r = new();

            int pivotIndex = r.Next(start, end + 1);

            array.Swap(pivotIndex, end);

            int pivot = array[end];

            int pIndx = start;

            for (int i = start; i < end; i++)
            {
                if (array[i] <= array[end])
                {
                    array.Swap(i, pIndx);

                    pIndx++;
                }
            }

            array[end] = array[pIndx];
            array[pIndx] = pivot;


            return pIndx;
        }
    }
}
