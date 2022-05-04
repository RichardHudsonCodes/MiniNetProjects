using System;
using Xunit;
using Anagram_Checker;

namespace Anagram_Checker_Tests
{
    public class AnagramCheckerUnitTests
    {
        public AnagramChecker _anagramChecker = new AnagramChecker();

        [Fact]
        public void CheckAnagramsAreValid_ReturnsTrue_WhenValidAnagramsAreInputted()
        {
            //arrange
            var anagram = "visualstudio" ;
            var secondValidAnagram = "tdiisuluovsa";

            //action
            var anagramIsValid = _anagramChecker.CheckAnagramsAreValid(anagram, secondValidAnagram);

            //assert
            Assert.True(anagramIsValid);
        }

        [Fact]
        public void CheckAnagramsAreValid_ReturnFalse_WhenInValidAnagramsAreInputted()
        {
            //arrange
            var anagram = "visualstudio";
            var secondInvalidAnagram = "tdiisuluovsq";

            //action
            var anagramIsValid = _anagramChecker.CheckAnagramsAreValid(anagram, secondInvalidAnagram);

            //assert
            Assert.False(anagramIsValid);
        }

        [Fact]
        public void CheckAnagramsAreValid_ReturnFalse_WhenStringsWithDifferentLengthsAreTested()
        {
            //arrange
            var anagram = "visualstudio";
            var secondInvalidAnagram = "tdiisuluovsaas";

            //action
            var isValid = _anagramChecker.CheckAnagramsAreValid(anagram, secondInvalidAnagram);
            //assert
            Assert.False(isValid);
        }
    }
    
}
