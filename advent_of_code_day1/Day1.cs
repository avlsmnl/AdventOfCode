using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    public class Day1
    {
        
        public int[] ConvertToIntArray(string[] data)
        {

            if (data == null)
            {
                Console.WriteLine("The array source must contain data.");
                return null;
            }

            return Array.ConvertAll(data, int.Parse);

        }

        public int FirstFrequencyTwice(int[] numberList, int startingFrequency)
        {
            bool repeated = false;
            List<int> noRepeatedFrequencies = new List<int>();

            do
            {
                foreach (int frequency in FrequencyChanges(numberList, startingFrequency))
                {
                    if (noRepeatedFrequencies.Contains(frequency))
                        return frequency;

                    noRepeatedFrequencies.Add(frequency);
                }
                startingFrequency = noRepeatedFrequencies.Last();
            } while (!repeated);

            return startingFrequency;

        }

        public int[] FrequencyChanges(int[] numberList, int startingFrequency)
        {

            if (numberList == null)
            {
                Console.WriteLine("The array source must contain data.");
                return null;
            }

            int frequency = startingFrequency;
            int[] frequencyChangeList = new int[numberList.Length];

            try
            {

                for (int index = 0; index < numberList.Length; index++)
                {
                    frequency += numberList[index];
                    frequencyChangeList[index] = frequency;                    
                }

                return frequencyChangeList;

            }
            finally
            {
                frequencyChangeList = null;
            }
        }
    }
}
