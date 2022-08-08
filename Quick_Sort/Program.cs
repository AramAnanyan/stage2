using System;

namespace Quick_Sort
{
    class Program
    {
        
        public static void swap(int[] arr, int a, int b)
        {
            int k = arr[a];
            arr[a] = arr[b];
            arr[b] = k;
        }
        public static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int j = low + 1;
            for (int i = low + 1; i <= high; i++)
            {
                if (arr[i] < pivot)
                {
                    swap(arr, i, j);
                    j++;

                }
            }
            swap(arr, j - 1, low);
            return j - 1;
        }
        public static void quicksort(int[] arr, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            int a = partition(arr, low, high);
            quicksort(arr, low, a-1);
            quicksort(arr, a+1, high);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 4, 6, 3, 7, 1, 8 ,12,0,2,15};
            quicksort(arr, 0, arr.Length-1);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
        }
    }
}
