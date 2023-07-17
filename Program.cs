namespace cSharp_Complexity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch myStopWatch = new System.Diagnostics.Stopwatch();
            myStopWatch.Start();
            //int target = 3;
            //int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] == target)
            //    {
            //        Console.WriteLine(array[i]); // timer: 00:00:00.0080863
            //    }
            //}
            
            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 10;
            int l = 0, r = arr.Length - 1;
            int result = 4;
            if (result == -1)
                Console.WriteLine(
                    "Element is not present in array");
            else
                Console.WriteLine("Element is present at "
                                  + "index " + result);
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                // Check if x is present at mid
                if (arr[m] == x)
                    Console.WriteLine(m);
                    myStopWatch.Stop();
                // If x greater, ignore left half
                if (arr[m] < x)
                    l = m + 1;

                // If x is smaller, ignore right half
                else
                    r = m - 1;
            }

            // If we reach here, then element was
            // not present
            Console.WriteLine("-1");
            // time: 00:00:00.0071247

            Console.WriteLine(myStopWatch.Elapsed);
        }
    }
}