using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Runner.Tests
{
    /// <summary>
    /// Test class for Sequence Analysis library
    /// </summary>
    [TestClass]
    public class SequenceAnalysisTest
    {
        /// <summary>
        /// First scenario: Testing scenario sending an empty string as input
        /// Should return an empty string
        /// </summary>
        [TestMethod]
        public void Should_Return_Empty_String()
        {
            //Arrange
            var param = "";

            //Act
            var result = SequenceAnalysis.Call(param);

            //Assert
            Assert.AreEqual(result, "");
        }

        /// <summary>
        /// Second scenario: Testing scenario sending a string without capital letters
        /// Should return an empty string
        /// </summary>
        [TestMethod]
        public void Should_Return_Empty_String_Cen2()
        {
            //Arrange
            var param = "just a normal string";

            //Act
            var result = SequenceAnalysis.Call(param);

            //Assert
            Assert.AreEqual(result, "");
        }

        /// <summary>
        /// Third scenario: Testing scenario sending a string with only numbers
        /// Should return an empty string
        /// </summary>
        [TestMethod]
        public void Should_Return_Empty_String_Cen3()
        {
            //Arrange
            var param = "123123123";

            //Act
            var result = SequenceAnalysis.Call(param);

            //Assert
            Assert.AreEqual(result, "");
        }

        /// <summary>
        /// Fourth scenario: Testing scenario sending a string with only special characters
        /// Should return an empty string
        /// </summary>
        [TestMethod]
        public void Should_Return_Empty_String_Cen4()
        {
            //Arrange
            var param = "!@#%&***";

            //Act
            var result = SequenceAnalysis.Call(param);

            //Assert
            Assert.AreEqual(result, "");
        }

        /// <summary>
        /// Fifth scenario: Testing scenario sending a string with a mix of lower characters, numbers and special characters
        /// Should return an empty string
        /// </summary>
        [TestMethod]
        public void Should_Return_Empty_String_Cen5()
        {
            //Arrange
            var param = "!@#%&*13123test**";

            //Act
            var result = SequenceAnalysis.Call(param);

            //Assert
            Assert.AreEqual(result, "");
        }

        /// <summary>
        /// First scenario: Return only capital letters inside parameter ordered alphabetically
        /// </summary>
        [TestMethod]
        public void Shoud_Return_Only_Capital_Letters_Cen1() 
        {
            //Arrange
            var param = "Welcome To .NET Core 2.0";

            //Act
            var result = SequenceAnalysis.Call(param);

            //Assert
            Assert.AreEqual(result, "CENTTW");
        }

    }
}
