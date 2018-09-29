using System;
using System.Collections.Generic;

namespace _2dMatrix
{
    /// <summary>
    /// Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            var inputValue = 5;

            var solution = new Solution();
            var arr = solution.PrettyPrint(inputValue);

            foreach (var arrRow in arr)
            {
                Console.WriteLine();
                foreach (var arrColumn in arrRow)
                {
                    Console.Write(arrColumn);
                }
            }
   
            Console.ReadLine();
        }
    }

    /// <summary>
    /// Solution
    /// </summary>
    class Solution
    {
        /// <summary>
        /// Pretties the print.
        /// </summary>
        /// <param name="A">a.</param>
        /// <returns></returns>
        public List<List<int>> PrettyPrint(int A)
        {
            var num = A * 2 - 1;
            var arr = new int[num, num];
            FillArray(0, A, arr);

            var result = new List<List<int>>();
            for (var i = 0; i < arr.GetLength(0); i++)
            {
                var list = new List<int>();
                for (var j = 0; j < arr.GetLength(0); j++)
                {
                    list.Add(arr[i,j]);
                }
                result.Add(list);
            }
            return result;
        }

        /// <summary>
        /// Fills the array.
        /// </summary>
        /// <param name="level">The level.</param>
        /// <param name="maxLevel">The maximum level.</param>
        /// <param name="arr">The arr.</param>
        private void FillArray(int level, int maxLevel, int[,] arr)
        {
            if (level >= maxLevel)
                return;
           
            var value = maxLevel - level;
            for (var i = level; i < arr.GetLength(0)-level; i++)
            {
                var leftAndTopCornerIndex = level;
                arr[leftAndTopCornerIndex, i] = value;
                arr[i, leftAndTopCornerIndex] = value;

                var rightAndButtomCornerIndex = arr.GetLength(0) - level - 1;
                arr[rightAndButtomCornerIndex, i] = value;
                arr[i, rightAndButtomCornerIndex] = value;
            }

            FillArray(level + 1, maxLevel, arr);
        }
    }
}
