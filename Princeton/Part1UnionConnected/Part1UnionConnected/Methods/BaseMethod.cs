
namespace Part1UnionConnected
{
    /// <summary>
    /// Class BaseMethod.
    /// Implements the <see cref="Part1UnionConnected.IAlgorithms" />
    /// </summary>
    /// <seealso cref="Part1UnionConnected.IAlgorithms" />
    public abstract class BaseMethod : IAlgorithms
    {
        /// <summary>
        /// The ids
        /// </summary>
        protected int[] ids;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMethod"/> class.
        /// </summary>
        /// <param name="N">The n.</param>
        protected BaseMethod(int N)
        {
            ids = new int[N];
            for (var i = 0; i < N; i++)
                ids[i] = i;
        }

        /// <summary>
        /// Determines whether the specified a is connected.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns><c>true</c> if the specified a is connected; otherwise, <c>false</c>.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public virtual bool IsConnected(int a, int b)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Unions the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public virtual void Union(int a, int b)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the ids.
        /// </summary>
        /// <returns>System.Int32[].</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int[] GetIds()
        {
            return ids;
        }
    }
}