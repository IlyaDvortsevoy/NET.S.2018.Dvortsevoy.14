using System;
using System.Collections.Generic;
using System.Numerics;

namespace Fibonacci
{
    /// <summary>
    /// Defines method for generating Fibonacci sequence
    /// </summary>
    public static class FibonacciSequence
    {
        #region Public API
        /// <summary>
        /// Generates the next number in the Fibonacci sequence within the given count
        /// </summary>
        /// <param name="count"> The number which sets the size of sequence </param>
        /// <returns></returns>
        public static IEnumerable<BigInteger> GetFibonacciSequence(int count)
        {
            ValidateParameter(count);

            BigInteger previous = 0;
            BigInteger next = 1;

            for (int i = 0; i < count; i++)
            {
                if (i == 0)
                {
                    yield return 0;
                }
                else if (i == 1)
                {
                    yield return 1;
                }
                else
                {
                    BigInteger temp = next;
                    next += previous;
                    previous = temp;

                    yield return next;
                }
            }
        }
        #endregion

        #region Private Methods
        private static void ValidateParameter(int count)
        {
            if (count <= 0)
            {
                throw new ArgumentNullException(
                    "The parameter should be more than zero",
                    nameof(count));
            }
        }
        #endregion
    }
}