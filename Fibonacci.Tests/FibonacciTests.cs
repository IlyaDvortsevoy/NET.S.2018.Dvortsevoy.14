using NUnit.Framework;
using System;
using System.Collections;
using System.Numerics;
using System.Linq;

namespace Fibonacci.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        public static IEnumerable Data
        {
            get
            {
                yield return new TestCaseData(1).Returns(new BigInteger[] { 0 });
                yield return new TestCaseData(7).Returns(new BigInteger[] { 0, 1, 1, 2, 3, 5, 8 });
                yield return new TestCaseData(15).Returns(new BigInteger[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 });
            }
        }

        [TestCase(-1)]
        [TestCase(0)]
        public void GetFibonacciSequence_Method_Throws_ArgumentNullException(int count)
        {
            Assert.Throws<ArgumentNullException>(
                () => FibonacciSequence.GetFibonacciSequence(count).ToArray());
        }

        [Test, TestCaseSource(nameof(Data))]
        public BigInteger[] GetFibonacciSequence_Method_Works_Properly(int count)
        {
            return FibonacciSequence.GetFibonacciSequence(count).ToArray();
        }
    }
}