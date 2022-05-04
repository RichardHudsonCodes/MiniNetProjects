using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram_Checker
{
    public class Program
    {
        static void Main(string[] args)
        {
            var anagramChecker = new AnagramChecker();
            var inputsAreAnagrams = anagramChecker.CheckAnagramsAreValid("abcd", "cadb");
            Console.WriteLine($"inputs are anagrams of each other equals {inputsAreAnagrams}");
        }
    }
}
