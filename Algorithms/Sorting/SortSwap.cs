namespace Algorithms.Sorting
{
    public static class ArraySwapItems
    {
        public static void Swap(this int[] array, int indexA, int indexB)
        {
            int tempA = array[indexA];

            array[indexA] = array[indexB];
            array[indexB] = tempA;
        }
    }
}
