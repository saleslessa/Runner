using Microsoft.VisualStudio.TestTools.UnitTesting;
using Runner.Domain;

namespace Runner.Tests
{
    /// <summary>
    /// Test class for Sequence Analysis library
    /// </summary>
    [TestClass]
    public class SequenceAnalysisTest 
    {
        private readonly ISequenceAnalysis _sequenceAnalysis;

        public SequenceAnalysisTest() 
        {
            _sequenceAnalysis = Container.GetService<ISequenceAnalysis>();
        }
        /// <summary>
        /// First scenario: Testing scenario sending an empty string as input
        /// Should return an empty string
        /// </summary>
        [TestMethod]
        public void Should_Return_Empty_String()
        {
            var param = "";

            var result = _sequenceAnalysis.Call(param);

            Assert.AreEqual(result, "");
        }

        /// <summary>
        /// Second scenario: Testing scenario sending a string without capital letters
        /// Should return an empty string
        /// </summary>
        [TestMethod]
        public void Should_Return_Empty_String_Cen2()
        {
            var param = "just a normal string";

            var result = _sequenceAnalysis.Call(param);

            Assert.AreEqual(result, "");
        }

        /// <summary>
        /// Third scenario: Testing scenario sending a string with only numbers
        /// Should return an empty string
        /// </summary>
        [TestMethod]
        public void Should_Return_Empty_String_Cen3()
        {
            var param = "123123123";

            var result = _sequenceAnalysis.Call(param);

            Assert.AreEqual(result, "");
        }

        /// <summary>
        /// Fourth scenario: Testing scenario sending a string with only special characters
        /// Should return an empty string
        /// </summary>
        [TestMethod]
        public void Should_Return_Empty_String_Cen4()
        {
            var param = "!@#%&***";

            var result = _sequenceAnalysis.Call(param);

            Assert.AreEqual(result, "");
        }

        /// <summary>
        /// Fifth scenario: Testing scenario sending a string with a mix of lower characters, numbers and special characters
        /// Should return an empty string
        /// </summary>
        [TestMethod]
        public void Should_Return_Empty_String_Cen5()
        {
            var param = "!@#%&*13123test**";

            var result = _sequenceAnalysis.Call(param);

            Assert.AreEqual(result, "");
        }

        /// <summary>
        /// First scenario: Return only capital letters inside parameter ordered alphabetically
        /// </summary>
        [TestMethod]
        public void Shoud_Return_Only_Capital_Letters_Cen1() 
        {
            var param = "Welcome To .NET Core 2.0";

            var result = _sequenceAnalysis.Call(param);

            Assert.AreEqual(result, "CENTTW");
        }

    }
}
