
namespace Algorithms.ArrayHelper
{
    public enum Side
    {
        LEFT,
        RIGHT
    }

    public static class SplitArray
    {
        public static int GetHalfSize(this int[] array, Side side = Side.LEFT)
        {
            if (array == null) throw new ArgumentNullException("Array cannot be null!");

            int n = array.Length;

            if (n <= 1)
                return 1;

            double half = GetHalf(n);

            int sideSize = side == Side.LEFT ?
                (int)Math.Ceiling(half)
                :
                (int)Math.Floor(half);


            return sideSize;
        }

        private static double GetHalf(int size)
        {
            return (double)size / 2.00;
        }
    }
}
