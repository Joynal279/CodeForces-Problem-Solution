// See https://aka.ms/new-console-template for more information
var inputNumber = Convert.ToInt16(Console.ReadLine());
List<string> wordStringArray = new List<string>();

for (int i = 0; i < inputNumber; i++)
{
    wordStringArray.Add(Console.ReadLine());
}

for (int i = 0; i < inputNumber; i++)
{
    if (Convert.ToInt16(wordStringArray[i].Count()) <= 10)
    {
        Console.WriteLine(wordStringArray[i]);
    }
    else
    {
        var firstCharacter = wordStringArray[i].Substring(0, 1);
        var secondCharacter = wordStringArray[i].Substring(wordStringArray[i].Length - 1);
        var characterCount = wordStringArray[i].Count() - 2;
        Console.WriteLine(firstCharacter + characterCount + secondCharacter);
    }
}

