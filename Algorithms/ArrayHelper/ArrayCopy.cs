
namespace Algorithms.ArrayHelper
{
    public static class ArrayCopy
    {
        public static int[] Copy2(this int[] destArray, int[] sourceArray, int fromIndex, int toIndex)
        {
            int counter = 0;

            for (int i = fromIndex, u = 0; i <= toIndex; i++, u++)
            {
                destArray[u] = sourceArray[i];

                counter++;

            }

            return destArray;
        }
    }
}
