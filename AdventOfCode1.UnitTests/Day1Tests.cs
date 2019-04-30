using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode;

namespace AdventOfCode.UnitTests
{
    [TestClass]
    public class Day1Tests
    {
        /*
        [TestMethod]
        public void FirstFrequencyTwice_IsEqualsToZero_ReturnsFalse()
        {
            //Arrange
            var day1 = new Day1();

            //Act
            var result = day1.FirstFrequencyTwice(new int[] { 1, -1 }, 0);

            //Assert
            Assert.AreEqual(0, result);
        }
        */

        [TestMethod]
        public void FirstFrequencyTwice_IsEqualsToTen_ReturnsTrue()
        {
            //Arrange
            var day1 = new Day1();

            //Act
            var result = day1.FirstFrequencyTwice(new int[] { 3, 3, 4, -2, -4 }, 0);

            //Assert
            Assert.AreEqual(10, result);
        }
        
        [TestMethod]
        public void FirstFrequencyTwice_IsEqualsToFive_ReturnsTrue()
        {
            //Arrange
            var day1 = new Day1();

            //Act
            var result = day1.FirstFrequencyTwice(new int[] { -6, 3, 8, 5, -6 }, 0);

            //Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void FirstFrequencyTwice_IsEqualsToFourteen_ReturnsTrue()
        {
            //Arrange
            var day1 = new Day1();

            //Act
            var result = day1.FirstFrequencyTwice(new int[] { 7, 7, -2, -7, -4 }, 0);

            //Assert
            Assert.AreEqual(14, result);
        }
    }
}
