namespace Part1UnionConnected
{
    /// <summary>
    /// Interface IAlgorithms
    /// </summary>
    public interface IAlgorithms
    {
        /// <summary>
        /// Determines whether the specified a is connected.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns><c>true</c> if the specified a is connected; otherwise, <c>false</c>.</returns>
        bool IsConnected(int a, int b);

        /// <summary>
        /// Unions the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        void Union(int a, int b);

        /// <summary>
        /// Gets the ids.
        /// </summary>
        /// <returns>System.Int32[].</returns>
        int[] GetIds();
    }
}