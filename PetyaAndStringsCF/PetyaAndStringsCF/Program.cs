var inputOne = Console.ReadLine().ToLower();
var inputTwo = Console.ReadLine().ToLower();

if (String.Compare(inputOne, inputTwo) < 0)
{
    // str1 is less than str2
    Console.WriteLine("-1");
}
else if (String.Compare(inputOne, inputTwo) == 0)
{
    // str1 is less than str2
    Console.WriteLine("0");
}
else
{
    Console.WriteLine("1");
}

//var output = string.Compare(inputTwo, inputOne);
//Console.WriteLine(output);

