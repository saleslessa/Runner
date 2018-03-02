using Microsoft.VisualStudio.TestTools.UnitTesting;
using Runner.Domain;
using System;

namespace Runner.Tests
{
    /// <summary>
    /// Test class for Sum of multiples library
    /// </summary>
    [TestClass]
    public class SumOfMultipleTest 
    {
        private readonly ISumOfMultiple _sumOfMultiple;

        public SumOfMultipleTest()
        {
            _sumOfMultiple = Container.GetService<ISumOfMultiple>();
        }

        /// <summary>
        /// First scenario: Testing scenario sending zero as parameter
        /// Should return zero
        /// </summary>
        [TestMethod]
        public void Should_Return_Zero_Cen1()
        {
            var param = 0;

            var result = _sumOfMultiple.Call(param);

            Assert.AreEqual(result, 0);
        }

        /// <summary>
        /// Second scenario: Testing scenario sending negative number as parameter
        /// Should return zero
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Return_Zero_Cen2()
        {
            var param = -10;

            var result = _sumOfMultiple.Call(param);

            Assert.AreEqual(result, 0);
        }

        /// <summary>
        /// First scenario: Testing scenario sending a valid positive number as parameter
        /// Should return the sum of multiples of 3 or 5 of numbers below parameter
        /// </summary>
        [TestMethod]
        public void Should_Return_Valid_Numbers()
        {
            var evenParam = 12;
            var oddParam = 25;
            var primeNumberParam = 31;

            var result1 = _sumOfMultiple.Call(evenParam);
            var result2 = _sumOfMultiple.Call(oddParam);
            var result3 = _sumOfMultiple.Call(primeNumberParam);

            Assert.AreEqual(result1, 33);
            Assert.AreEqual(result2, 143);
            Assert.AreEqual(result3, 225);
        }
    }
}
