using System.Text.RegularExpressions;

var word = Console.ReadLine();

var capitalWord = Regex.Replace(word, @"(^\w)|(\s\w)", m => m.Value.ToUpper());
Console.WriteLine(capitalWord);