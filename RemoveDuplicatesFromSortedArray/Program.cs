using System;

namespace RemoveDuplicatesFromSortedArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array1 = new int[] { 1,1,1,2,2,3,4,5 };
            int size = RemoveDuplicates(array1);
        }

        public static int RemoveDuplicates(int[] arr)
        {
            int n = arr.Length;

            if (n == 0 || n == 1)
                return n;

            // To store index of next 
            // unique element 
            int j = 0;


            for (int i = 0; i < n - 1; i++)
                if (arr[i] != arr[i + 1])
                    arr[j++] = arr[i];

            arr[j++] = arr[n - 1];

            return j;
        }
    }
}
