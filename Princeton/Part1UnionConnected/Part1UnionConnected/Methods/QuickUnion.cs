using System;

namespace Part1UnionConnected
{
    /// <summary>
    /// Class QuickUnion.
    /// Implements the <see cref="Part1UnionConnected.BaseMethod" />
    /// </summary>
    /// <seealso cref="Part1UnionConnected.BaseMethod" />
    public class QuickUnion : BaseMethod
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickUnion"/> class.
        /// </summary>
        /// <param name="N">The n.</param>
        public QuickUnion(int N) : base(N)
        {
            Console.WriteLine("Quick Union");
            Console.WriteLine();
        }

        /// <summary>
        /// Determines whether the specified a is connected.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns><c>true</c> if the specified a is connected; otherwise, <c>false</c>.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public override bool IsConnected(int a, int b)
        {
            return GetRoot(a) == GetRoot(b);
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

            var i = GetRoot(a);
            var j = GetRoot(b);
            if (i == j)
                return;

            ids[i] = j;
        }

        /// <summary>
        /// Gets the root.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <returns>System.Int32.</returns>
        private int GetRoot(int i)
        {
            while (i != ids[i])
                i = ids[i];

            return i;
        }
    }
}