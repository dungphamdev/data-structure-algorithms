namespace Datastruct.Lib.Searching
{
    public partial class Searching
    {
        public static int LinearSearch(int x, int[] arr)
        {
            var index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    index = i; break;
                }
            }

            return index;
        }
    }
}
