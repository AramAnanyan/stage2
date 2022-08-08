using System;
using System.Linq;

namespace Merge_Sort
{
    class Program
    {
        public static void mergesort(int[] arr)
        {
            if (arr.Length < 2)
                return;
            int leftlength = arr.Length / 2;
            int[] leftarr = new int[leftlength];
            int[] rightarr = new int[arr.Length-leftlength];
            for(int i = 0; i < leftlength; i++)
            {
                leftarr[i] = arr[i];
            }
            for(int i = leftlength; i < arr.Length; i++)
            {
                rightarr[i - leftlength] = arr[i];
            }
            mergesort(leftarr);
            mergesort(rightarr);
            merge(leftarr, rightarr, arr);
        }
        public static void merge(int[] arr1, int[] arr2,int[] arr)
        {
            int l1 = arr1.Length;
            int l2 = arr2.Length;
            int l = arr.Length;
            int i = 0, j = 0, k = 0;
            while (i < l1 && j < l2)
            {
                if (arr1[i] < arr2[j])
                {
                    arr[k] = arr1[i];
                    i++;
                }else
                {
                    arr[k] = arr2[j];
                    j++;
                }
                k++;
            }
            while (i < l1)
            {
                arr[k] = arr1[i];
                i++;
                k++;
            }
            while (j < l2)
            {
                arr[k] = arr2[j];
                j++;
                k++;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3,9,5,3,6,8};
            mergesort(arr);
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
