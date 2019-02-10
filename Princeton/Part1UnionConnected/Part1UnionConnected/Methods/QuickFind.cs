using System;

namespace Part1UnionConnected
{
    /// <summary>
    /// Class QuickFind.
    /// Implements the <see cref="Part1UnionConnected.IAlgorithms" />
    /// </summary>
    /// <seealso cref="Part1UnionConnected.IAlgorithms" />
    public class QuickFind : BaseMethod
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickFind"/> class.
        /// </summary>
        /// <param name="N">The n.</param>
        public QuickFind(int N) : base(N)
        {
            Console.WriteLine("Quick Find");
            Console.WriteLine();
        }

        /// <summary>
        /// Determines whether the specified a is connected.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns><c>true</c> if the specified a is connected; otherwise, <c>false</c>.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public override  bool IsConnected(int a, int b)
        {
            if (a >= ids.Length || a < 0 || b >= ids.Length || b < 0)
                return false;

            return ids[a] == ids[b];
        }

        /// <summary>
        /// Unions the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public override void Union(int a, int b)
        {
            if (a >= ids.Length || a < 0 || b >= ids.Length || b < 0)
                return;

            var aIndex = ids[a];
            var bIndex = ids[b];

            for (var i = 0; i < ids.Length; i++)
            {
                if (ids[i] == bIndex)
                    ids[i] = aIndex;
            }
        }
    }
}
