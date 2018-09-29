using System;
namespace QS
{
    /// <summary>
    /// 
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        private static void Main()
        {
            int[] arr = { 5, 2, 6, 4, 3};
            PrintArray("Input Array: ", arr);

            Sort(arr);
            PrintArray("My quick sort: ", arr);

            Array.Sort(arr);
            PrintArray("System Sort: ", arr);
            Console.ReadLine();
        }

        #region Helper Methods

        /// <summary>
        /// Quicks the sort.
        /// </summary>
        /// <param name="arr">The arr.</param>
        private static void Sort(int[] arr)
        {
            if (arr.Length == 0)
                return;

            QuickSort(arr, 0, arr.Length - 1);
        }

        /// <summary>
        /// Mies the quick sort.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="left">The first index.</param>
        /// <param name="right">The last index.</param>
        /// <param name="asc">if set to <c>true</c> [asc].</param>
        private static void QuickSort(int[] arr, int left, int right, bool asc = true)
        {
            if (left >= right)
                return;

            var pivot = arr[left + (right - left) / 2];
            var index = Partition(arr, left, right, pivot, asc);
            QuickSort(arr, left, index - 1, asc);
            QuickSort(arr, index, right, asc);
        }

        /// <summary>
        /// Partitions the specified .
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <param name="pivot">The pivot element.</param>
        /// <param name="asc">if set to <c>true</c> [asc].</param>
        /// <returns></returns>
        private static int Partition(int[] arr, int left, int right, int pivot, bool asc = true)
        {
            while (left <= right)
            {
                while (asc ? arr[left] < pivot : arr[left] > pivot)
                    left++;
                while (asc ? arr[right] > pivot : arr[right] < pivot)
                    right--;

                if (left <= right)
                {
                    Swap(arr, left, right);
                    left++;
                    right--;
                }
            }

            return left;
        }

        /// <summary>
        /// Swaps the specified arr.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        private static void Swap(int[] arr, int left, int right)
        {
            if (arr[left] == arr[right])
                return;

            var temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }

        /// <summary>
        /// Prints the array.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="arr">The arr.</param>
        private static void PrintArray(string title, int[] arr)
        {
            Console.WriteLine("");
            Console.WriteLine(title);
            Console.Write(string.Join(",", arr));
        }
        #endregion
    }
}
