using Algorithms.ArrayHelper;
using Algorithms.Sorting;

class SelectiveSorting
{
    public static void Main()
    {
        int[] numberArray = Populate(10000);

        //numberArray.PrintArray();

        var watch = System.Diagnostics.Stopwatch.StartNew();

        Sort(numberArray);

        //numberArray.PrintArray();

        watch.Stop();

        var elapsedMs = watch.ElapsedMilliseconds;
        if (elapsedMs < 1000)
        {
            Console.WriteLine($"Time : {elapsedMs}ms");
        }
        else
        {
            Console.WriteLine($"Time : {elapsedMs / 1000}s");
        }

        Console.WriteLine($"Counter : {Counter.CounterValue}");
    }

    public static void Sort(int[] array)
    {
        array.QuickSort();
        Console.WriteLine("Sorting finsihed");
    }

    public static int[] Populate(int length)
    {
        List<int> numbers = new List<int>();

        for (int i = length; i > 0; i--)
        {
            var rand = new Random();
            int randInt = rand.Next(1, 10001);
            numbers.Add(randInt);
        }
        Console.WriteLine("adding finish");

        int[] numberArray = numbers.ToArray();

        Console.WriteLine("Converting finished");


        return numberArray;
    }
}