// See https://aka.ms/new-console-template for more information
using Exceptions_assignment;

//********************************************************FIRST STEP*******************************************************************************

string input = "1,not a number,2,3,4,5,6,7,8,should be discarded,9,10,11,12,13";

List<int> sortedNumbers = Methods.StringToNumbersArrayConverter(input);
Console.WriteLine();

string contentOfSortedNumbers = string.Join(", ", sortedNumbers);
Console.WriteLine($"Content of the list: {contentOfSortedNumbers}");

Console.WriteLine();
Console.ReadKey();

//********************************************************THIRD STEP - WRONG FILE PATH*******************************************************************************

string filePathToConvertFail = "C:\\Users\\Jon\\Desktop\\Lexicon .NET\\Assignments\\Week 5 - Exceptions assignment\\Exceptions Assignment text.txt";

WordsDTO wordsDTOFail = Methods.FilePathToObjectConverter(filePathToConvertFail);
string contentOfWordsDTOFail = string.Join(",", wordsDTOFail.WordsArray);

Console.WriteLine($"File parsed: {wordsDTOFail.Parsed}");
Console.WriteLine($"Status: {wordsDTOFail.Status}");
Console.WriteLine($"Words in file: {contentOfWordsDTOFail}");

Console.WriteLine();
Console.ReadKey();

//********************************************************THIRD STEP - CORRECT FILE PATH*******************************************************************************

string filePathToConvertSuccess = "C:\\Users\\Jon\\Desktop\\Lexicon .NET\\Assignments\\Week 5 - Exceptions assignment\\Exception Assignment text.txt";

WordsDTO wordsDTOSuccess = Methods.FilePathToObjectConverter(filePathToConvertSuccess);
string contentOfWordsDTOSuccess = string.Join(",",wordsDTOSuccess.WordsArray);

Console.WriteLine($"File parsed: {wordsDTOSuccess.Parsed}");
Console.WriteLine($"Status: {wordsDTOSuccess.Status}");
Console.WriteLine($"Words in file: {contentOfWordsDTOSuccess}");

Console.WriteLine();
Console.ReadKey();










