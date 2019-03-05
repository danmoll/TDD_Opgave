using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryString;

namespace TDD_Opgave_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSingleOccurrence()
        {
            //Arrange
            var stringToCheck = "mysterious";
            var stringToFind = "y";
            var expectedResult = 1;

            var classUnderTest = new StringUtilities();

            //Act
            var actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethodMultipleOccurences()
        {
            //Arrange
            var stringToCheck = "mysterious";
            var stringToFind = "s";
            var expectedResult = 2;

            var classUnderTest = new StringUtilities();

            //Act
            var actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethodCaseInsensitive()
        {
            //Arrange
            var stringToCheck = "mySterious";
            var stringToFind = "s";
            var expectedResult = 2;

            var classUnderTest = new StringUtilities();

            //Act
            var actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethodNull()
        {
            //Arrange
            string stringToCheck = null;
            var stringToFind = "s";
            var expectedResult = -1;

            var classUnderTest = new StringUtilities();

            //Act
            var actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
