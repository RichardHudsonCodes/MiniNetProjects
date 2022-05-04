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

    public class AnagramChecker
    {
        public AnagramChecker() { }

        public bool CheckAnagramsAreValid(string anagram, string secondAnagram)
        {
            var anagramDic = CreateDictionary(anagram);
            var secondAnagramDic = CreateDictionary(secondAnagram);

            return AreDictionariesEqual(anagramDic, secondAnagramDic); 
        }

        private Dictionary<char, int> CreateDictionary(string anagram)
        {
            var anagramDic = new Dictionary<char, int>();

            foreach (char character in anagram)
            {
                if (anagramDic.ContainsKey(character))
                {
                    anagramDic[character] += 1;
                }
                else
                {
                    anagramDic.Add(character, 1);
                }
            }

            return anagramDic;
        }

        private bool AreDictionariesEqual(Dictionary<char, int> firstDictionary, Dictionary<char, int> secondDictionary)
        {
            if (firstDictionary == null || secondDictionary == null) return false;
            if (firstDictionary.Count != secondDictionary.Count) return false;

            foreach (char character in firstDictionary.Keys)
            {
                var correspondingKey = secondDictionary.GetValueOrDefault(character);
                if (firstDictionary[character] != correspondingKey)
                {
                    return false;
                }
            }

            return true; 
        }
    }
}
