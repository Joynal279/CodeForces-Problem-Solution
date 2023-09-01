var inputNumber = Console.ReadLine();

var count = 0;

foreach(char c in inputNumber)
{
    if(c == '4' || c == '7')
    {
        count += 1;
    }
}

if(count == 4 || count == 7)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}

