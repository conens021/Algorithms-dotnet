using Algorithms.ArrayHelper;

namespace Algorithms.Sorting
{
    //Not a best sorting algorithm in terms of performance
    //But its a litle more efficient then selective and bubble sort
    //Its stable sort
    static class InsertionSorting
    {
        public static int[] InsertionSort(this int[] array)
        {
            int n = array.Length;

            if (n <= 1) return array;

            for (int i = 1; i < n; i++)
            {
                int temp = array[i];
                int curr = i;
                
                while (curr > 0 && array[curr - 1] > temp)
                {
                    array[curr] = array[curr - 1];
                    curr--;
                    Counter.CounterValue++;
                }

                array[curr] = temp;
                Counter.CounterValue++;
            }

            return array;
        }
    }
}
