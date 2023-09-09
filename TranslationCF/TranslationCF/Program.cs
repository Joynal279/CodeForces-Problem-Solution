var firstInput = Console.ReadLine().ToString();
var secondInput = Console.ReadLine().ToString();

char[] stringArray = secondInput.ToCharArray();
Array.Reverse(stringArray);
string reversedStr = new string(stringArray);

if (firstInput == reversedStr)
{
    Console.WriteLine(reversedStr);
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine(reversedStr);
    Console.WriteLine("NO");
}

