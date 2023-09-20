namespace Algorithms.ArrayHelper
{
    public static class ArrayPrinter
    {
        public static void PrintArray(this int[] array)
        {
            Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    Console.Write(array[i] + ", ");

                }
                else
                {
                    Console.Write(array[i]);
                }
            }

            Console.WriteLine("}");
        }
    }
}
