namespace Datastruct.Lib.Sorting
{
    public class ArrayHelper
    {
        public static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"a[{i}] = {a[i]} \t");
            }

            Console.WriteLine();
            Console.WriteLine("---------------");
        }
    }
}
