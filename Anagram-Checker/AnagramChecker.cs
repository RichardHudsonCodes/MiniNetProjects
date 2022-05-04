using System.Collections.Generic;

namespace Anagram_Checker
{
    public class AnagramChecker
    {
        public AnagramChecker() { }

        public bool CheckAnagramsAreValid(string anagram, string secondAnagram)
        {
            var anagramDictionary = CreateDictionary(anagram);
            var secondAnagramDictionary = CreateDictionary(secondAnagram);

            return AreDictionariesEqual(anagramDictionary, secondAnagramDictionary);
        }

        private Dictionary<char, int> CreateDictionary(string anagram)
        {
            var anagramDictionary = new Dictionary<char, int>();

            foreach (char character in anagram)
            {
                if (anagramDictionary.ContainsKey(character))
                {
                    anagramDictionary[character] += 1;
                }
                else
                {
                    anagramDictionary.Add(character, 1);
                }
            }

            return anagramDictionary;
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
