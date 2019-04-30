using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode;

namespace AdventOfCodeDay2.UnitTests
{
    [TestClass]
    public class Day2Tests
    {

        [TestMethod]
        public void Checksum_IsEqualsTo12_ReturnsTrue()
        {
            //Arrange
            var day2 = new Day2();

            //Act
            var result = day2.Checksum(new string[]
            {
                "abcdef",
                "bababc",
                "abbcde",
                "abcccd",
                "aabcdd",
                "abcdee",
                "ababab"
            });

            //Assert
            Assert.AreEqual(12, result);
        }
    
        [TestMethod]
        public void CharactersInCommon_IsEquelsToFgij_ReturnsTrue()
        {
            //Arrange
            var day2 = new Day2();

            //Act
            var result = day2.CommonCharacters(new string[] 
            {
                "abcde",
                "fghij",
                "klmno",
                "pqrst",
                "fguij",
                "axcye",
                "wvxyz"
            });

            //Assert
            Assert.AreEqual("fgij", result);
        }
    }
}
