using System;
using System.IO;
namespace AdventOfCode.utils
{
    public class FileUtils
    {
        public static string[] ReadFileData(string file)
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
