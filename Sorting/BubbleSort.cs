using Datastruct.Lib.Sorting;

public partial class Sorting
{
    static void BubbleSort(int[] a)
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] > a[j])
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }

                // sub print
                Console.WriteLine("---------------");
                Console.WriteLine($"Array in phase {i + 1}: i = {i}   j={j}");
                ArrayHelper.PrintArray(a);
            }

            // print array by phase
            Console.WriteLine($"Array after phase {i + 1}");
            ArrayHelper.PrintArray(a);
        }

        Console.WriteLine("result:");
        ArrayHelper.PrintArray(a);
    }

}