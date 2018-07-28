using System;
using System.Collections.Generic;

namespace SearchAlgorithm
{
    /// <summary>
    /// Defines the generic method for binary search
    /// </summary>
    /// <typeparam name="T"> The type of objects in an array </typeparam>
    public static class Search<T>
    {
        #region Public API
        /// <summary>
        /// Searches some target object in a sorted array using binary search algorithm
        /// </summary>
        /// <param name="array"> The sorted array </param>
        /// <param name="target"> The object to find </param>
        /// <param name="comparer"> Custom comparer. If not defined a default comparer is used </param>
        /// <returns></returns>
        public static int BinarySearch(T[] array, T target, IComparer<T> comparer = null)
        {
            ValidateParameters(array, target, ref comparer);

            int start = 0;
            int end = array.Length - 1;

            while (start <= end)
            {
                int middle = (start + end) / 2;

                if (comparer.Compare(array[middle], target) == 0)
                {
                    return middle;
                }
                else if (comparer.Compare(array[middle], target) > 0)
                {
                    end = middle - 1;
                }
                else if (comparer.Compare(array[middle], target) < 0)
                {
                    start = middle + 1;
                }
            }

            return -1;
        }
        #endregion

        #region Private Methods
        private static void ValidateParameters(
            T[] array,
            T target,
            ref IComparer<T> comparer)
        {
            if (array == null)
            {
                throw new ArgumentNullException(
                    "The parameter shouldn't be null",
                    nameof(array));
            }

            if (target == null)
            {
                throw new ArgumentNullException(
                    "The parameter shouldn't be null",
                    nameof(target));
            }

            if (comparer == null)
            {
                comparer = Comparer<T>.Default ?? throw new ArgumentNullException(
                    "The parameter shouldn't be null",
                    nameof(comparer));
            }
        }
        #endregion
    }
}