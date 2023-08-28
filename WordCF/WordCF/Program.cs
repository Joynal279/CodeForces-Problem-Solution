var inputWord = Console.ReadLine();
var totalChar = 0;
var totalUpper = 0;

foreach(char c in inputWord)
{
    totalChar += 1;
    if (char.IsUpper(c))
    {
        totalUpper += 1;
    }
}

if (totalUpper > (totalChar - totalUpper))
{
    Console.WriteLine(inputWord.ToUpper());
}
else
{
    Console.WriteLine(inputWord.ToLower());
}

