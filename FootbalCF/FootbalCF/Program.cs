var inputString = Console.ReadLine();

var currentChar = ' ';
var sum = 0;

var first = true;

foreach(char c in inputString)
{
    if (sum == 7)
    {
        break;
    }

    if (first)
    {
        currentChar = c;
        first = false;
    }
    if (c.Equals(currentChar)){
        sum += 1;
        currentChar = c;
    }
    else
    {
        sum = 1;
        currentChar = c;
    }
}

if(sum == 7)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}

