using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_assignment
{
    public class Methods
    {
        public static List<int> StringToListConverterStringArray(string inputString)
        {
            List<int> NumbersList = new List<int>();
            
            string[] inputStringArray = inputString.Split(',');

            foreach (string item in inputStringArray)
            {
                try
                {
                    int number = int.Parse(item);
                    NumbersList.Add(number);
                }
                catch(FormatException)
                {
                    Console.WriteLine($"Entry discarded: \"{item}\"");
                }
            }

            List<int> NumbersListSorted = NumbersList
                .OrderByDescending(number => number)
                .ToList();

            return NumbersListSorted;            
        }

        public static List<int> StringToListConverterCharArray(string inputString)
        {
            List<int> NumbersList = new List<int>();

            char[] inputCharArray = inputString.ToCharArray();

            foreach (char item in inputCharArray)
            {
                try
                {
                    int number = int.Parse(item.ToString());
                    NumbersList.Add(number);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Entry discarded: \"{item}\"");
                }
            }

            List<int> NumbersListSorted = NumbersList
                .OrderByDescending(number => number)
                .ToList();

            return NumbersListSorted;
        }

        public static WordsDTO FilePathToObjectConverter(string inputFilePath)
        {
            WordsDTO wordsDTO = new WordsDTO();

            try
            {
                string[] inputFileDataArray = File.ReadAllText(inputFilePath).Split(',');

                wordsDTO.Parsed = true;
                wordsDTO.Status = "Success";
                wordsDTO.WordsArray = inputFileDataArray;
            }                      
            catch (Exception)
            {
                string[] fileNotFound = { "No content due to \"File not found\"" };

                wordsDTO.Parsed = false;
                wordsDTO.Status = "File not found";
                wordsDTO.WordsArray = fileNotFound;
            }

            return wordsDTO;
        }
    }
}
