using System;

namespace Part1UnionConnected
{
    /// <summary>
    /// Class Program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            var alg = new AlgFactory(Methods.QuickUnion, 10);
            //alg.Union(4, 3);
            //alg.Union(3, 8);
            //alg.Union(6, 5);
            //alg.Union(9, 4);
            //alg.Union(2, 1);
            //alg.Union(8, 9);
            //alg.Union(5, 0);
            //alg.Union(7, 2);
            //alg.Union(6, 1);

            alg.Union(4, 5);
            alg.Union(4, 3);
            alg.Union(2, 6);
            alg.Union(2, 0);
            alg.Union(5, 2);
            var ids = alg.GetIds();

            foreach (var i in ids)
            {
                Console.Write(i);
                Console.Write(" ");
            }

            ShowConnectedResult(alg, 0, 7);
            ShowConnectedResult(alg, 2, 4);
            Console.ReadKey();
        }

        /// <summary>
        /// Shows the connected result.
        /// </summary>
        /// <param name="alg">The alg.</param>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        private static void ShowConnectedResult(IAlgorithms alg, int a, int b)
        {
            Console.WriteLine();
            Console.WriteLine(alg.IsConnected(a, b) ? $"{a} and {b} are connected" : $"{a} and {b} are not connected");
        }
    }
}
