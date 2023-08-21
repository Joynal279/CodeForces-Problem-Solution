string myStr = Console.ReadLine();
var unique = new HashSet<char>(myStr);

var sum = 0;

foreach (char c in unique)
{
    sum += 1;
}

if (sum%2 == 0)
{
    Console.WriteLine("CHAT WITH HER!");
}
else
{
    Console.WriteLine("IGNORE HIM!");
}
    

