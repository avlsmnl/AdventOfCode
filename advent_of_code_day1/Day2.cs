using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Day2
    {

        public int Checksum(string[] words)
        {
            Tuple<int, int> checkSumValues = computeChecksumValues(words);

            if (checkSumValues == null)
            {
                Console.WriteLine("Checksum can't be computed.");
                return 0;
            }

            return ComputeChecksum(checkSumValues.Item1, checkSumValues.Item2);
        }

        Tuple<int, int> computeChecksumValues(string[] words)
        {

            if (words == null)
            {
                Console.WriteLine("The array source must contain data.");
                return null;
            }

            int twoCounter = 0;
            int threeCounter = 0;

            foreach (string word in words)
            {
                bool twoCounted = false;
                bool threeCounted = false;

                Dictionary<char, int> twos = new Dictionary<char, int>();
                Dictionary<char, int> threes = new Dictionary<char, int>();

                foreach (char character in word)
                {
                    int counter = CharacterCounter(word, character);

                    if (counter == 2 && !twos.ContainsKey(character))
                    {
                        twos.Add(character, 1);
                        if (!twoCounted) twoCounter++;
                        twoCounted = true;
                    }

                    if (counter == 3 && !threes.ContainsKey(character))
                    {
                        threes.Add(character, 1);
                        if (!threeCounted) threeCounter++;
                        threeCounted = true;
                    }
                }
            }

            return Tuple.Create<int, int>(twoCounter, threeCounter);

        }

        int CharacterCounter(string word, char character)
        {
            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("The word reference must contain data.");
                return 0;
            }
            return word.Count(ch => ch == character);
        }

        int ComputeChecksum(int twoCounter, int threeCounter)
        {
            return twoCounter * threeCounter;
        }
        
        public string CommonCharacters(string[] words)
        {
            foreach (var item in words)            
                foreach (var item1 in words)
                {
                    var differences = StringDifferences(item, item1);

                    if (differences == null) continue;

                    if (differences.Count == 1)                                            
                        return item.Remove(differences.First().Key, 1);                                            
                }
            return string.Empty;
        }

        static Dictionary<int, string> StringDifferences(string source, string destination)
        {

            if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(destination))
            {
                Console.WriteLine("The strings to compare must contain data.");
                return null;
            }

            if (source.Length != destination.Length)
            {
                Console.WriteLine("The strings to compare must be the same length.");
                return null;
            }

            Dictionary<int, string> diffs = new Dictionary<int, string>();

            for (int i = 0; i < source.Length; i++)
            {
                if (source.ElementAt(i) != destination.ElementAt(i))
                    diffs.Add(i, source.ElementAt(i) + "," + destination.ElementAt(i));

            }

            return diffs;

        }

        static string[] ReadFileData(string file)
        {
            if (!File.Exists(file))
            {
                Console.WriteLine("File {0} not found.", file);
                return null;
            }
            return File.ReadAllLines(file);
        }        
    }
}
