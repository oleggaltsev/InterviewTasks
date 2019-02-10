using System;

namespace Part1UnionConnected
{
    public class AlgFactory : IAlgorithms
    {
        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>The number.</value>
        private int number { get; set; }

        /// <summary>
        /// Gets or sets the method.
        /// </summary>
        /// <value>The method.</value>
        private Methods Method { get; set; }

        /// <summary>
        /// Gets or sets the algorithm.
        /// </summary>
        /// <value>The algorithm.</value>
        private IAlgorithms Algorithm { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlgFactory"/> class.
        /// </summary>
        /// <param name="method">The method.</param>
        /// <param name="N">The n.</param>
        public AlgFactory(Methods method, int N)
        {
            switch (method)
            {
                case Methods.QuickFind:
                    Algorithm = new QuickFind(N);
                    break;

                case Methods.QuickUnion:
                    Algorithm = new QuickUnion(N);
                    break;
            }
        }

        /// <summary>
        /// Determines whether the specified a is connected.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns><c>true</c> if the specified a is connected; otherwise, <c>false</c>.</returns>
        public bool IsConnected(int a, int b)
        {
            return Algorithm.IsConnected(a, b);
        }

        /// <summary>
        /// Unions the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public void Union(int a, int b)
        {
            Algorithm.Union(a, b);
        }

        /// <summary>
        /// Gets the ids.
        /// </summary>
        /// <returns>System.Int32[].</returns>
        public int[] GetIds()
        {
            return Algorithm.GetIds();
        }
    }
}