namespace Datastruct.Lib.Sorting
{
    public partial class Sorting
    {
        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min]) min = j;
                }

                if (min != i)
                {
                    //swap i vs min
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }

                // print array by phase
                Console.WriteLine($"Array after phase {i + 1}");
                ArrayHelper.PrintArray(arr);
            }

            ArrayHelper.PrintArray(arr);
        }

    }
}
