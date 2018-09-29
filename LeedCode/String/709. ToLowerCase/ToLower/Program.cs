//https://leetcode.com/problems/to-lower-case/description/

using System;
using System.Text;

namespace ToLower
{
    /// <summary>
    /// Programm
    /// </summary>
    class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            var solution = new Solution();

            Console.WriteLine(solution.ToLowerCase("Hello World!"));
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Solution
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// To the lower case.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public string ToLowerCase(string str)
        {
            if (str == null)
                return string.Empty;

            var builder = new StringBuilder();
            for(var i = 0; i < str.Length; i++)
            {
                var charInt = (int)str[i];
                ////http://www.asciitable.com/
                if (charInt >= 65 && charInt <= 90)
                    builder.Append((char) (charInt + 32));
                else
                    builder.Append(str[i]);
            }
            return builder.ToString();
        }
    }
}
