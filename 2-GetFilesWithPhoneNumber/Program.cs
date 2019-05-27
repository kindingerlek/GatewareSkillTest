using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace GetFilesWithPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create regexpattern to match strings like: 00000-0000 or (00) 00000-0000
            var phoneRegex = @"((\(\d{2}\) )?(\d{4,5}-\d{4}))";

            var filesPaths = GetFilesRelativePaths(@"data\", "txt");
            var filteredFiles = FilterFilesByRegex(filesPaths, phoneRegex);

            Console.WriteLine($"Files that contains phone numbers:\n{string.Join('\n', filteredFiles)}");
        }

        static string[] GetFilesRelativePaths(string root, string type)
        {
            return Directory.GetFiles( AppDomain.CurrentDomain.BaseDirectory + root, $"*.{type}");
        }

        static string[] FilterFilesByRegex(string[] filesPaths, string regexPattern)
        {
            List<string> tempPath = new List<string>();
            Regex r = new Regex(regexPattern);

            foreach (string file in filesPaths)
            {
                string[] lines = File.ReadAllLines(file);

                if (lines.Any(l => r.IsMatch(l)))                
                    tempPath.Add(file);
            }
            return tempPath.ToArray();
        }
    }
}
