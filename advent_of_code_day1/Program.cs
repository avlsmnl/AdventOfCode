using System;
namespace AdventOfCode
{
    class Program
    {

        static void Main(string[] args)
        {
            startup();
            Console.ReadKey();
        }

        static void startup()
        {
            Console.WriteLine("We have you covered with the puzzle solutions for day 1 and 2.");
            Console.WriteLine("Select the day you want to test.");
            var dayChosed = Console.ReadLine();

            if (int.Parse(dayChosed) == 1)
                day1Adventure();
            else if (int.Parse(dayChosed) == 2)
                day2Adventure();
            else
            {
                Console.WriteLine("The selected option doesn't seem to exists.");
                startup();
            }
        }

        static void day1Adventure()
        {
            Day1 day1 = new Day1();

            string[] data = utils.FileUtils.ReadFileData(Consts.dataDay1);
            int[] numberList = day1.ConvertToIntArray(data);

            Console.WriteLine("First frequency twice: {0}", day1.FirstFrequencyTwice(numberList, 0));
        }

        static void day2Adventure()
        {
            Day2 day2 = new Day2();

            string[] words = utils.FileUtils.ReadFileData(Consts.dataDay2);

            Console.WriteLine("Checksum result: {0}", day2.Checksum(words));
            Console.WriteLine("Characters in common: {0}", day2.CommonCharacters(words));
        }


    }
}
