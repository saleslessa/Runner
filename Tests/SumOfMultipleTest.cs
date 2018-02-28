using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Runner.Tests
{
    /// <summary>
    /// Test class for Sum of multiples library
    /// </summary>
    [TestClass]
    public class SumOfMultipleTest : BaseTest
    {
        public SumOfMultipleTest() : base()
        {
 
        }

        /// <summary>
        /// First scenario: Testing scenario sending zero as parameter
        /// Should return zero
        /// </summary>
        [TestMethod]
        public void Should_Return_Zero_Cen1()
        {
            //Arrange
            var param = 0;

            //Act
            var result = _sumOfMultiple.Call(param);

            //Assert
            Assert.AreEqual(result, 0);
        }

        /// <summary>
        /// Second scenario: Testing scenario sending negative number as parameter
        /// Should return zero
        /// </summary>
        [TestMethod]
        public void Should_Return_Zero_Cen2()
        {
            //Arrange
            var param = -10;

            //Act
            var result = _sumOfMultiple.Call(param);

            //Assert
            Assert.AreEqual(result, 0);
        }

        /// <summary>
        /// First scenario: Testing scenario sending a valid positive number as parameter
        /// Should return the sum of multiples of 3 or 5 of numbers below parameter
        /// </summary>
        [TestMethod]
        public void Should_Return_Valid_Numbers()
        {
            //Arrange
            var evenParam = 12;
            var oddParam = 25;
            var primeNumberParam = 31;

            //Act
            var result1 = _sumOfMultiple.Call(evenParam);
            var result2 = _sumOfMultiple.Call(oddParam);
            var result3 = _sumOfMultiple.Call(primeNumberParam);

            //Assert
            Assert.AreEqual(result1, 33);
            Assert.AreEqual(result2, 143);
            Assert.AreEqual(result3, 225);
        }
    }
}
