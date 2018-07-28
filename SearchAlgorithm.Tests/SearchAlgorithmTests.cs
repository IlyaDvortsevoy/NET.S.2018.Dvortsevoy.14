using System;
using NUnit.Framework;

namespace SearchAlgorithm.Tests
{
    [TestFixture]
    public class SearchAlgorithmTests
    {
        private static readonly int[] TestInt = 
        {
            -12, -1, 0, 1, 33, 200, 501
        };

        private static readonly double[] TestDouble =
        {
            -44d, -13.6, 0d, 1.8, 14.456, 128d, 330.1345
        };

        private static readonly Person[] TestCustom =
        {
            new Person("Max", 20),
            new Person("Alex", 24),
            new Person("Vlad", 30)
        };

        [Test]
        public void BinarySearch_Method_Array_Parameter_Throws_ArgumentNullException()
        {
            Assert.That(
                () => Search<int>.BinarySearch(null, 12),
               Throws.InstanceOf<ArgumentNullException>());
        }

        [Test]
        public void BinarySearch_Method_Array_Parameter_Target_ArgumentNullException()
        {
            Assert.That(
                () => Search<Person>.BinarySearch(TestCustom, null),
               Throws.InstanceOf<ArgumentNullException>());
        }

        [Test]
        public void BinarySearch_Method_Typed_With_Int32_Works_Properly()
        {
            Assert.That(
                Search<int>.BinarySearch(TestInt, 33),
                Is.EqualTo(4));
        }

        [Test]
        public void BinarySearch_Method_Typed_With_Double_Works_Properly()
        {
            Assert.That(
                Search<double>.BinarySearch(TestDouble, -13.6),
                Is.EqualTo(1));
        }

        [Test]
        public void BinarySearch_Method_Typed_With_CustomType_Works_Properly()
        {
            Assert.That(
                Search<Person>.BinarySearch(TestCustom, new Person("Alex", 24)),
                Is.EqualTo(1));
        }
    }
}