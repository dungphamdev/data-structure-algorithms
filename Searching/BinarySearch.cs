namespace Datastruct.Lib.Searching
{
    public partial class Searching
    {
        public static int BinarySearch(int x, int[] arr)
        {
            var left = 0;
            var right = arr.Length;
            var index = -1;

            while (left <= right)
            {
                var mid = (left + right) / 2;

                if (x == arr[mid]) return mid;

                if (x > arr[mid])
                {
                    left = mid + 1;
                }
                else if (x < arr[mid])
                {
                    right = mid - 1;
                }
            }

            return index;
        }
    }
}
